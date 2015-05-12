using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace JustEatTechnicalTest.Entities.UnitTests
{
    [TestClass]
    public class RestParametersUnitTests
    {
        [TestMethod]
        public void RestParametersClassIsPublic()
        {
            Assert.IsTrue(typeof(RestParameters).IsPublic);
        }

        [TestMethod]
        public void RestParametersClassHasPublicParameterNamePropertyOfTypeString()
        {
            PropertyInfo pInfo = typeof(RestParameters).GetProperty("ParameterName");

            Assert.IsNotNull(pInfo);
            Assert.IsTrue(pInfo.CanRead);
            Assert.IsTrue(pInfo.CanWrite);
            Assert.AreEqual(typeof(string), pInfo.PropertyType);
        }

        [TestMethod]
        public void RestParametersClassHasPublicParameterValuePropertyOfTypeString()
        {
            PropertyInfo pInfo = typeof(RestParameters).GetProperty("ParameterValue");

            Assert.IsNotNull(pInfo);
            Assert.IsTrue(pInfo.CanRead);
            Assert.IsTrue(pInfo.CanWrite);
            Assert.AreEqual(typeof(string), pInfo.PropertyType);
        }

    }
}
