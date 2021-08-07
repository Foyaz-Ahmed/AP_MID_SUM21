using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryRepo
    {
        static IMSEntities1 context;

        static CategoryRepo() {

            context = new IMSEntities1();
        }
        public static List<string> GetCategoryNames() {

            var data = context.Categories.Select(e => e.name).ToList();
            return data;
        }

        public static List<Category> GetAllCategories() {

            return context.Categories.ToList();
        }

        public static void AddCategory(Category c) {

            context.Categories.Add(c);
            context.SaveChanges();
        }

        public static Category GetCategoryWithDetails(int id)
        {
            return context.Categories.FirstOrDefault(e => e.id == id);

        }
    }
}
