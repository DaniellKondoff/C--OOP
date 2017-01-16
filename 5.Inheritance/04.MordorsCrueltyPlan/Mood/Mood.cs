using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MordorsCrueltyPlan.Mood
{
   public abstract class Mood
    {
        public Mood()
        {
        }

        public abstract string GetMoodName { get;}
    }
}
