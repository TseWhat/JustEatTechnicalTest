using JustEatTechnicalTest.APIAccess.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RestSharp;
using System;
using System.Linq;

namespace JustEatTechnicalTest.APIAccess.UnitTests
{
    [TestClass]
    public class APIRepositoryUnitTests
    {
        [TestMethod]
        public void ApiRepositoryIsPublic()
        {
            Assert.IsTrue(typeof(APIRepository).IsPublic);
        }

        [TestMethod]
        public void ApiRepositoryImplementsApiRepositoryInterface()
        {
            Assert.IsNotNull(typeof(APIRepository).GetInterface("IAPIRepository"));
        }

        [TestMethod]
        public void ApiRepositoryGetRestaurantsMethodCallsRestClientExecuteMethod()
        {
            Mock<IRestClient> restClient = new Mock<IRestClient>();
            restClient.Setup(r => r.Execute(It.IsAny<IRestRequest>())).Returns(new RestResponse());

            APIRepository repository = new APIRepository(restClient.Object);

            repository.GetRestaurants(GenerateRandomString());

            restClient.Verify(r => r.Execute(It.IsAny<IRestRequest>()));
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
