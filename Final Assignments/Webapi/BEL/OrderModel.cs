using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
   public class OrderModel
    {
        public int orderid { get; set; }
        public System.DateTime order_date { get; set; }
        public System.TimeSpan order_time { get; set; }
        public decimal amount { get; set; }
        public string status { get; set; }
    }
}
