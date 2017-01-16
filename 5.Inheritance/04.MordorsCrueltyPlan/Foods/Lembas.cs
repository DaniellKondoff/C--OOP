using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class Lembas:Food
    {
        private const int POINTS_OF_HAPPINESS = 3;
        public Lembas()
        {

        }

        public override int givePointsOfHappines()
        {

            return POINTS_OF_HAPPINESS;
        }
    }

