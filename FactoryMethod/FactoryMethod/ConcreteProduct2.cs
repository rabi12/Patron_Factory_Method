using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}
