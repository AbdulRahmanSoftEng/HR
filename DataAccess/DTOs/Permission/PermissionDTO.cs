using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs.Permission
{
    public class PermissionDTO
    {
        
        public int PermissionID { get; set; }
        public string PermissionName { get; set; }
        public string? Description { get; set; }
    }
}
