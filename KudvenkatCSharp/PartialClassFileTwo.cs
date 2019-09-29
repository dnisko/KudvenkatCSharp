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
        partial void SamplePartialMethod()
        {
            WriteLine("SamplePartialMethod Invoked");
        }
    }
}
