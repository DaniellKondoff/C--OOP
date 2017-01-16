using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _10.Enums_and_Attributes
{
    public class Cat
    {
        

        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        public DateTime BithDate { get; set; }

        [Range(0,50)]
        public int Age { get; set; }

       
    }
}
