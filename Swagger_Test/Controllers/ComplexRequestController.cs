﻿using Swagger_Test.Models;
using System.Web.Http;

namespace Swagger_Test.Controllers
{
    public class ComplexRequestController : ApiController
    {
        public EntityRequest Get([FromUri] EntityRequest obj)
        {
            return obj;
        }
    }
}
