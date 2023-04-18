using DesignPattersInDotNet.CreationalPattern.AbstractFactoryPattern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInDotNet.Tests.CreationalPattern.AbstractFactoryPattern
{
    [TestFixture]
    public class ClientTests
    {
        [Test]
        public void ClientMethod_WhenCalledWithConcreteFactory1_ShouldReturnCorrectString()
        {
            ConcreteFactory1 factory = new ();
            String expectedString = "The result of the product B1.The result of the B1 collaborating with the (The result of the product A1.)";
            String actualString = Client.ClientMethod(factory);

            Assert.That(actualString, Is.EqualTo(expectedString));
        }

        [Test]
        public void ClientMethod_WhenCalledWithConcreteFactory2_ShouldReturnCorrectString()
        {
            ConcreteFactory2 factory = new ();
            String expectedString = "The result of the product B2.The result of the B2 collaborating with the (The result of the product A2.)";
            String actualString = Client.ClientMethod(factory);

            Assert.That(actualString, Is.EqualTo(expectedString));
        }
    }
}
