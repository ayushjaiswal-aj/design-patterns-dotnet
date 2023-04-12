using DesignPattersInDotNet.CreationalPattern.BuilderPattern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInDotNet.Tests.CreationalPattern.BuilderPattern
{
    [TestFixture]
    public class DirectorTests
    {
        [Test]
        public void BuildMinimalViableProduct_WhenCalled_ShouldReturnProductWithPartA()
        {
            Director director = new Director();
            ConcreteBuilder builder = new ConcreteBuilder();
            director.Builder = builder;
            string expectedString = "Product parts: PartA1\n";

            director.BuildMinimalViableProduct();

            string actualString = builder.GetProduct().ListParts();
            Assert.That(actualString, Is.EqualTo(expectedString));
        }

        [Test]
        public void BuildFullFeaturedProduct_WhenCalled_ShouldReturnProductWithAllParts()
        {
            Director director = new Director();
            ConcreteBuilder builder = new ConcreteBuilder();
            director.Builder = builder;
            string expectedString = "Product parts: PartA1, PartB1, PartC1\n";

            director.BuildFullFeaturedProduct();

            string actualString = builder.GetProduct().ListParts();
            Assert.That(actualString, Is.EqualTo(expectedString));
        }
    }
}
