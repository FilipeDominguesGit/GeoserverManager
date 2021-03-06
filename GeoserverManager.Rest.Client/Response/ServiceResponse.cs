﻿using System;
using System.Net;
using GeoserverManager.Rest.Client.Interface.Response;

namespace GeoserverManager.Rest.Client.Response
{
    public class ServiceResponse : IServiceResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Data { get; set; }
        public string ErrorMessage { get; set; }
        public Exception ErrorException { get; set; }
    }
}