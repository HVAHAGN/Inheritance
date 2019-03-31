using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_11
{
    // Sealed classes.

    namespace Inheritance
    {
        sealed class SealedClass
        {
            public int x;
            public int y;
        }

        // Attempting to inherit from SealedClass results in a compiler error.

        class DerivedClass //: SealedClass // Error
        {
        }

        class program
        {
            static void Main()
            {
                SealedClass instance = new SealedClass();
                instance.x = 100;
                instance.y = 200;

                Console.WriteLine("x = {0}, y = {1}", instance.x, instance.y);

                // Delay.
                Console.ReadKey();
            }
        }
    }

}