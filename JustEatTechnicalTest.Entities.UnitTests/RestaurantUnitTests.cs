using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace JustEatTechnicalTest.Entities.UnitTests
{
    [TestClass]
    public class RestaurantUnitTests
    {
        [TestMethod]
        public void RestaurantClassIsPublic()
        {
            Assert.IsTrue(typeof(Restaurant).IsPublic);
        }

        [TestMethod]
        public void RestaurantClassHasPublicRestaurantNamePropertyOfTypeString()
        {
            PropertyInfo pInfo = typeof(Restaurant).GetProperty("RestaurantName");

            Assert.IsNotNull(pInfo);
            Assert.IsTrue(pInfo.CanRead);
            Assert.IsTrue(pInfo.CanWrite);
            Assert.AreEqual(typeof(string), pInfo.PropertyType);
        }

        [TestMethod]
        public void RestaurantClassHasPublicRatingPropertyOfTypeDecimal()
        {
            PropertyInfo pInfo = typeof(Restaurant).GetProperty("Rating");

            Assert.IsNotNull(pInfo);
            Assert.IsTrue(pInfo.CanRead);
            Assert.IsTrue(pInfo.CanWrite);
            Assert.AreEqual(typeof(decimal), pInfo.PropertyType);
        }

        [TestMethod]
        public void RestaurantClassHasPublicCuisineTypesPropertyOfTypeArrayOfStrings()
        {
            PropertyInfo pInfo = typeof(Restaurant).GetProperty("CuisineTypes");

            Assert.IsNotNull(pInfo);
            Assert.IsTrue(pInfo.CanRead);
            Assert.IsTrue(pInfo.CanWrite);
            Assert.AreEqual(typeof(string[]), pInfo.PropertyType);
        }

        [TestMethod]
        public void RestaurantClassHasPublicRestaurantLogoPropertyOfTypeString()
        {
            PropertyInfo pInfo = typeof(Restaurant).GetProperty("RestaurantLogo");

            Assert.IsNotNull(pInfo);
            Assert.IsTrue(pInfo.CanRead);
            Assert.IsTrue(pInfo.CanWrite);
            Assert.AreEqual(typeof(string), pInfo.PropertyType);
        }


    }
}
