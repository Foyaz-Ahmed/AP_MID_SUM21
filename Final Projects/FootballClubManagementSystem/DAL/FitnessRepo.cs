using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FitnessRepo
    {
        static FCMSEntities context;
        static FitnessRepo()
        {
            context = new FCMSEntities();
        }
        public static void AddFitness(Fitness model) {

            context.Fitnesses.Add(model);
            context.SaveChanges();
        
        }

    }
}
