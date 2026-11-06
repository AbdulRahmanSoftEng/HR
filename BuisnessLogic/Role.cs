using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using DataAccess.Data;
using DataAccess.DTOs;

namespace BuisnessLogic
{
    public class Role
    {
        public enum enMode { AddNew = 0, Update = 1 }

        public enMode Mode = enMode.AddNew;

        public RoleDTO RDTO
        {
            get
            {
                return new RoleDTO(
                    RoleID,
                    RoleName,
                    Description,
                    CreatedAt
                );
            }
        }

        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }

        public Role(RoleDTO RDTO, enMode cMode = enMode.AddNew)
        {
            RoleID = RDTO.RoleID;
            RoleName = RDTO.RoleName;
            Description = RDTO.Description;
            CreatedAt = RDTO.CreatedAt;

            Mode = cMode;
        }

        private bool _AddNewRole()
        {
            RoleID = RoleData.AddRole(RDTO);
            return RoleID > 0;
        }

        private bool _UpdateRole()
        {
            return RoleData.UpdateRole(RDTO);
        }

        public static List<RoleDTO> GetAllRoles()
        {
            return RoleData.GetAllRoles();
        }

        public static Role? Find(int roleID)
        {
            RoleDTO? RDTO = RoleData.GetRoleById(roleID);

            if (RDTO != null)
                return new Role(RDTO, enMode.Update);

            return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRole())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateRole();
            }

            return false;
        }
    }
}
