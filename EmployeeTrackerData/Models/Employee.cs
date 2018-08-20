using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace EmployeeTrackerData.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PositionId { get; set; }
        public int OfficeId { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
       
        //System.DateTime moment = new DateTime();
        public DateTime StartDate { get; set; }

        public decimal Salary { get; set; }
        public DateTime UpdatedUtc { get; set; }

        public virtual Office Office { get; set; }
        public virtual Position Position { get; set; }
    }
}
