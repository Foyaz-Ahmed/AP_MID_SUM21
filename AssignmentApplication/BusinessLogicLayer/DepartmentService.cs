using BusinessEnitityLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class DepartmnentService
    {
        public static List<string> GetDepartmentNames()
        {

            return DepartmentRepo.GetDepartmentsName();
        }

        public static List<DepartmentModel> GetDepartments() {

            var departments = DepartmentRepo.GetDepartments();
            List<DepartmentModel> data = new List<DepartmentModel>();

            foreach (var d in departments)
            {
                var dm = new DepartmentModel()
                {
                    Id = d.Id,
                    Name = d.Name
                };
                data.Add(dm);
            }
            return data;
        }
        public static void AddDepartment(DepartmentModel dept){

            var data = new Department() {
                Id = dept.Id,
                Name = dept.Name
            };
            DepartmentRepo.AddDepartment(data);

        }
    }
}
