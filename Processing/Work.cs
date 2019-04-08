using System.Threading;
using System;
namespace RandonNumberThingy
{
    public class Work
    {
       static object locker = new object();
       static int thrcnt=0;
         public static void work()
        {
          lock(locker)
        {
          Program looper = new Program();
            Random rand = new Random();
            int loop= looper.getLoopCount;
            thrcnt++;
            //TimeSpan time = Threads.stwtch.Elapsed;
        Console.WriteLine("the current thread number is {0}",Thread.CurrentThread.Name);
      //  Console.WriteLine("the current time is {0} seconds {1} milliseconds to complete the task",time.Seconds,time.Milliseconds);
        
        Add_or_Subtract aos = new Add_or_Subtract();
        aos.Operate(rand.Next(0,9));     
        Thread.Sleep(50);
        if(thrcnt==loop)
        {
        //displays the result
        Threads.stwtch.Stop();
        Threads.result(Threads.stwtch,thrcnt);
        }        
        }
        }
}
}