using System;
using System.Threading;
namespace RandonNumberThingy
{
    class Program
    {
        private const string App_ID = "KenHaise.MutexDemo";
        static void Main(string[] args)
        {
            var mutex = new Mutex(true, App_ID);
            if (mutex.WaitOne(0, false))
            {
                new Worker().Work();
            }
            else
            {
                throw new Exception("Host is already running");
            }
        }
    }
}
