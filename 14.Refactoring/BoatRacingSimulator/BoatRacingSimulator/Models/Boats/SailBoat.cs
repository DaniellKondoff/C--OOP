using BoatRacingSimulator.Interfaces;
using BoatRacingSimulator.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRacingSimulator.Models.Boats
{
    public class SailBoat : Boat
    {
        private int sailEfficiency;

        public SailBoat(string model, int weight, int sailEfficiency) 
            : base(model, weight)
        {
            this.SailEfficiency = sailEfficiency;
        }

        public int SailEfficiency
        {
            get
            {
                return this.sailEfficiency;
            }

            private set
            {
                Validator.ValidateSailEffectivenness(value);
                this.sailEfficiency = value;
            }
        }

        public override double CalculateRaceSpeed(IRace race)
        {
            var speed = (race.WindSpeed * (this.SailEfficiency / 100d)) - this.Weight + (race.OceanCurrentSpeed / 2d);
            return speed;
        }
    }
}
