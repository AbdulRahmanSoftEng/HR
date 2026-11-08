using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class AttendanceDTO
    {
        public AttendanceDTO() { }

        public AttendanceDTO(
           int attendanceID,
           int employeeID,
           string fullName,
           TimeSpan checkIn,
           TimeSpan? checkOut)
        {
            this.AttendanceID = attendanceID;
            this.EmployeeID = employeeID;
            this.FullName = fullName;
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
        }
        public AttendanceDTO(
            int attendanceID,
            int employeeID,
            string fullName,
            DateTime attendanceDate,
            TimeSpan checkIn,
            TimeSpan? checkOut,
            string? notes)
        {
            this.AttendanceID = attendanceID;
            this.EmployeeID = employeeID;
            this.FullName = fullName;
            this.AttendanceDate = attendanceDate;
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
            this.Notes = notes;
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