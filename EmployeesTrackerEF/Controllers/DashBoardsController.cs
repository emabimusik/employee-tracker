using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeTrackerData;
using EmployeeTrackerData.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesTrackerEF.Controllers
{
    [Produces("application/json")]
    [Route("api/DashBoards")]
    public class DashBoardsController : Controller
    {

        private IEmployeeService _employees;


        public DashBoardsController(IEmployeeService employee)
        {
            _employees = employee;
        }



        // GET: api/Dashboards
        [HttpGet]
        public ActionResult Get() {

            var employeModel = _employees.GetAllEmployee();


            var dashResult = new DashBoard
            {
                TotalOffices = _employees.TotalOffices(),
                TotalPositions = _employees.TotalPositions(),
                TotalEmployees = _employees.TotalEmployees(),
                EmployeesPerOffice = _employees.EmployeesPerOffice(),
                EmployeesPerYear = _employees.EmployeesPerYear()

            };

            return Ok(dashResult);


        }


    }
}