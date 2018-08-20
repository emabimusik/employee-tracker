using EmployeeTrackerData;
using EmployeeTrackerData.Models;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections;

namespace EmployeeTrackerService
{
    public class EmployeeService : IEmployeeService
    {
        private EmployeeTrackerContext _context;
        public EmployeeService(EmployeeTrackerContext context)
        {
            _context = context;
          
        }

        public int TotalPositions()
        {
            return  _context.Position.Count() ;
        }
        public int TotalOffices()
        {
            return _context.Office.Count();
        }
        public int TotalEmployees()
        {
            return _context.Employee.Count();
        }

        public IEnumerable<Employee> GetAllEmployee()
        {

            return _context.Employee.ToList();
            
        }

        public Employee GetById(int id)
        {
            return GetAllEmployee().FirstOrDefault(emp => emp.EmployeeId == id);
        }

        public string GetOffice(int id)
        {
            return _context.Office.Single(o => o.OfficeId == id).OfficeName;
        }

        public string GetPosition(int id)
        {
            return _context.Position.Single(p => p.PositionId == id).PositionName;
        }

       
        public IEnumerable<ChartData> EmployeesPerYear()
        {

            

             var listOfEmployee = _context.Employee ;

           var chartdata = listOfEmployee.AsEnumerable().GroupBy(a => new { a.StartDate.Year }).Select(result => new ChartData
            {

                Key =  result.Key.Year.ToString(),
                Value = result.Count()

            });
            return chartdata;
        }

        public IEnumerable<ChartData> EmployeesPerOffice()
        {
            
            var listOfEmployee = _context.Employee.Include(a=>a.Office);

            var chartdata = listOfEmployee.AsEnumerable().GroupBy(a => new { a.OfficeId,a.Office }).Select(result => new ChartData
            {

                Key = result.Key.Office.OfficeName.ToString(),
                Value = result.Count()

            });
            return chartdata;
        }
    }
}
