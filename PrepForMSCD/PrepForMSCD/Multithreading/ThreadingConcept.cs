using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PrepForMSCD.Multithreading
{
    public static class ThreadingConcept
    {
        public static void FrontTyre()
        {
            for(int i = 1; i<10; i++)
            {
                Console.WriteLine($"Front Tyre is moving at a speed of {i}");
                Thread.Sleep(1000);
            }
        }

        public static void BackTyre()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"Back Tyre is moving at a speed of {i}");
                Thread.Sleep(1000);
            }
        }

        public static void StartBike()
        {
            FrontTyre();
            BackTyre();
        }

        public static void CarThread()
        {
            Thread thread = new Thread(new ParameterizedThreadStart(CarWithPassengers));
            thread.Start(4);
        }

        public static void CarWithPassengers(object passengerNo)
        {
            var type1 = passengerNo.GetType().Name;
            var type2 = typeof(int).Name;
            if (type1.Equals(type2))
            {
                for(int i =0; i<(int)passengerNo; i++)
                {
                    Console.WriteLine($"passenger number {i} gets out of the car ");
                    Thread.Sleep(1000);
                }
            }
            else
            {
                Console.WriteLine($"Please enter the valid number ");
            }
        }

        public static void ParallelForLoop()
        {
            //for(int i=0;i<10;i++)
            //{
            //    Console.WriteLine(i);
            //    Thread.Sleep(1000);
            //}
            Parallel.For(0, 10, (i) =>
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            });
        }

        public static void PLinq()
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel()
            .Where(i => i % 2 == 0)
            .ToArray();
            foreach (int i in parallelResult)
                Console.WriteLine(i);
        }
    }
}
