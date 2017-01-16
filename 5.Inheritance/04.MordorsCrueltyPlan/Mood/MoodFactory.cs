using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MordorsCrueltyPlan.Mood
{
   public class MoodFactory
    {
        public Mood createMood(int points)
        {
            Mood mood = null;

            if (points < -5)
            {
                mood = new Angry();
            }
            else if (points >= -5 && points < 0)
            {
                mood = new Sad();
            }
            else if (points >= 0 && points <= 15)
            {
                mood = new Happy();
            }
            else
            {
                mood = new JavaScript();
            }

            return mood;
        }
    }
}
