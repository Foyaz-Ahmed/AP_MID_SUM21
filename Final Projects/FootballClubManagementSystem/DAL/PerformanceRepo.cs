using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PerformanceRepo
    {
        static FCMSEntities context;
        static PerformanceRepo()
        {
            context = new FCMSEntities();
        }
        public static void AddPerformance(Performance model)
        {

            context.Performances.Add(model);
            context.SaveChanges();

        }
    }
}
