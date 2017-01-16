using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MordorsCrueltyPlan.Mood
{
   public class Sad : Mood
    {
        private const string MOOD_NAME = "Sad";

        public Sad()
        {

        }

        public override string GetMoodName
        {
            get
            {
                return MOOD_NAME;
            }
        }
    }
}
