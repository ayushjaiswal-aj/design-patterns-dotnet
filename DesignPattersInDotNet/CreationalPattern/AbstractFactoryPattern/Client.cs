using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattersInDotNet.CreationalPattern.AbstractFactoryPattern
{
    public class Client
    {
        public static String ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            return productB.UsefulFunctionB() + productB.AnotherUsefulFunctionB(productA);
        }
    }
}
