using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SalaryRepo
    {
        static FCMSEntities context;
        static SalaryRepo()
        {
            context = new FCMSEntities();
        }
        public static void AddSalary(Salary model)
        {
            context.Salaries.Add(model);
            context.SaveChanges();
        }

        public static List<Salary> GetSalaryDetails()
        {
            var data = context.Salaries.ToList();
            return data;
        }
    }
}
