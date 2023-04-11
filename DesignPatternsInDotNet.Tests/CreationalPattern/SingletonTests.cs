using DesignPattersInDotNet.CreationalPattern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInDotNet.Tests.CreationalPattern
{
    [TestFixture]
    public class SingletonTests
    {
        /*
         * A perfect unit test for singleton class cannot be created
         * Its either 
         * 
         */
        [Test]
        public void GetInstance_WhenCalled_ShouldReturnInstanceOfSingletonClass()
        {
            Singleton singleton1 = Singleton.GetInstance("Instance 1");
            Singleton singleton2 = Singleton.GetInstance("Instance 2");

            Assert.That(singleton1.Value == singleton2.Value);
        }
    }
}
