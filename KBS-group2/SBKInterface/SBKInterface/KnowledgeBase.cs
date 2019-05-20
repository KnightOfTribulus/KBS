using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace SBKInterface
{
    public static class KnowledgeBase
    {
        public static string filepath = "Resources/rules.json";
        private static string debugfile = "Resources/debug.txt";
        public static List<string> antId { get; set; }

        public static List<string> antVals { get; set; }

        public static List<string> consId { get; set; }

        public static List<string> consVals { get; set; }

        public static void Read()
        {
            var json = File.ReadAllText(filepath);
            var rules = JsonConvert.DeserializeObject<List<List<string>>>(json);
            antId = rules[0];
            antVals = rules[1];
            consId = rules[2];
            consVals = rules[3];            
        }

        public static void Save(string input)
        {
            File.WriteAllText(filepath, input);
        }
    }
}
