using System;
using System.Diagnostics;
using System.Threading;
namespace RandonNumberThingy
{
    public class Threads
    {
        
        public static void result(Stopwatch stwtch ,int tcount)
         {
              TimeSpan time = stwtch.Elapsed;   
        Console.WriteLine("the final item count is: "+Program.item.Item_Count);
        Console.WriteLine("it took {0} hours {1} minutes {2} seconds {3} milliseconds to complete the task",time.Hours,time.Minutes,time.Seconds,time.Milliseconds);
        Console.WriteLine("total thread count is: "+tcount);
       
        }
    }
}