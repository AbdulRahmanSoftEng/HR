using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class RoleDTO
    {
        public RoleDTO(
            int roleID,
            string roleName,
            string? description,
            DateTime createdAt)
        {
            RoleID = roleID;
            RoleName = roleName;
            Description = description;
            CreatedAt = createdAt;
        }

        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}