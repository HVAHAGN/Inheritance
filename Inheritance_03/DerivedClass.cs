using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_03
{
    class DerivedClass : BaseClass
    {
        public int derivedField;

        // The default constructor.
        // public DerivedClass ()
        // {
        //}

        // Custom constructor.
        // When creating a derived class object, the constructor of the derived class
        // automatically calls the default constructor from the base class.
        // The constructor of the base class will assign all its own safe values ​​to all data.
        // After that, the constructor of the derived class will start working again.
        // will define values ​​for inherited members. (DOUBLE WORK)!
        public DerivedClass(int number1, int number2)
        {
            // Initialize the base class field.
            baseNumber = number1;

            // Initialize the field of the derived (given) class.
            derivedField = number2;

        }
    }
}