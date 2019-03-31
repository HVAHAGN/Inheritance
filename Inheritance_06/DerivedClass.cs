using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_06
{
    class DerivedClass:BaseClass
    {
        // Substitute base class method.

        public void Method()
        {
            Console.WriteLine("Method from DerivedClass");
        }

    }
}
