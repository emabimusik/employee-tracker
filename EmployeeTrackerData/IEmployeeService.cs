using EmployeeTrackerData.Models;
using System.Collections.Generic;


namespace EmployeeTrackerData
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployee();
        Employee GetById(int id);
         string GetOffice( int id);
         string  GetPosition(int id);
         int TotalPositions();
         int TotalOffices();
         int TotalEmployees();
         IEnumerable<ChartData> EmployeesPerYear();
         IEnumerable<ChartData> EmployeesPerOffice();

    }

}
