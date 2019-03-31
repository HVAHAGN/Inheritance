using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Program
    { //Subclasses inherit the features of one superclass.Inheritance
      // Inheritance.

        // Inheritance is an object-oriented programming mechanism that allows you to describe a new (derived) class
        // based on the already existing (base)
        // with this, the properties and functionality of the base class are borrowed by the new derived class.

        // Base class - Derived class
        // Super class - Subclass or (subclass)
        // Parent Class - Child Class
        // Parent - Child

        static void Main(string[] args)
        {

            DerivedClass instance = new DerivedClass();
            Console.WriteLine(instance.publicField);
            Console.ReadLine();
        }
    }
}
