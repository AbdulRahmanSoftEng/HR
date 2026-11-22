using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class EmployeeDTO
    {

        public int? EmployeeID { get; set; }
        public string EmployeeCode { get; set; }
        public string FullName { get; set; }
        public string? Phone { get; set; }

        public int DepartmentID { get; set; }

        // اسم القسم يأتي من عملية JOIN عند جلب الموظفين
        public string? DepartmentName { get; set; }

        public string? JobTitle { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}