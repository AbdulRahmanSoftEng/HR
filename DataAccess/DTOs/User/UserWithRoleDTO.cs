using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs.User
{
    public class UserWithRoleDTO
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public bool UserIsActive { get; set; }
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
