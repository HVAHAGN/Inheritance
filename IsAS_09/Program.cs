using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAS_09
{
    class ClassA {/* ... */}

    class ClassB : ClassA {/* ... */}

    class program
    {
        static void Main()
        {
            ClassB b = new ClassB();
            ClassA a = null;

            // --------------------------------------------- is - -------------------------------------------
            // Operator is - checks the compatibility of the object with the specified type.
            // If the supplied object can be cast to the supplied type without raising an exception,
            // expression is true.

            // For example, the following code determines whether an object is an instance of type A or of a type derived from A:

            if (b is ClassA)
            {
                a = (ClassA)b;
            }
            else
            {
                a = null;
            }

            // --------------------------------------------- as-- -------------------------------------------
            // The as operator is used to perform conversions between compatible reference types.
            // The as operator is similar to the cast operator. However, if the conversion is not possible,
            // as returns null, but does not raise an exception.

            // In general, the logic of the as operator is a mechanism for using the is operator
            // (example on line 25), only in abbreviated form.

            a = b as ClassA;

            // Delay.
            Console.ReadKey();
        }
    }
}
