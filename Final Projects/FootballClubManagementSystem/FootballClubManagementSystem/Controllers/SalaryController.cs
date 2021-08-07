﻿using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FootballClubManagementSystem.Controllers
{
    public class SalaryController : ApiController
    {
        [Route("api/Salary/Add")]
        [HttpPost]
        public void AddSalary(AddSalaryModel model)
        {
            SalaryService.AddSalary(model);
        }
        [Route("api/Salary/Details")]
        [HttpGet]
        public List<SalaryDetails> GetSalaryDetails() {

            return SalaryService.GetSalaryDetails();
        
        }
    }
}