using System;
using System.Diagnostics;
using System.Threading;
namespace RandonNumberThingy
{
    class Program
    {
        static Stopwatch stwtch = new Stopwatch();
        static Randomizer r = new Randomizer();
        static public  Item_Manager item = new Item_Manager();
        static int loops= r.create_Randomizer(500,1000);
        static int cc=0;
        static int thrcnt=0;
    private static Mutex mutty = new Mutex();
        static void Main(string[] args)
        { 
            
            stwtch.Start(); 
            lock (r){

            Thread[] ThreadSwimmingPool = new Thread[loops];
            for(int i=0;i<loops;i++)
            {
                ThreadSwimmingPool[i] = new Thread(func);
                ThreadSwimmingPool[i].Name = Convert.ToString(i);
             //   Console.WriteLine("thread number {0} is created",ThreadSwimmingPool[i].ManagedThreadId);
                ThreadSwimmingPool[i].Start();
              //  Console.WriteLine("thread number {0} is started",ThreadSwimmingPool[i].ManagedThreadId);
            }
        stwtch.Stop();
            }
        }
        static void work()
        {
            thrcnt++;
            cc++;
        int temp=0;  
        Console.WriteLine("the current thread number is {0}",Thread.CurrentThread.Name);
        Add_or_Subtract aos = new Add_or_Subtract();     
        Thread.Sleep(50);
        temp = aos.Get_Number(r.create_Randomizer(0,9));
      item.Item_Count = item.Item_Count+temp;
        item.Item_Checker();
        if(cc==loops)
        {
        //displays the result
        Threads.result(stwtch,thrcnt);
        }        
        }
    static void func()
    {

      //  Console.WriteLine("thread number {0} is requesting access to THE AREA!!!",Thread.CurrentThread.Name);
       mutty.WaitOne();
     //  Console.WriteLine("thread number {0} has entered THE AREA!!!",Thread.CurrentThread.Name);
//THE AREA!!!

        work();

//THE AREA!!!
Thread.Sleep(r.create_Randomizer(500,1000));
    //     Console.WriteLine("{0} is leaving THE AREA!!!",Thread.CurrentThread.Name);
         mutty.ReleaseMutex();
      //  Console.WriteLine("{0} has Exited THE AREA!!!",Thread.CurrentThread.Name);
    }
    }
}