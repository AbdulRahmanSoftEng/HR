using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class AttendanceDTO
    {

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