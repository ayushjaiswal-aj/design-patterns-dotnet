using DesignPattersInDotNet.CreationalPattern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatternsInDotNet.Tests.CreationalPattern
{
    [TestFixture]
    public class ThreadSafeSingletonTests
    {
        [Test]
        public void GetInstance_WhenCalled_ShouldReturnThreadSafeInstanceOfSingletonClass()
        {
            String instanceProcess1 = String.Empty;
            String instanceProcess2 = String.Empty;
            Thread process1 = new Thread(() =>
            {
                instanceProcess1 = _testSingleton("FOO");
            });
            Thread process2 = new Thread(() =>
            {
                instanceProcess2 = _testSingleton("BAR");
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();

            Assert.That(instanceProcess1 == instanceProcess2);
        }

        private static String _testSingleton(string value)
        {
            ThreadSafeSingleton instance = ThreadSafeSingleton.GetInstance(value);
            return instance.Value;
        }
    }
}
