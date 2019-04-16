using System;
using System.Diagnostics;
using RandomNumberThingy.Threads;
using RandonNumberThingy.ItemManager;
using static System.Console;
namespace RandonNumberThingy
{
    public class Worker
    {
        Random random = new Random();
        public void Work()
        {
            WriteLine("Starting the process");
            var stopWatch = Stopwatch.StartNew();
            var threads = random.Next(500,1000);
            var threadManager = new ThreadManager(threads);
            var repository = new ItemRepository(random);
            threadManager.ForEachThread(new ThreadWorker(repository,random));
            stopWatch.Stop();
            WriteLine($"Executed {threads} threads in {stopWatch.Elapsed.ToString()}");
            WriteLine($"Item count in repository is {repository.GetQuantity()}");
            WriteLine("Stopping host");
        }

        class ThreadWorker : IThreadExecutor
        {
            private readonly ItemRepository repository;
            private readonly Random random;

            public ThreadWorker(ItemRepository repository, 
            Random random)
            {
                this.repository = repository;
                this.random = random;
            }
            public void OnThread()
            {
                var number = random.Next(1,6);
                if (random.NextDouble() > 0.5)
                {
                    number*=-1;
                }
                WriteLine(number > 0 ? $"Adding {number} items" : $"Subtracting {Math.Abs(number)} items");
                repository.UpdateQuantity(number);
                WriteLine($"Thread executed");
            }
        }
    }
}