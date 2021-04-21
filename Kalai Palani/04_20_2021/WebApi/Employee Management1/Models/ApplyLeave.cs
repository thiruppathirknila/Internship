using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management1.Models
{
    public class ApplyLeave
    {
        public string EmployeeName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime EndDate { get; set; }
        public string LeaveType { get; set; }
        public string Comments { get; set; }
    }
}
