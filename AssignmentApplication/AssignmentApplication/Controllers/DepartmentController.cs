using BusinessEnitityLayer;
using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentApplication.Controllers
{
    public class DepartmentController : ApiController
    {
        [Route("api/Department/Names")]
        [HttpGet]
        public List<string>  GetNames() {

            return DepartmnentService.GetDepartmentNames();
        }

        [Route("api/Department/GetAll")]
        [HttpGet]
        public List<DepartmentModel> GetAllDepartments()
        {

            return DepartmnentService.GetDepartments();
        }

        [Route("api/Department/Add")]
        [HttpPost]
        public void Add(DepartmentModel dept) {

            DepartmnentService.AddDepartment(dept);
        }

    }
}
