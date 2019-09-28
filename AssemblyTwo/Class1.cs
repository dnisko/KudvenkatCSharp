using System;
using static System.Console;
using AssemblyOne;

namespace AssemblyTwo
{
    //Part 50
    public class AssemblyTwoClass1 : AssemblyOneClass1
    {
        public void Print()
        {
            //must add reference to access another project and using
            AssemblyOneClass1 A1 = new AssemblyOneClass1();

            //ID is internal member
            //A1.ID = 101;

            base.ID1 = 101;

            AssemblyTwoClass1 A2 = new AssemblyTwoClass1();
            A2.ID1 = 102;
        }
    }

    //Part 51
    public class AssemblyTwoClass
    {
        public void Test()
        {
            AssemblyOneClass instance = new AssemblyOneClass();
            instance.Print();
        }
    }
}
