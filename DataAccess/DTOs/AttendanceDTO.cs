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
            string employeeName,
            DateTime attendanceDate,
            DateTime checkIn,
            DateTime? checkOut,
            string? notes)
        {
            AttendanceID = attendanceID;
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            AttendanceDate = attendanceDate;
            CheckIn = checkIn;
            CheckOut = checkOut;
            Notes = notes;
        }

        public int AttendanceID { get; set; }

        public int EmployeeID { get; set; }

        // اسم الموظف لعرضه في شاشة الحضور
        public string EmployeeName { get; set; }

        public DateTime AttendanceDate { get; set; }

        public DateTime CheckIn { get; set; }

        // قد لا يكون الموظف سجل الانصراف بعد
        public DateTime? CheckOut { get; set; }

        public string? Notes { get; set; }
    }
}