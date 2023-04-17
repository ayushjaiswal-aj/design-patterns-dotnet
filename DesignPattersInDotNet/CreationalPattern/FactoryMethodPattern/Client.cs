using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattersInDotNet.CreationalPattern.FactoryMethodPattern
{
    public class Client
    {
        public static String ClientOperation(Creator creator)
        {
            return $"Executing function from: {creator.SomeOperation()}";
        }
    }
}
