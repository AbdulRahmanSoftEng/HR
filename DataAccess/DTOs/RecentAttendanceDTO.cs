using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class RecentAttendanceDTO
    {

        public RecentAttendanceDTO(
        int attendanceID,
        string fullName,
        string departmentName,
        TimeSpan checkIn,
        TimeSpan? checkOut)
        {
            this.AttendanceID = attendanceID;
            this.FullName = fullName;
            this.DepartmentName = departmentName;
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
        }

        public int AttendanceID { get; set; }

        public string FullName { get; set; }

        public DateTime AttendanceDate { get; set; }

        public string DepartmentName { get; set; }

        public TimeSpan CheckIn { get; set; }

        // قد لا يكون الموظف سجل الانصراف بعد
        public TimeSpan? CheckOut { get; set; }
    }
}
