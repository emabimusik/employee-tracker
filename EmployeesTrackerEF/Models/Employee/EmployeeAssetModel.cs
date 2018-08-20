using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesTrackerEF.Models.Employee
{
    public class EmployeeAssetModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public DateTime UpdatedUtc { get; set; }

        // System.DateTime moment = new DateTime();
        public DateTime StartDate { get; set; }
        public decimal Salary { get; set; }
    }
}

