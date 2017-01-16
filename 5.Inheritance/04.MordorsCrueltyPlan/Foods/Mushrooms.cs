using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class Mushrooms : Food
    {
        private const int POINTS_OF_HAPPINESS = -10;

        public Mushrooms()
        {
        }

        public override int givePointsOfHappines()
        {

            return POINTS_OF_HAPPINESS;
        }
    }

