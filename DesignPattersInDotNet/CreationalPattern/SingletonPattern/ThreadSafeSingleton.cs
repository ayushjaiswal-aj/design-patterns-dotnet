using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattersInDotNet.CreationalPattern.SingletonPattern
{
    public sealed class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton _instance;

        public String Value { get; set; }

        private ThreadSafeSingleton() { }

        private static readonly object _lock = new object();

        public static ThreadSafeSingleton GetInstance(String value)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new ThreadSafeSingleton();
                    _instance.Value = value;
                }
            }
            return _instance;
        }
    }
}
