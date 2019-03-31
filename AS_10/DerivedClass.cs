using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_10
{
    class DerivedClass:BaseClass
    {
        // Override base class method.
        

        public override void Method()
        {
           Console.WriteLine("Method from DerivedClass");
        }

    }
}
