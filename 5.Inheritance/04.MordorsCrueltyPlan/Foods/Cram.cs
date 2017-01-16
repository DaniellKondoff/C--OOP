using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class Cram :Food
    {
        private const int POINTS_OF_HAPPINESS = 2;
        public Cram()
        {

        }

        public override int givePointsOfHappines()
        {

            return POINTS_OF_HAPPINESS;
        }
    }

