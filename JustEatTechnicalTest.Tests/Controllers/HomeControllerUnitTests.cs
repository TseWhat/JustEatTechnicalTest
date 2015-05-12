using JustEatTechnicalTest.APIAccess.Interfaces;
using JustEatTechnicalTest.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;

namespace JustEatTechnicalTest.Tests.Controllers
{
    [TestClass]
    public class HomeControllerUnitTests
    {
        [TestMethod]
        public void HomeControllerHasPublicConstructorWithIApiRepositoryParameter()
        {
            ConstructorInfo cInfo = typeof(HomeController).GetConstructor(new[] { typeof(IAPIRepository) });

            Assert.IsNotNull(cInfo);
            Assert.IsTrue(cInfo.IsPublic);
        }

        [TestMethod]
        public void HomeControllerHasIndexMethodWithNoParametersReturningActionResult()
        {
            MethodInfo mInfo = typeof(HomeController).GetMethod("Index", new Type[0]);

            Assert.IsNotNull(mInfo);
            Assert.IsTrue(mInfo.IsPublic);
            Assert.AreEqual(typeof(ActionResult), mInfo.ReturnType);
        }

        [TestMethod]
        public void HomeControllerHasGetRestaurantsMethodWithStringParameterReturningJsonResult()
        {
            MethodInfo mInfo = typeof(HomeController).GetMethod("GetRestaurants", new[] { typeof(string) });

            Assert.IsNotNull(mInfo);
            Assert.IsTrue(mInfo.IsPublic);
            Assert.AreEqual(typeof(JsonResult), mInfo.ReturnType);
        }

        [TestMethod]
        public void HomeControllerGetRestaurantsMethodCallsApiRepositoryGetRestaurantsMethod()
        {
            Mock<IAPIRepository> mockRepository = new Mock<IAPIRepository>();

            HomeController controller = new HomeController(mockRepository.Object);
            controller.GetRestaurants(GenerateRandomString());
            
            mockRepository.Verify(m => m.GetRestaurants(It.IsAny<string>()));
        }

        [TestMethod]
        public void HomeControllerGetRestaurantsMethodPassesStringParameterToApiRepositoryGetRestaurantsMethod()
        {
            Mock<IAPIRepository> mockRepository = new Mock<IAPIRepository>();

            HomeController controller = new HomeController(mockRepository.Object);
            string parameter = GenerateRandomString();
            controller.GetRestaurants(parameter);

            mockRepository.Verify(m => m.GetRestaurants(parameter));
        }

        private string GenerateRandomString()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var list = Enumerable.Repeat(0, 8).Select(x => chars[random.Next(chars.Length)]);
            return string.Join("", list);
        }
    }
}
