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

        public static List<PerformanceModel> GetAll()
        {
            var data = PerformanceRepo.GetPerformanceDetails();
            var info = AutoMapper.Mapper.Map<List<Performance>, List<PerformanceModel>>(data);
            return info;
        }

        public static void PerformanceEdit(EditPerformanceModel obj)
        {
            var data = AutoMapper.Mapper.Map<EditPerformanceModel, Performance>(obj);
            PerformanceRepo.PerformanceEdit(data);
        }

        public static PerformanceModel GetPerformance(int id)
        {
            var data = PerformanceRepo.GetPerformance(id);
            var p = AutoMapper.Mapper.Map<Performance, PerformanceModel>(data);
            return p;
        }

        public static void PerformanceDelete(int id)
        {
            PerformanceRepo.PerformanceDelete(id);
        }

        public static List<PerformanceDetailsModel> GetPerformanceDetails()
        {
            var data = PerformanceRepo.GetPerformanceDetails();
            var info = AutoMapper.Mapper.Map<List<Performance>, List<PerformanceDetailsModel>>(data);
            return info;
        }   
    }
}
