using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoserverManager.Rest.Client.Request;
using GeoserverManager.Rest.Client.Response;
using RestSharp;
using RestSharp.Authenticators;

namespace GeoserverManager.Rest.Client
{
    public class RestService : IRestService
    {
        private readonly IRestClient client;
        private IAuthenticator Auth;


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

            var restRequest = new RestRequest(request.Uri, Method.GET);
            var response = client.Execute(restRequest);

            if (Auth != null)
                client.Authenticator = Auth;

            return new ServiceResponse() { Data = response.Content, StatusCode = response.StatusCode };
        }

        public IServiceResponse Get(IServiceRequest request)
        {

            var restRequest = new RestRequest(request.Uri, Method.GET);
            var response = client.Execute(restRequest);

            if (Auth != null)
                client.Authenticator = Auth;

            return new ServiceResponse() { Data = response.Content, StatusCode = response.StatusCode };
        }


        public void Post(IServiceRequest request, IRequestSettings restSettings)
        {
            throw new NotImplementedException();
        }

        public void Post(IServiceRequest request)
        {
            throw new NotImplementedException();
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
