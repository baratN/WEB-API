using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataLibrary;

namespace EmployeeService.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEnumerable<Employee> GET()
        {
            using (EmployeeDBEntity entities=new EmployeeDBEntity())
            {
                return entities.
            }
        }
    }
}
