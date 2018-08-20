using System;
using System.Collections.Generic;

namespace EmployeeTrackerData.Models
{
    public partial class Office
    {
        public Office()
        {
            Employee = new HashSet<Employee>();
        }

        public int OfficeId { get; set; }
        public string OfficeName { get; set; }
        public DateTime UpdatedUtc { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
