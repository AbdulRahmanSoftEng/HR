using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class RolePermissionDTO
    {


        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public int PermissionID { get; set; }
        public string PermissionName { get; set; }
        public string? Description { get; set; }
        public DateTime AssignedAt { get; set; }
    }
}