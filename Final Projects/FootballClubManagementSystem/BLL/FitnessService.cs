using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FitnessService
    {
        public static void AddFitness(AddFitnessModel model)
        {

            var data = AutoMapper.Mapper.Map<AddFitnessModel, Fitness>(model);
            FitnessRepo.AddFitness(data);

        }
    }
}
