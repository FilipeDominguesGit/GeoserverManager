using System;
using System.Net;
using System.Runtime.Serialization;

namespace GeoserverManager.Rest.Client.Interface.Response
{
    public interface IServiceResponse
    {
        HttpStatusCode StatusCode { get; set; }

        string Data { get; set; }

        string ErrorMessage { get; set; }

        Exception ErrorException { get; set; }
    }
}