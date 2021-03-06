﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Method_12
{
    // Sealed methods.

    partial class ClassA
    {
        public virtual void Method1() { Console.WriteLine("ClassA.Method1"); }
        public virtual void Method2() { Console.WriteLine("ClassA.Method2"); }
    }
    partial class ClassA
    {

    }

    class ClassB : ClassA
    {
        sealed public override void Method1() { Console.WriteLine("ClassB.Method1"); }
        public override void Method2() { Console.WriteLine("ClassB.Method2"); }
    }

    class ClassC : ClassB
    {
        // Attempting to override Method1 results in a compiler error: CS0239.
        // public override void Method1 () {Console.WriteLine ("ClassC.Method1"); }

        // Override Method2 allowed.
        public override void Method2() { Console.WriteLine("ClassC.Method2"); }
    }

    class program
    {
        static void Main()
        {
            ClassA instanceA = new ClassA();
            instanceA.Method1();
            instanceA.Method2();

            Console.WriteLine(new string('-', 15));

            ClassB instanceB = new ClassB();
            instanceB.Method1();
            instanceB.Method2();

            Console.WriteLine(new string('-', 15));

            ClassC instanceC = new ClassC();
            instanceC.Method1();
            instanceC.Method2();

            // Delay.
            Console.ReadKey();
        }
    }
}
