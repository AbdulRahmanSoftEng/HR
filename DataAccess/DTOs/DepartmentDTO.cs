using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class DepartmentDTO
    {
        public DepartmentDTO(
            int departmentID,
            string departmentName,
            string description,
            bool isActive,
            DateTime createdAt)
        {
            DepartmentID = departmentID;
            DepartmentName = departmentName;
            Description = description;
            IsActive = isActive;
            CreatedAt = createdAt;
        }

        public int DepartmentID { get; set; }

        public string DepartmentName { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
