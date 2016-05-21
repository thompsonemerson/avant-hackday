using Avant.Model;
using Avant.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Avant.Web.Controllers
{
    public class ProductController : ApiControllerBase
    {
        public ProductController(IAvantUow uow)
        {
            Uow = uow;
        }
        
        public IHttpActionResult GetProducts()
        {
            try
            {
                var products = Uow.Products.GetAll();
                return Ok(products);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

       
    }
}
