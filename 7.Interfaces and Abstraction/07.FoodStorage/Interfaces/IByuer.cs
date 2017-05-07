using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FoodStorage.Interfaces
{
    public interface IByuer
    {
        int Food { get; set; }
        void BuyFood();
    }
}
