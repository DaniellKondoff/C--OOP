using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MordorsCrueltyPlan.Mood
{
   public class JavaScript : Mood
    {
        private const string MOOD_NAME = "JavaScript";

        public JavaScript()
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
