using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarSimulation.ConsoleUI.Models
{
    public sealed class Transmission : Entity<int>
    {
        public Transmission()
        {
            
        }
        public Transmission(int id , string name)
        {
            Id = id;
            Name = name;
        }
        public string? Name { get; set; }

        public override string ToString()
        {
            return $"Id : {Id} Name : {Name}";
        }

    }
}
