using PrepForMSCD.CustomAttribute;
using PrepForMSCD.Delegates;
using PrepForMSCD.InputOutput;
using System;

namespace PrepForMSCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start\n\n");
            //StudentDelegate call = new StudentDelegate();
            //call.InitializeDelegate();
            //NewAttribute.AttributeDisplay(typeof(Employer));

            //Console.WriteLine();

            //NewAttribute.AttributeDisplay(typeof(Employee));

            InputOutputOperations iop = new InputOutputOperations();
            iop.Appendtext();
            Console.WriteLine("\n\nend");
        }
    }
}
