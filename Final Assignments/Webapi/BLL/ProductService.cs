using BEL;
using BLL.MapperConfig;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductService
    {
      /*  static ProductService()
        {

            AutoMapper.Mapper.Initialize(config => config.AddProfile<AutoMapperConfig>());
         

        }*/

        public static List<ProductModel> GetAllProducts()
        {
            var all = ProductRepo.GetAllProducts();
            var p = AutoMapper.Mapper.Map<List<Product>, List<ProductModel>>(all);
            return p;
        }
        public static void AddProduct(ProductModelAdd pt)
        {

            var p = AutoMapper.Mapper.Map<ProductModelAdd, Product>(pt);
            ProductRepo.AddProduct(p);
        }
        public static ProductModel GetProduct(int id)
        {
            var data = ProductRepo.GetProduct(id);
            var p = AutoMapper.Mapper.Map<Product, ProductModel>(data);
            return p;
        }
        public static List<string> GetNames()
        {
            return ProductRepo.GetNames();
        }
    }

}