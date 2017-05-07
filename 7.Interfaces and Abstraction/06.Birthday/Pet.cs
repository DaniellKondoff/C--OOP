using _06.Birthday.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Birthday
{
    public class Pet : IBirthdate
    {
        public Pet(string name,DateTime birthdate)
        {
            this.Name = name;
            this.BirthDate = birthdate;
        }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        
    }
}
