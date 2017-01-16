using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MordorsCrueltyPlan.Mood
{
   public class Happy : Mood
    {
        private const string MOOD_NAME = "Happy";

        public Happy()
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
