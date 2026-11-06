using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.Data;
using DataAccess.DTOs;

namespace BuisnessLogic
{
    public class User
    {
        public enum enMode { AddNew = 0, Update = 1 }

        public enMode Mode = enMode.AddNew;

        // يستخدم داخلياً عند الإضافة أو تغيير كلمة المرور.
        private string? _PasswordHash;

        public UserDTO UDTO
        {
            get
            {
                return new UserDTO(
                    UserID,
                    EmployeeID,
                    EmployeeCode,
                    FullName,
                    Username,
                    RoleID,
                    RoleName,
                    IsActive,
                    CreatedAt
                );
            }
        }

        public int UserID { get; set; }
        public int EmployeeID { get; set; }
        public string? EmployeeCode { get; set; }
        public string? FullName { get; set; }
        public string Username { get; set; }
        public int RoleID { get; set; }
        public string? RoleName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        public User(
            UserDTO UDTO,
            enMode cMode = enMode.AddNew,
            string? passwordHash = null)
        {
            UserID = UDTO.UserID;
            EmployeeID = UDTO.EmployeeID;
            EmployeeCode = UDTO.EmployeeCode;
            FullName = UDTO.FullName;
            Username = UDTO.Username;
            RoleID = UDTO.RoleID;
            RoleName = UDTO.RoleName;
            IsActive = UDTO.IsActive;
            CreatedAt = UDTO.CreatedAt;

            _PasswordHash = passwordHash;
            Mode = cMode;
        }

        private bool _AddNewUser()
        {
            UserID = UserData.AddUser(
                EmployeeID,
                Username,
                _PasswordHash!,
                RoleID
            );

            return UserID > 0;
        }

        private bool _UpdateUser()
        {
            return UserData.UpdateUser(
                UserID,
                Username,
                _PasswordHash,
                RoleID
            );
        }

        public static List<UserDTO> GetAllUsers()
        {
            return UserData.GetAllUsers();
        }

        public static User? Find(int userID)
        {
            UserDTO? UDTO = UserData.GetUserById(userID);

            if (UDTO != null)
                return new User(UDTO, enMode.Update);

            return null;
        }

        // مخصص لجلب بيانات المستخدم عند تسجيل الدخول.
        public static UserLoginDTO? FindByUsername(string username)
        {
            return UserData.GetUserByUsername(username);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateUser();
            }

            return false;
        }

        public void SetPasswordHash(string passwordHash)
        {
            _PasswordHash = passwordHash;
        }

        public static bool SetUserActiveStatus(int userID, bool isActive)
        {
            return UserData.SetUserActiveStatus(userID, isActive);
        }
    }
}
