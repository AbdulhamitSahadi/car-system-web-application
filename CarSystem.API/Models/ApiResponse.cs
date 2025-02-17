﻿using System.Net;

namespace CarSystem.API.Models
{
    public class ApiResponse
    {

        public ApiResponse()
        {
            ErrorMessages = new List<string>();
        }

        public HttpStatusCode StatusCode { get; set; }
        public List<string> ErrorMessages { get; set; }
        public bool IsSuccess { get; set; }
        public object Result { get; set; }
    }
}
