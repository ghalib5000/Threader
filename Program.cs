using System;
using System.Threading;
namespace RandonNumberThingy
{
    class Program
    {
      // static Random rand = new Random();
     //   static int loops= rand.Next(500,1000);
        private static int loops=0;
        
        static void Main(string[] args)
        { 
            Random rand = new Random();
         loops= rand.Next(500,1000);
        Threads trcreater = new Threads();  
        trcreater.CreateThread(loops);
        }


            public int getLoopCount
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
