using System.Threading;
using System;
namespace RandonNumberThingy
{
    public class Work
    {
       static Random rand = new Random();
       // static Mutex mutty = new Mutex();
        static int thrcnt=0;
     public static void startwork()
    {
      //  Console.WriteLine("thread number {0} is requesting access to THE AREA!!!",Thread.CurrentThread.Name);
     //       mutty.WaitOne();
      // Console.WriteLine("thread number {0} has entered THE AREA!!!",Thread.CurrentThread.Name);
//THE AREA!!!
          Work wk = new Work();
          lock(wk){
        //  wk.work();
          }
//THE AREA!!!
Thread.Sleep(rand.Next(500,1000));
    //     Console.WriteLine("{0} is leaving THE AREA!!!",Thread.CurrentThread.Name);

       //   mutty.ReleaseMutex();
      //  Console.WriteLine("{0} has Exited THE AREA!!!",Thread.CurrentThread.Name);
    }
    }
/*    public void work()
        {
           // Monitor.Enter(thrcnt);
            Random rand = new Random();
            NewMethod();
             
            //Add_or_Subtract aos = new Add_or_Subtract();     
            Thread.Sleep(50);
            Add_or_Subtract.Operate_On_ItemCount(rand.Next(0, 9));
            if (thrcnt == Program.loops)
            {
                //displays the result
                Program.stwtch.Stop();
                Threads.result(Program.stwtch, thrcnt);
             //   Monitor.Exit(thrcnt);
            }
        }

        private static void NewMethod()
        {
            thrcnt++;
        }
    }    */
}