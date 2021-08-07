using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderRepo
    {
        static IMSEntities1 context;

        static OrderRepo()
        {

            context = new IMSEntities1();
        }
        public static List<OrderDetail> GetOrderAll() {

            return context.OrderDetails.ToList();
        
        }

        public static OrderDetail get(int id)
        {

            var pt = context.OrderDetails.FirstOrDefault(e => e.orderid == id);
            return pt;
        }
        public static void AddOrderDetails( OrderDetail or) {

            context.OrderDetails.Add(or);
            context.SaveChanges();
        
        }
    }
}
