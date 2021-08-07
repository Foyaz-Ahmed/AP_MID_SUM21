using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MapperConfig
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig() {

            CreateMap<Category, CategoryModel>();
            CreateMap<CategoryModel, Category>().ForMember(e => e.Products, d => d.Ignore()) ;
            CreateMap<Category, CategoryDetails>();
            CreateMap<Product, ProductModel>();
            CreateMap<ProductModel, Product>();
            CreateMap<ProductModelAdd, Product>().ForMember(e => e.Category, sm => sm.Ignore());
           
        }
    }
}
