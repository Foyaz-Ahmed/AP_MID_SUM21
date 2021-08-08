using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CoachService
    {
        public static void AddCoach(AddCoachModel model)
        {
            var data = AutoMapper.Mapper.Map<AddCoachModel, Coach>(model);
            CoachRepo.AddCoach(data);

        }

        public static List<CoachModel> GetCoach()
        {
            var info = CoachRepo.GetCoach();
            var data = AutoMapper.Mapper.Map<List<Coach>, List<CoachModel>>(info);
            return data;
        }

        public static void CoachEdit(CoachModel obj)
        {
            var data = AutoMapper.Mapper.Map<CoachModel, Coach>(obj);
            CoachRepo.CoachEdit(data);
        }

        public static void CoachDelete(int id)
        {
            CoachRepo.CoachDelete(id);
        }

        public static List<CoachInfoModel> GetCoachDetails()
        {
            var info = CoachRepo.GetCoach();
            var data = AutoMapper.Mapper.Map<List<Coach>, List<CoachInfoModel>>(info);
            return data;
        }
    }
}
