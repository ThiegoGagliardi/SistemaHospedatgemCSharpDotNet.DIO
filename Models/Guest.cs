using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagemCSharpDotNet.DIO.Models
{
    public class Guest
    {
        public string Name { get; }

        public string Surname { get; }

        public string FullName => $"{Name} {Surname}".ToUpper();

        public Guest(string name, string surname){
            
            this.Name    = name;
            this.Surname = surname;
        }

        public Guest(string name){
            
            this.Name     = name;
             this.Surname = "";
        }
    }
}