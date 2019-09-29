using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace KudvenkatCSharp
{
    public partial class SamplePartialClass
    {
        partial void SamplePartialMethod();
        //partial method has 2 parts - 1. definition and implementation (in PartialClassFileTwo)

        public void PublicMethod()
        {
            WriteLine("PublicMethod Invoked");
            SamplePartialMethod();
        }
    }
}
