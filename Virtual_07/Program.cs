using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_07
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();

            // UpCast
            BaseClass instanceUp = instance;
            instanceUp.Method();

            // DownCast
            DerivedClass instanceDown = (DerivedClass)instanceUp;
            instanceDown.Method();

            //Method from DerivedClass
            //Method from DerivedClass
            //Method from DerivedClass

            Console.ReadLine();
        }
    }
}
