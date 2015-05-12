using JustEatTechnicalTest.APIAccess.Interfaces;
using JustEatTechnicalTest.Entities;
using RestSharp;
using System;
using System.Collections.Generic;

namespace JustEatTechnicalTest.APIAccess.Repositories
{
    public class APIRepository : IAPIRepository
    {
        private const string url = "http://api-interview.just-eat.com";
        private const string restaurants = "/restaurants";
        private IRestClient _client;

        public APIRepository(IRestClient client)
        {
            _client = client;
        }

        public object GetRestaurants(string outcode)
        {
            List<RestParameters> parameter = new List<RestParameters>();
            parameter.Add(new RestParameters { ParameterName = "q", ParameterValue = outcode });
            var result = CallAPI(restaurants, parameter);

            return result;
        }

        private object CallAPI(string requestUrl, List<RestParameters> parameters)
        {
            try
            {
                _client.BaseUrl = new Uri(url);
                var request = new RestRequest(requestUrl, Method.GET);

                foreach(RestParameters param in parameters)
                {
                    request.AddParameter(param.ParameterName, param.ParameterValue);
                }

                request.AddHeader("Accept-Tenant", "uk");
                request.AddHeader("Accept-Language", "en-GB");
                request.AddHeader("Authorization", "Basic VGVjaFRlc3RBUEk6dXNlcjI=");
                request.AddHeader("Host", "api-interview.just-eat.com");

                RestResponse response = _client.Execute(request) as RestResponse;

                var content = response.Content;

                return content;
            }
            catch (Exception ex)
            {                
                throw new Exception(ex.Message);
            }

        }
    }
}
