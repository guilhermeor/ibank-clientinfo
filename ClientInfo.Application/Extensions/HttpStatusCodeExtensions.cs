﻿using System.Net;

namespace ClientInfo.Application.Extensions
{
    public static class HttpStatusCodeExtensions
    {
        public static bool IsSuccess(this HttpStatusCode statusCode) => ((int)statusCode >= 200 && (int)statusCode <= 299);
    }
}