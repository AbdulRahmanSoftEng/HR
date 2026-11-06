using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using DataAccess.Data;
using DataAccess.DTOs;

namespace BuisnessLogic
{
    public class RolePermission
    {
        public RolePermissionDTO RPDTO { get; set; }

        public int RoleID
        {
            get { return RPDTO.RoleID; }
        }

        public string? RoleName
        {
            get { return RPDTO.RoleName; }
        }

        public int PermissionID
        {
            get { return RPDTO.PermissionID; }
        }

        public string? PermissionName
        {
            get { return RPDTO.PermissionName; }
        }

        public string? Description
        {
            get { return RPDTO.Description; }
        }

        public DateTime AssignedAt
        {
            get { return RPDTO.AssignedAt; }
        }

        public RolePermission(RolePermissionDTO RPDTO)
        {
            this.RPDTO = RPDTO;
        }

        public static List<RolePermissionDTO> GetPermissionsByRole(int roleID)
        {
            return RolePermissionData.GetPermissionsByRole(roleID);
        }

        public static bool AssignPermissionToRole(
            int roleID,
            int permissionID)
        {
            return RolePermissionData.AssignPermissionToRole(
                roleID,
                permissionID
            );
        }

        public static bool RemovePermissionFromRole(
            int roleID,
            int permissionID)
        {
            return RolePermissionData.RemovePermissionFromRole(
                roleID,
                permissionID
            );
        }
    }
}
