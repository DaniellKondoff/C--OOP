using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public  class Melon : Food
    {
        private const int POINTS_OF_HAPPINESS = 1;

        public Melon()
        {
        }

        public override int givePointsOfHappines()
        {

            return POINTS_OF_HAPPINESS;
        }
    }

