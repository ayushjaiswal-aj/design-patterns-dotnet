using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattersInDotNet.BehavioralPattern
{
    class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if (((Subject)subject).State == 0 || ((Subject)subject).State >= 2)
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            }
        }
    }
}
