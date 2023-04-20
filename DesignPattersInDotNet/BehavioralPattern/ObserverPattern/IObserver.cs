using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattersInDotNet.BehavioralPattern
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}
