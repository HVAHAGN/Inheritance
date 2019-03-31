using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_04
{
    class DerivedClass : BaseClass
    {
        public int derivedField;

        // The default constructor.
        public DerivedClass()
        {

        }

         // Custom constructor.
         // The custom constructor of the base class is invoked;
         // assign values to inherited members in the constructor of the derived class.

        public DerivedClass(int number1, int number2)
            :base(number1)
        {
            
            baseNumber = number1;

            // Initialize the field of the derived (given) class.
            derivedField = number2;

        }
    }
}