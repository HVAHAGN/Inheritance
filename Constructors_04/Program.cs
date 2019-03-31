using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_04
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass(1, 5);

            Console.WriteLine(instance.baseNumber);
            Console.WriteLine(instance.derivedField);
            Console.ReadLine(); 
        }
    }
}
