using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebAPIDemo.Controllers
{
    [Authorize]
    [EnableCors("*","*","*")]
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (EmployeeBDEntities entities = new EmployeeBDEntities())
            {
                return entities.Employees.ToList();
            }
        }
        public Employee Get(int id)
        {
            using (EmployeeBDEntities entities = new EmployeeBDEntities())
            {
                return entities.Employees.FirstOrDefault(e => e.ID == id);
            }
        }
    }
}
