using Avant.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Avant.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        protected IAvantUow Uow { get; set; }
    }
}
