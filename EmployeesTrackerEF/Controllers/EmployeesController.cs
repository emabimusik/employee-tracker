using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeesTrackerEF.Models.Employee;
using EmployeeTrackerData;
using EmployeeTrackerData.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesTrackerEF.Controllers
{
    [Produces("application/json")]
    [Route("api/Employees")]
   
    public class EmployeesController : Controller
    {
        private IEmployeeService _employees;
       

        public EmployeesController(IEmployeeService employee)
        {
            _employees = employee;
        }
        // GET: api/Employees
        [HttpGet]
        public ActionResult Get()
        {
            var employeModel = _employees.GetAllEmployee();



            var listResult = employeModel.Select(result => new EmployeeAssetModel
            {
                Id = result.EmployeeId,
                FirstName = result.FirstName,
                LastName = result.LastName,
                Position = _employees.GetPosition(result.PositionId),
                Office = _employees.GetOffice(result.OfficeId),
                Sex = result.Sex,
                Age = result.Age,
                Salary = result.Salary,
                StartDate = result.StartDate,
                 UpdatedUtc = result.UpdatedUtc,

            });

            var model = new EmployeeIndexModel
            {
                Employees = listResult

            };

            return Ok(model);

        }

        // GET: api/Employees/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Employees
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Employees/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
