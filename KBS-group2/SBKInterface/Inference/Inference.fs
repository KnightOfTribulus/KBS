namespace Inference        
    module public Inference =
        
        open System
        open System.IO
        open System.Collections.Generic
        open Newtonsoft.Json

        type Fact = {variable : string; value : string}
        
        type Rule = 
            {ant1 : Fact option;
            ant2 : Fact option;
            ant3 : Fact option;
            cons : Fact}  
            with 
                member this.IsActive(allfacts : Fact list) =
                    
                    let check f =                         
                        f 
                        |> Option.map(fun fa -> List.contains fa allfacts)
                        |> Option.defaultValue true
                    let matcher f1 f2 f3 =
                        match (check f1, check f2, check f3) with
                        | (true, true, true) -> true
                        | _ -> false
                    matcher this.ant1 this.ant2 this.ant3

                member this.Contains(fact : Fact) =
                    if (this.ant1 = Some fact) || (this.ant2 = Some fact) || (this.ant3 = Some fact) then true
                    else false

                member this.IsFinal(rules : Rule list) =
                    if rules |> List.exists (fun rule -> rule.Contains(this.cons)) then false
                    else true

        //Class constructor takes sequences that represents rules
        type public Mechanism (antIds : string seq, antVals : string seq, consIds : string seq, consVals : string seq)=                                    
            
            //inner values
            let antecedent_lenght = 3
            let defaultInference = "Вывод не был получен."

            let antId_Triples = 
                antIds 
                |> Seq.chunkBySize antecedent_lenght
                |> Seq.map(fun s -> Seq.toList s)
                |> Seq.toList            
            
            let antVal_Triples = 
                antVals
                |> Seq.chunkBySize antecedent_lenght
                |> Seq.map(fun s -> Seq.toList s)
                |> Seq.toList
                        
            let ConsIDs = consIds |> Seq.toList
            let ConsVals = consVals |> Seq.toList                       
            
            let RulesSeq =
                seq{
                    for triple_ind in [0..antId_Triples.Length-1] do 
                        let FactsSeq =                             
                            seq{
                                for ind in [0..2] do
                                    match antId_Triples.[triple_ind].[ind] with //!!!
                                    | null -> yield None 
                                    | _ -> yield Some {variable = antId_Triples.[triple_ind].[ind]; value = antVal_Triples.[triple_ind].[ind]}                                        
                            }
                        let FactsList = FactsSeq |> Seq.toList
                        let conseq = {variable = ConsIDs.[triple_ind]; value = ConsVals.[triple_ind]}

                        yield {ant1 = FactsList.[0]; ant2 = FactsList.[1]; ant3 = FactsList.[2]; cons = conseq}
                        
                }
                        
            let ParseToFacts (input : string) =
                let splitters = [|"\r\n";"\r";"\n"|] 
                let innerSplitters = Array.create 1 "-"
                let splitOps = System.StringSplitOptions.RemoveEmptyEntries

                let facts = 
                    input.Split(splitters, splitOps)
                    |> Array.map(fun s -> s.Split(innerSplitters, splitOps))
                    |> Array.map(fun pair -> {variable = pair.[0]; value = pair.[1]})
                    |> Array.toList                    
                facts                   //return value
                
            member public __.Infer(input : string) =    //bad parameters, 1 string parsing
                let rules = Seq.toList RulesSeq
                let mutable all_facts = ParseToFacts input                
                
                let rec infer (queue : Fact list) (result : Fact option) =
                    match queue with 
                    | head :: tail -> 
                        match rules |> List.tryFind(fun el -> el.Contains(head)) with 
                        | Some rule ->  
                            if rule.IsActive all_facts then
                                if rule.IsFinal(rules) then Some rule.cons
                                else
                                    all_facts <- (all_facts |> List.map(fun el -> if el.variable = rule.cons.variable then rule.cons else el))
                                    infer (tail @ [rule.cons]) result
                            else infer tail result
                        | None -> infer tail result
                    | [] -> result

                let res = infer all_facts None                      
                match res with 
                | None -> defaultInference
                | Some cons -> cons.variable + " " + cons.value

    
        let public MakeInference(facts: string, antIds : string seq, antVals : string seq, consIds : string seq, consVals : string seq) =
            
            let l = [antIds; antVals; consIds; consVals]

            let j = JsonConvert.SerializeObject(l, Formatting.Indented)
            File.WriteAllText("Resources/output.json",j)

            let jf = JsonConvert.SerializeObject(facts, Formatting.Indented)
            File.WriteAllText("Resources/facts.json",jf)

            let mech = new Mechanism(antIds, antVals, consIds, consVals)
            let result = mech.Infer(facts)
            result