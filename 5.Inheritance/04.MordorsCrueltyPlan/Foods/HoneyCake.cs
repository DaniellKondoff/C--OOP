using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class HoneyCake : Food
    {
        private const int POINTS_OF_HAPPINESS = 5;

        public HoneyCake()
        {
        }

        public override int givePointsOfHappines()
        {

            return POINTS_OF_HAPPINESS;
        }
    }

