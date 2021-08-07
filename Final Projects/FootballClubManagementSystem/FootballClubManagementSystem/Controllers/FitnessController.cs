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
    public class FitnessController : ApiController
    {
        [Route("api/Fitness/Add")]
        [HttpPost]
        public void AddFitness(AddFitnessModel model)
        {

            FitnessService.AddFitness(model);
        }
    }
}
