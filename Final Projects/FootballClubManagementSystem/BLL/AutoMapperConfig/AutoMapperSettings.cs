using BEL;
using DAL;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.AutoMapperConfig
{
    public class AutoMapperSettings:Profile
    {
        public AutoMapperSettings()
        {
            CreateMap<Player, PlayerModel>();
            CreateMap<PlayerModel, Player>();
            CreateMap<AddPlayerModel, Player>();
            CreateMap<PlayerModel, Fitness>();
            CreateMap<PlayerModel, Salary>();
            CreateMap<PlayerModel, Performance>();
            CreateMap<AddSalaryModel, Salary>();
            CreateMap<AddPerformanceModel, Performance>();
            CreateMap<AddFitnessModel, Fitness>();
            CreateMap<EditPlayerModel, Player>();
        }
    }
}
