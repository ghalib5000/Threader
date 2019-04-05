using System;
using System.Diagnostics;
using System.Threading;
namespace RandonNumberThingy
{
    class Program
    {
     static   Item_Manager item = new Item_Manager();
        static void Main(string[] args)
        { 
           
            Randomizer r = new Randomizer(); 
            int loops= r.create_Randomizer(500000,1000000);
            Stopwatch stwtch = new Stopwatch();
            stwtch.Start(); 
  

            for(int i=0;i<500;i++)
            {//NUMBER OF THREADS MADE
                Thread t = new Thread(work);    
                t.Start();
                t.Join();
                int y= t.ManagedThreadId;
                Console.WriteLine("the current thread number is {0}",y);
            }
          
             
        stwtch.Stop();
        TimeSpan time = stwtch.Elapsed;
        Console.WriteLine("the final item count is: "+Program.item.Item_Count);
        Console.WriteLine("it took {0} hours {1} minutes {2} seconds {3} millisecondsto complete the task",time.Hours,time.Minutes,time.Seconds,time.Milliseconds);
        }
        static void work()
        {
        Randomizer r = new Randomizer();
        int temp=0;        
        
        Add_or_Subtract aos = new Add_or_Subtract();     
        Thread.Sleep(50);
        temp = aos.Get_Number(r.create_Randomizer(0,9));
      item.Item_Count = item.Item_Count+temp;
        item.Item_Checker();
        }
    }
}