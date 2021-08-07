using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductRepo
    {
        static IMSEntities1 context;

        static ProductRepo()
        {

            context = new IMSEntities1();
        }
        public static List<Product> GetAllProducts()
        {
            return context.Products.ToList();

        }
        public static void AddProduct(Product pt)
        {
            context.Products.Add(pt);
            context.SaveChanges();
        }
        public static Product GetProduct(int id) {

            var pt = context.Products.FirstOrDefault(e => e.id == id);
            return pt;
        }
        public static List<string> GetNames()
        {
            var names = context.Products.Select(e => e.name).ToList();
            return names;
        }
    }
}
