using System;
using System.Diagnostics;
using System.Threading;
namespace RandonNumberThingy
{
    class Program
    {
        static void Main(string[] args)
        { 
            Stopwatch stwtch = new Stopwatch();
            stwtch.Start(); 
             int temp=0;
             Randomizer r = new Randomizer(); 
             Item_Manager item = new Item_Manager();
             Add_or_Subtract aos = new Add_or_Subtract();
             
        int loops= r.create_Randomizer(500000,1000000);

        for(int i=0;i<50;i++)
        {//NUMBER OF THREADS MADE
        Thread.Sleep(500);
        temp = aos.Get_Number(r.create_Randomizer(0,9));
        item.Item_Count = item.Item_Count+temp;
        item.Item_Checker();
        }
        stwtch.Stop();
        double time = stwtch.ElapsedMilliseconds;
        Console.WriteLine("the final item count is: "+item.Item_Count);
        Console.WriteLine("it took "+ time+" milliseconds to complete the task");
    }
}
}
