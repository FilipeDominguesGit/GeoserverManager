using System;
using GeoserverManager.Rest.Client.Interface;
using GeoserverManager.Rest.Client.Interface.Request;
using GeoserverManager.Rest.Client.Interface.Response;
using GeoserverManager.Rest.Client.Response;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers;

namespace GeoserverManager.Rest.Client
{
    public class RestService : IRestService
    {
        private readonly IAuthenticator Auth;
        private readonly IRestClient client;

        public RestService(string uri, string user = "", string password = "")
        {
            if (string.IsNullOrWhiteSpace(uri))
                throw new ArgumentNullException("uri", "uri cannot be null");

            if (!string.IsNullOrWhiteSpace(user) && string.IsNullOrWhiteSpace(password))
                throw new ArgumentNullException("password", "password cannot be null!");

            if (!string.IsNullOrWhiteSpace(password) && string.IsNullOrWhiteSpace(user))
                throw new ArgumentNullException("user", "user cannot be null!");

            if (!string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(password))
                Auth = new HttpBasicAuthenticator(user, password);

            client = new RestClient(uri);
        }

        public IServiceResponse Get(IServiceRequest request, IRequestSettings restSettings)
        {
            if (Auth != null)
                client.Authenticator = Auth;

            var restRequest = new RestRequest(request.Uri, Method.GET);
            var response = client.Execute(restRequest);


            return new ServiceResponse { Data = response.Content, StatusCode = response.StatusCode };
        }

        public IServiceResponse Get(IServiceRequest request)
        {
            if (Auth != null)
                client.Authenticator = Auth;

            var restRequest = new RestRequest(request.Uri, Method.GET);
            var response = client.Execute(restRequest);


            return new ServiceResponse { Data = response.Content, StatusCode = response.StatusCode };
        }

        public void Post(IServiceRequest request, IRequestSettings restSettings)
        {
            throw new NotImplementedException();
        }

        public IServiceResponse Post(IServiceRequest request)
        {
            if (Auth != null)
                client.Authenticator = Auth;


            var restRequest = new RestRequest(request.Uri, Method.POST);


            if (!string.IsNullOrWhiteSpace(request.Body))
            {
                restRequest.AddParameter("text/json", request.Body, ParameterType.RequestBody);
                restRequest.RequestFormat = DataFormat.Json;
            }

            var response = client.Execute(restRequest);


            return new ServiceResponse { Data = response.Content, StatusCode = response.StatusCode };
        }

        public void Put(IServiceRequest request, IRequestSettings restSettings)
        {
            throw new NotImplementedException();
        }

        public void Put(IServiceRequest request)
        {
            throw new NotImplementedException();
        }
    }
}