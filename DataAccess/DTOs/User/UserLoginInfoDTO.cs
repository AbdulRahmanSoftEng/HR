using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs.User
{
    public class UserLoginInfoDTO
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string RoleName { get; set; }
    }
}
