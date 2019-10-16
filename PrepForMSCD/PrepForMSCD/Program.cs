using PrepForMSCD.CustomAttribute;
using PrepForMSCD.Delegates;
using PrepForMSCD.InputOutput;
using PrepForMSCD.Multithreading;
using PrepForMSCD.Tasks;
using PrepwayMSCD.Delegates;
using System;
using System.Threading;

namespace PrepForMSCD
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("start\n\n");
            //StudentDelegate call = new StudentDelegate();
            //call.InitializeDelegate();
            //NewAttribute.AttributeDisplay(typeof(Employer));

            //Console.WriteLine();

            //NewAttribute.AttributeDisplay(typeof(Employee));

            //InputOutputOperations iop = new InputOutputOperations();
            //iop.CompressionAndDecompression();

            //DelegatesOperation.Operations();

            //Thread thread = new Thread(new ThreadStart(ThreadingConcept.StartBike));
            //thread.Start();
            //thread.Join();
            //ThreadingConcept.CarThread();

            //MultiTasking.StartTask();

            //ThreadingConcept.ParallelForLoop();

            ThreadingConcept.PLinq();


            Console.WriteLine("\n\nend");
        }
    }
}
