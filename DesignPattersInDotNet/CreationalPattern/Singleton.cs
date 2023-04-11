using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattersInDotNet.CreationalPattern
{
    public sealed class Singleton
    {
        private static Singleton _instance = null;
        public String Value { get; set; }

        private Singleton()
        {

        }

        public static Singleton GetInstance(String value)
        {
            if(_instance == null)
            {
                _instance = new Singleton();
                _instance.Value = value;
                return _instance;
            }
            return _instance;
        }

        //add business login if any
    }
}
