using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using DataAccess.Data;
using DataAccess.DTOs;

namespace BuisnessLogic
{
    public class Permission
    {
        public enum enMode { AddNew = 0, Update = 1 }

        public enMode Mode = enMode.AddNew;

        public PermissionDTO PDTO
        {
            get
            {
                return new PermissionDTO(
                    PermissionID,
                    PermissionName,
                    Description
                );
            }
        }

        public int PermissionID { get; set; }
        public string PermissionName { get; set; }
        public string? Description { get; set; }

        public Permission(
            PermissionDTO PDTO,
            enMode cMode = enMode.AddNew)
        {
            PermissionID = PDTO.PermissionID;
            PermissionName = PDTO.PermissionName;
            Description = PDTO.Description;

            Mode = cMode;
        }

        private bool _AddNewPermission()
        {
            PermissionID = PermissionData.AddPermission(PDTO);
            return PermissionID > 0;
        }

        private bool _UpdatePermission()
        {
            return PermissionData.UpdatePermission(PDTO);
        }

        public static List<PermissionDTO> GetAllPermissions()
        {
            return PermissionData.GetAllPermissions();
        }

        public static Permission? Find(int permissionID)
        {
            PermissionDTO? PDTO =
                PermissionData.GetPermissionById(permissionID);

            if (PDTO != null)
                return new Permission(PDTO, enMode.Update);

            return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPermission())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdatePermission();
            }

            return false;
        }
    }
}
