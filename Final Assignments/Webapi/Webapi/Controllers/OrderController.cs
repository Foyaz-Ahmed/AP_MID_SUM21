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
    public class OrderController : ApiController
    {
        [Route("api/OrderDetails/All")]
        [HttpGet]
        public List<OrderModel> GetOrderAll() {

            return OrderService.GetOrderAll();
        }

        [Route("api/Order/{id}")]
        public OrderModel get(int id)
        {
            return OrderService.getOrder(id);
        }

        [Route("api/OrderDetails/Add")]
        [HttpPost]
        public void AddOrderDetails(OrderModel or) {

            OrderService.AddOrderDetails(or);
        }
        
    }
}
