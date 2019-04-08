using System;
using System.Diagnostics;
using System.Threading;
namespace RandonNumberThingy
{
    public class Threads
    {
        
        public static Stopwatch stwtch = new Stopwatch();        public static void result(Stopwatch stwtch ,int tcount)
         {
              TimeSpan time = stwtch.Elapsed;   
        Console.WriteLine("the final item count is: "+Add_or_Subtract.item.Item_Count);
        Console.WriteLine("it took {0} hours {1} minutes {2} seconds {3} milliseconds to complete the task",time.Hours,time.Minutes,time.Seconds,time.Milliseconds);
        Console.WriteLine("total thread count is: "+tcount);
       
        }
        public void CreateThread(int nums)
        {   
                
        stwtch.Start(); 
        Thread[] ThreadSwimmingPool = new Thread[nums];
            for(int i=0;i<nums;i++)
            {
                ThreadSwimmingPool[i] = new Thread(Startwork);
                ThreadSwimmingPool[i].Name = Convert.ToString(i+1);
               // Console.WriteLine("thread number {0} is created",ThreadSwimmingPool[i].ManagedThreadId);
                ThreadSwimmingPool[i].Start();
              //  Console.WriteLine("thread number {0} is started",ThreadSwimmingPool[i].ManagedThreadId);
            }
        
        }
         void Startwork()
        {
        Random rand = new Random();
        lock(rand){
            Work.work();
            Thread.Sleep(rand.Next(500,1000));
        }
        }  
    }
}

