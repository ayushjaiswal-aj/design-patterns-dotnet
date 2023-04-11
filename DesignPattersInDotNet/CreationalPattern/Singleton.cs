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
        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if(_instance == null)
            {
                return new Singleton();
            }
            return _instance;
        }

        //add business login if any
    }
}
