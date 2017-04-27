using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;

namespace ChefDemo.Tests.Controller
{
    [TestFixture]
    class IndexControllerFixture
    {
        [Test]
        public void VerifyIndexAction()
        { 
            //// Arrange
            //Mock<ChefDemo.Service.Index> indexService = new Mock<ChefDemo.Service.Index>();
            //indexService.Setup(i => i.Get()).Returns(new ChefDemo.Models.Index() { 
            //    FirstName  = "ABC",
            //    LastName = "DEF"
            //});

            // Act
            dynamic viewResult = new ChefDemo.Controllers.IndexController().Index();

            Assert.AreEqual("Chef", viewResult.Model.FirstName);
            Assert.AreEqual("Demo", viewResult.Model.LastName);
        }
    }
}
