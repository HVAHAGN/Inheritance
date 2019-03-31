using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_03
{
    class BaseClass
    {
        public int baseNumber;

        // The default constructor.
        public BaseClass()
        {
        }

        // Custom constructor.
        public BaseClass(int baseNumber)
        {
            this.baseNumber = baseNumber;
        }
    }
}
