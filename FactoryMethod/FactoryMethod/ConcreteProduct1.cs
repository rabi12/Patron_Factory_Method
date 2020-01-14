using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}
