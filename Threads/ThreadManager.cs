
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RandomNumberThingy.Threads
{
    class ThreadManager
    {
        private readonly int threadCount;

        public ThreadManager(int threadCount)
        {
            this.threadCount = threadCount;
        }
        public void ForEachThread(IThreadExecutor threadExecutor)
        {
            var tasks = new List<Task>();
            for (int i = 0; i < threadCount; i++)
            {
                tasks.Add(Task.Factory.StartNew(() => threadExecutor.OnThread()));
            }
            foreach (var task in tasks)
            {
                task.Wait();
            }
        }
    }

    interface IThreadExecutor
    {
        void OnThread();
    }
}