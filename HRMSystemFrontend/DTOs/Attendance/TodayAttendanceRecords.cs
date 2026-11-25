using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystemFrontend.DTOs.Attendance
{
    public class TodayAttendanceRecords
    {
        public int? AttendanceID { get; set; }
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string DepartmentName { get; set; }
        public TimeSpan? CheckIn { get; set; }
        public TimeSpan? CheckOut { get; set; }
        public string Status { get; set; }
    }
}
