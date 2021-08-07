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
    public class CategoryController : ApiController
    {
        [Route("api/Category/Names")]
        [HttpGet]
        public List<string> GetNames() {
        
            return CategoryService.GetCategoryNames();
        }
        [Route("api/Category/GetAll")]
        [HttpGet]
        public List<CategoryModel> GetAllCategories() {

            return CategoryService.GetAllCategories();
        }
        [Route("api/Category/Add")]
        [HttpPost]
        public void AddCategory(CategoryModel ct) {

            CategoryService.AddCategory(ct);
        }
        [Route("api/Category/GetAll/Details")]
        [HttpGet]
        public List <CategoryDetails> GetCategoryWithDetails() {

             return CategoryService.GetCategoryWithDetails();
        
        }
        [Route("api/Category/{id}/Details")]
        [HttpGet]
        public CategoryDetails GetCategoryDetails(int id){

            return CategoryService.GetCategoryWithDetails(id);

        } 
    }
}
