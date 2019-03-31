﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_02
{
    class BaseClass
    {
        
        public string publicField = "BasePublicField";
        private string privateField = "BaseClassPrivateField";
        protected string protectedField = "BaseClassProtected field";

        //Method
        public void Show()
        {
            Console.WriteLine(privateField);
        }

    }
}
