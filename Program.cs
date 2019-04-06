using System;
using System.Diagnostics;
using System.Threading;
namespace RandonNumberThingy
{
    class Program
    {
        static Stopwatch stwtch = new Stopwatch();
        static Randomizer r = new Randomizer();
                static int loops= r.create_Randomizer(5000,10000);
        static int cc=0;
        static int thrcnt=0;


        static void Main(string[] args)
        { 
            
            stwtch.Start(); 
            lock (r){
        Threads.CreateThread(loops);
            }
        }
        public static void work()
        {
            thrcnt++;
            cc++;
        int temp=0;  
        Console.WriteLine("the current thread number is {0}",Thread.CurrentThread.Name);
        Add_or_Subtract aos = new Add_or_Subtract();     
        Thread.Sleep(50);
        aos.Get_Number(r.create_Randomizer(0,9));

        if(cc==loops)
        {
        //displays the result
        stwtch.Stop();
        Threads.result(stwtch,thrcnt);
        }        
        }
    
    }
}