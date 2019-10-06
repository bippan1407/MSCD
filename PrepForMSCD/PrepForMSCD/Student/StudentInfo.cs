using System;
using System.Collections.Generic;
using System.Text;
using static PrepForMSCD.Delegates.StudentDelegate;

namespace PrepForMSCD.Student
{
    class StudentInfo
    {
        public int RollNo { get; set; }
        public string FirstName { get; set; }

        public void VoidReturnType()
        {
            Console.WriteLine(" ****** From void return type ********");
        }

        public void AnotherVoidReturnType()
        {
            Console.WriteLine(" ########## From another void return type ###########");
        }

        public string StudentDescription()
        {
            return "hello" + " " + "world";
        }

        public void PassingDelegate(StudentVoidDelegate call)
        {
            Console.WriteLine(" from Passing delegate ");
            call();
        }

        public void Add(int value1, int value2)
        {
            Console.WriteLine(value1 + value2);
        }

        public void AddFunctionWithDelegate(ImplementAddition implementAddition)
        {
            Console.WriteLine(" ***** addition started ******* ");
            implementAddition(9,8);
        }
    }
}
