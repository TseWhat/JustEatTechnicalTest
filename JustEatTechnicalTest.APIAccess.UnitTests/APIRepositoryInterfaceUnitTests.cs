using JustEatTechnicalTest.APIAccess.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace JustEatTechnicalTest.APIAccess.UnitTests
{
    [TestClass]
    public class APIRepositoryInterfaceUnitTests
    {
        [TestMethod]
        public void ApiRepositoryInterfaceIsPublic()
        {
            Assert.IsTrue(typeof(IAPIRepository).IsPublic);
        }

        [TestMethod]
        public void ApiRepositoryInterfaceHasMethodGetRestaurantsWithStringParameterReturningObject()
        {
            MethodInfo mInfo = typeof(IAPIRepository).GetMethod("GetRestaurants", new[] { typeof(string) });

            Assert.IsNotNull(mInfo);
            Assert.IsTrue(mInfo.IsPublic);
            Assert.AreEqual(typeof(object), mInfo.ReturnType);
        }
    }
}
