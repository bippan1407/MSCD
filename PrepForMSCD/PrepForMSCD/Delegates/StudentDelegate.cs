using PrepForMSCD.Student;
using System;

namespace PrepForMSCD.Delegates
{
    public class StudentDelegate
    {
        public delegate void StudentVoidDelegate();
        public delegate string StudentStringDelegate();
        public delegate void ImplementAddition(int a, int b);
        public delegate void AddDelgate(ImplementAddition implementAddition);
        

        private readonly StudentInfo _studentInfo;

        public StudentDelegate()
        {
            _studentInfo = new StudentInfo();
        }

        public void InitializeDelegate()
        {
            // delegate simple working implementation
            StudentVoidDelegate studentVoidDel = new StudentVoidDelegate(_studentInfo.VoidReturnType);
            studentVoidDel();
            StudentStringDelegate studentStringDel = new StudentStringDelegate(_studentInfo.StudentDescription);
            Console.WriteLine(studentStringDel());
            StudentVoidDelegate studentAnother = _studentInfo.AnotherVoidReturnType;
            studentAnother();
            Console.WriteLine("\n\n\n");

            //delegate addition

            StudentVoidDelegate delegateAddition = studentVoidDel + studentAnother;
            delegateAddition();
            Console.WriteLine("\n\n\n");

            //delegate subtraction
            StudentVoidDelegate delegateSubtraction = delegateAddition - studentAnother;
            delegateSubtraction();
            Console.WriteLine("\n\n\n");

            _studentInfo.PassingDelegate(delegateAddition);

            ImplementAddition implementAddition = _studentInfo.Add;
            AddDelgate add = _studentInfo.AddFunctionWithDelegate;
            add(implementAddition);

    }
    }
}
