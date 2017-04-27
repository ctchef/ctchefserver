using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using ChefDemo.Models;

namespace ChefDemo.Tests.Service
{
    [TestFixture]
    class IndexFixture
    {
        [Test]
        public void VerifyGet()
        {
            // Arrange
            //Mock<Index> mockIndex = new Mock<Index>();
            //mockIndex.Setup(m => m.FirstName).Returns("ABC");
            //mockIndex.Setup(m => m.LastName).Returns("DEF");

            // Act
            Index index = new ChefDemo.Service.Index().Get();

            // Assert
            Assert.AreEqual("Chef", index.FirstName);
            Assert.AreEqual("Demo", index.LastName);
            
        }
    }
}
