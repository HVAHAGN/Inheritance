using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_07
{
    class DerivedClass:BaseClass
    {
        // Override base class method.
        //The virtual keyword is used to modify a method, property, indexer, or event declared in the base class 
        //and allow it to be overridden in the derived class. The override keyword is used to extend or modify
        //a virtual/abstract method, property, indexer, or event of base class into derived class

        public override void Method()
        {
            Console.WriteLine("Method from DerivedClass");
        }

    }
}
