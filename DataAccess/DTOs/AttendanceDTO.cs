using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class AttendanceDTO
    {
        public AttendanceDTO(
            int attendanceID,
            int employeeID,
            string fullName,
            DateTime attendanceDate,
            TimeSpan checkIn,
            TimeSpan? checkOut,
            string? notes)
        {
            AttendanceID = attendanceID;
            EmployeeID = employeeID;
            FullName = fullName;
            AttendanceDate = attendanceDate;
            CheckIn = checkIn;
            CheckOut = checkOut;
            Notes = notes;
        }

        public int AttendanceID { get; set; }

        public int EmployeeID { get; set; }

        // اسم الموظف لعرضه في شاشة الحضور
        public string FullName { get; set; }

        public DateTime AttendanceDate { get; set; }

        public TimeSpan CheckIn { get; set; }

        // قد لا يكون الموظف سجل الانصراف بعد
        public TimeSpan? CheckOut { get; set; }

        public string? Notes { get; set; }
    }
}