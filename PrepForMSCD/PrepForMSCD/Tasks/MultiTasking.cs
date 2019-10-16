using System;
using System.Threading.Tasks;

namespace PrepForMSCD.Tasks
{
    public static class MultiTasking
    {

        public static void StartTask()
        {
            Task<int> task = Task.Run(() =>
            {
                Console.WriteLine("Task is running");
                return 42;
            });
            task.ContinueWith((i) =>
        {
            Console.WriteLine(" Task failed ");
        }, TaskContinuationOptions.OnlyOnFaulted);

            task.ContinueWith((i) =>
                {
                    Console.WriteLine("Task Completed successfully");
                }, TaskContinuationOptions.OnlyOnRanToCompletion);

            Console.WriteLine(task.Result);
        }
    }
}

