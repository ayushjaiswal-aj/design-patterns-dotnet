using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattersInDotNet.CreationalPattern.FactoryMethodPattern
{
    class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Concreate Product 2}";
        }
    }
}
