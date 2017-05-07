using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06.Birthday.Interfaces;

namespace _06.Birthday
{
    public class Robot : ICitizen
    {
        public Robot(string model, string id)
        {
            this.Id = id;
            this.Model = model;
        }
        public string Id { get; set; }

        public string Model { get; set; }

    }
}
