using System;
using static System.Console;

namespace AssemblyOne
{
    //Part 50
    public class AssemblyOneClass1
    {
        internal int ID = 101;

        protected internal int ID1 = 101;
    }

    public class AssemblyOneClass2
    {
        public void SampleMethod()
        {
            AssemblyOneClass1 A1 = new AssemblyOneClass1();
            WriteLine(A1.ID);

            AssemblyOneClass1 A2 = new AssemblyOneClass1();
            WriteLine(A2.ID);
        }
    }
    //Part 51
    public class AssemblyOneClass //not specified type modifier, default is internal
    {
        public void Print()
        {
            WriteLine("Hello");
        }
    }
}
