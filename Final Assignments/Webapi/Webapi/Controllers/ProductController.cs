using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Webapi.Controllers
{
    public class ProductController : ApiController
    {
        [Route("api/Product/All")]
        [HttpGet]
        public List<ProductModel> GetAllProducts()
        {
            return ProductService.GetAllProducts();
        }

      
        [Route("api/Proudcts/add")]
        [HttpPost]
        public void AddProduct(ProductModelAdd pt)
        {
            ProductService.AddProduct(pt);
        }
        [Route("api/Product/{id}")]
        [HttpGet]
        public ProductModel GetProduct(int id)
        {
            return ProductService.GetProduct(id);
        }
        [Route("api/Product/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return ProductService.GetNames();
        }
    }
}
