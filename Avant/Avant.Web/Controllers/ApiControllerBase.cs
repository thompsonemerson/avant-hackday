using Avant.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Avant.Web.Controllers
{
    public class ApiControllerBase : ApiController
    {
        protected IAvantUow Uow { get; set; }
    }
}
