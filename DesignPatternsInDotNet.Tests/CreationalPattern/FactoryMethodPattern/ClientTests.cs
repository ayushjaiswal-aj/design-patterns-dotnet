using DesignPattersInDotNet.CreationalPattern.FactoryMethodPattern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInDotNet.Tests.CreationalPattern
{
    [TestFixture]
    public class ClientTests
    {
        [Test]
        public void ClientOperation_WhenProvidedWithConcreateCreator1_ShouldPerformOperationFromConcreteProduct1()
        {
            Creator creator = new ConcreteCreator1();
            String expectedOperationResponse = $"Executing function from: {creator.SomeOperation()}";

            String actualOperationResponse = Client.ClientOperation(new ConcreteCreator1());

            Assert.That(actualOperationResponse, Is.EqualTo(expectedOperationResponse));
        }
    }
}
