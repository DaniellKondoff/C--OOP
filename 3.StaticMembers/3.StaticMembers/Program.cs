using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.StaticMembers
{
    public class Englishman
    {
        public  static int referendumQueueCount;
        public static int goodReason;
        public int queuePosition;

        public Englishman()
        {
            this.queuePosition = ++referendumQueueCount;
        }
        static Englishman(){
            referendumQueueCount = new Random().Next(20);
            goodReason = referendumQueueCount + 5;
        }
    }
   public class Program
    {
        public static void Main(string[] args)
        {
            Englishman ivan = new Englishman();
            Englishman Mimi = new Englishman();
        }
    }
}
