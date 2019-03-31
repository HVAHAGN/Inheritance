using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Method_08
{
    class DerivedClass:BaseClass
    {
        // Override base class method.
        

        public override void Method()
        {
            base.Method(); //call method from base class
            Console.WriteLine("Method from DerivedClass");
        }

    }
}
