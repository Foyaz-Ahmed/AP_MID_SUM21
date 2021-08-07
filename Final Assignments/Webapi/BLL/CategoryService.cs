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
    public class CategoryService
    {
        /*static CategoryService() {

            AutoMapper.Mapper.Initialize(config => config.AddProfile<AutoMapperConfig>());
        
        }*/
        public static List<string> GetCategoryNames() {
        
            return CategoryRepo.GetCategoryNames();
        }

        public static List<CategoryModel> GetAllCategories() {

            var categories = CategoryRepo.GetAllCategories();

            //By AutoMapper

            var data = AutoMapper.Mapper.Map<List<Category>, List<CategoryModel>>(categories);

           //Manual Process

         /*   List<CategoryModel> data = new List<CategoryModel>();
            foreach (var value in categories) {

                var ct = new CategoryModel()
                {

                    id = value.id,
                    name = value.name

                };

                data.Add(ct);
            
            }*/
          
            return data;
        
        }

        public static void AddCategory(CategoryModel ct) {

             //var ctg = new Category() { id = ct.id, name = ct.name };
            var ctg = AutoMapper.Mapper.Map<CategoryModel, Category>(ct); 
            CategoryRepo.AddCategory(ctg);
        
        }
        public static List<CategoryDetails> GetCategoryWithDetails() {

            var data = CategoryRepo.GetAllCategories();
            var cdetails = AutoMapper.Mapper.Map<List<Category>, List<CategoryDetails>>(data);
            return cdetails;
            
        }
        public  static CategoryDetails GetCategoryWithDetails(int id)
        {

            var ctg = CategoryRepo.GetCategoryWithDetails(id);
            var ctg_details = AutoMapper.Mapper.Map<Category, CategoryDetails>(ctg);
            return ctg_details;
        }

    }

}
