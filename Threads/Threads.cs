using System;
using System.Diagnostics;
using System.Threading;
namespace RandonNumberThingy
{
    public class Threads
    {
        static Randomizer r = new Randomizer();
         
       
        public static void result(Stopwatch stwtch ,int tcount)
         {
              TimeSpan time = stwtch.Elapsed;   
        Console.WriteLine("the final item count is: "+Add_or_Subtract.item.Item_Count);
        Console.WriteLine("it took {0} hours {1} minutes {2} seconds {3} milliseconds to complete the task",time.Hours,time.Minutes,time.Seconds,time.Milliseconds);
        Console.WriteLine("total thread count is: "+tcount);
       
        }
        public static void CreateThread(int nums)
        {   
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
        static void Startwork()
    {
    Mutex mutty = new Mutex();
      //  Console.WriteLine("thread number {0} is requesting access to THE AREA!!!",Thread.CurrentThread.Name);
            mutty.WaitOne();
      // Console.WriteLine("thread number {0} has entered THE AREA!!!",Thread.CurrentThread.Name);
//THE AREA!!!

       Program.work();

//THE AREA!!!
Thread.Sleep(r.create_Randomizer(500,1000));
    //     Console.WriteLine("{0} is leaving THE AREA!!!",Thread.CurrentThread.Name);

       //   mutty.ReleaseMutex();
      //  Console.WriteLine("{0} has Exited THE AREA!!!",Thread.CurrentThread.Name);
    }
    
    }
}