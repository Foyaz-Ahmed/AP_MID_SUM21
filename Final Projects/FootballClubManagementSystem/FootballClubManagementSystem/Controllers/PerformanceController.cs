using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FootballClubManagementSystem.Controllers
{
    public class PerformanceController : ApiController
    {
        [Route("api/Performance/Add")]
        [HttpPost]
        public void AddPerformance(AddPerformanceModel model) {

            PerformanceService.AddPerformance(model);
        }
    }
}
