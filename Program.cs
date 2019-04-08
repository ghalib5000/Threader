using System;
using System.Threading;
namespace RandonNumberThingy
{
    class Program
    {
      static Random rand = new Random();
        static int loops= rand.Next(500,1000);
        
        static void Main(string[] args)
        { 
        Threads trcreater = new Threads();
        trcreater.CreateThread(loops);
        }

            public static int getLoopCount
      {
          get{
                return loops;
          }
          set
          {
          }
      }
    }
}
