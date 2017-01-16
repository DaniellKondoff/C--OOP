using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MordorsCrueltyPlan.Mood
{
    public class Angry  : Mood
    {
        private const string MOOD_NAME = "Angry";

        public Angry()
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
