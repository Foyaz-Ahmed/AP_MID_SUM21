using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderService
    {
        public static List<OrderModel> GetOrderAll()
        {

            var data = OrderRepo.GetOrderAll();
            var order = AutoMapper.Mapper.Map<List<OrderDetail>, List<OrderModel>>(data);
            return order;
        }

        public static OrderModel getOrder(int id) {

            var or = OrderRepo.get(id);
            var value = AutoMapper.Mapper.Map<OrderDetail , OrderModel >(or);
            return value;
        
        }
        public static void AddOrderDetails(OrderModel or)
        {

            var p = AutoMapper.Mapper.Map<OrderModel, OrderDetail>(or);
            OrderRepo.AddOrderDetails(p);
        }
    }
}
