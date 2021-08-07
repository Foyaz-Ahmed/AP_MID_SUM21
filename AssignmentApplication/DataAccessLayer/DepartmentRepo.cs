using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    

    public class DepartmentRepo
    {
        static SMSEntities context;
        static DepartmentRepo() {

            context = new SMSEntities();
    }
        public static List<string> GetDepartmentsName() {

            var name = context.Departments.Select(n => n.Name).ToList();
            return name;
        }

        public static List<Department> GetDepartments() {

            return context.Departments.ToList();
        }
        public static void AddDepartment(Department d) {

            context.Departments.Add(d);
            context.SaveChanges();
         

        }

}
}
