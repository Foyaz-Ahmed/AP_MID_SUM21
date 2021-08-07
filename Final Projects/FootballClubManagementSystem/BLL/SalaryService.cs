﻿using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SalaryService
    {
        public static void AddSalary(AddSalaryModel model)
        {
            var data = AutoMapper.Mapper.Map<AddSalaryModel, Salary>(model);
            SalaryRepo.AddSalary(data);
        }

        public static List<SalaryDetails> GetSalaryDetails()
        {
            var data = SalaryRepo.GetSalaryDetails();
            var info = AutoMapper.Mapper.Map<List<Salary>, List<SalaryDetails>>(data);
            return info;
        }
    }
}
