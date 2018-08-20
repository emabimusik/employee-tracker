using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesTrackerEF.Models.Employee
{
    public class EmployeeIndexModel
    {
        public IEnumerable<EmployeeAssetModel> Employees { get; set; }
    }
}
