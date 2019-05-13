namespace Inference        
    module public Inference =
        
        open System.Collections.Generic

        type Fact = {variable : string; value : string}
        
        type Rule = 
            {ant1 : Fact option;
            ant2 : Fact option;
            ant3 : Fact option;
            cons : Fact}  
            with 
                member this.IsActiveAt (fact: Fact) (allfacts : Fact list) =
                    
                    let check f =                         
                        f 
                        |> Option.map(fun fa -> List.contains fa allfacts)
                        |> Option.defaultValue true
                    let matcher f1 f2 f3 =
                        match (check f1, check f2, check f3) with
                        | (true, true, true) -> true
                        | _ -> false
                    
                    if (this.ant1.IsSome && this.ant1.Value = fact) then matcher (Some fact) this.ant2 this.ant3 //1
                    elif (this.ant2.IsSome && this.ant2.Value = fact) then matcher this.ant1 (Some fact) this.ant3 //2
                    elif (this.ant3.IsSome && this.ant3.Value = fact) then matcher this.ant1 this.ant3 (Some fact) //3
                    else false
        
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
                    for triple_ind in [0..antId_Triples.Length] do 
                        let FactsSeq =                             
                            seq{
                                for ind in [0..2] do
                                    match antId_Triples.[triple_ind].[ind] with
                                    | null -> yield None 
                                    | _ -> yield Some {variable = antId_Triples.[triple_ind].[ind]; value = antVal_Triples.[triple_ind].[ind]}                                        
                            }
                        let FactsList = FactsSeq |> Seq.toList
                        let conseq = {variable = ConsIDs.[triple_ind]; value = ConsVals.[triple_ind]}
                        yield {ant1 = FactsList.[0]; ant2 = FactsList.[1]; ant3 = FactsList.[2]; cons = conseq}
                }
            let activatedRules = new List<Rule>()
            //inner functions   
            let CreateFacts (ids : string seq) (vals : string seq) =
                let IDs = ids |> Seq.toList
                let VALs = vals |> Seq.toList
                let FactSeq = 
                    seq {
                        for i in [0..IDs.Length] do 
                            yield {variable = IDs.[i]; value = VALs.[i]}
                    }
                Seq.toList FactSeq
            


            member public __.Infer(ids : string seq, vals : string seq) =                
                let rules = Seq.toList RulesSeq
                let initial_facts = CreateFacts ids vals                
                let initial_table = initial_facts                                

                let analyzeFact fact allfacts=                      
                    match rules |> List.tryFind(fun r -> r.IsActiveAt fact allfacts) with 
                    |Some rule -> 
                        activatedRules.Add(rule)
                        (List.contains rule.cons allfacts, Some rule)
                    |None -> (false, None)
                                            
                let rec infer (queue: Fact list) table result = 
                    match queue with 
                    | head::tail -> 
                        match analyzeFact head table with
                        | true, Some rule -> infer tail (List.map (fun f -> if f.variable = rule.cons.variable then rule.cons else f) table) (Some (rule.cons.variable + "-" + rule.cons.value))
                        | false, Some rule -> Some (rule.cons.variable + "-" + rule.cons.value)
                        | _ -> None
                    | [] -> result
                        
                infer initial_facts initial_table None
                |> Option.defaultValue defaultInference
                
            
