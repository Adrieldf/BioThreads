using System;
using System.Collections.Generic;
using System.Text;

namespace BioThreads.Models
{
    class Gene
    {
        public string Name { get; set; }
        public string Identifier { get; set; }
        public string Category { get; set; }
        public string Subcategory { get; set; }
        public string Role { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public string Genetic { get; set; }

        
       public Gene(string name, string identifier, string category, string subCategory, string role, string code1, string code2, string genetic)
        {
            Name = name;
            Identifier = identifier;
            Category = category;
            Subcategory = subCategory;
            Role = role;
            Code1 = code1;
            Code2 = code2;
            Genetic = genetic;

        }
    }
}
