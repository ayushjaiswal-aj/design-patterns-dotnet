using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattersInDotNet.CreationalPattern
{
    public sealed class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton _instance;

        private ThreadSafeSingleton() { }

        private static readonly object _lock = new object();

        public static ThreadSafeSingleton GetInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new ThreadSafeSingleton();
                }
            }
            return _instance;
        }
    }
}
