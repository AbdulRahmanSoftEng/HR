using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class PermissionDTO
    {
        public PermissionDTO(
            int permissionID,
            string permissionName,
            string? description)
        {
            PermissionID = permissionID;
            PermissionName = permissionName;
            Description = description;
        }

        public int PermissionID { get; set; }
        public string PermissionName { get; set; }
        public string? Description { get; set; }
    }
}
