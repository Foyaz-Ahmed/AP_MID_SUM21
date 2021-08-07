using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PerformanceService
    {
        public static void AddPerformance(AddPerformanceModel model) {

            var data = AutoMapper.Mapper.Map<AddPerformanceModel, Performance>(model);
            PerformanceRepo.AddPerformance(data);
        
        }
    }
}
