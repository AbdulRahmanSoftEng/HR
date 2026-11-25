using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessLogic.Utilities;
using DataAccess.Data;
using DataAccess.DTOs.User;

namespace BuisnessLogic
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 }

        public enMode Mode = enMode.AddNew;

        // يستخدم داخلياً عند الإضافة أو تغيير كلمة المرور.
        private string? _PasswordHash;

        public UserLoginInfoDTO LDTO
        {
            get
            {
                return new UserLoginInfoDTO
                { 
                    UserID = this.UserID,
                    FullName = this.FullName,
                    RoleName = this.RoleName
                };
            }
        }

        public FullUserDTO FUDTO
        {
            get
            {
                return new FullUserDTO
                { 
                    UserID = this.UserID,
                    EmployeeID = this.EmployeeID,
                    EmployeeCode = this.EmployeeCode,
                    FullName = this.FullName,
                    Username = this.Username,
                    RoleID = this.RoleID,
                    RoleName = this.RoleName,
                    IsActive = this.IsActive,
                    EmployeeIsActive = this.EmployeeIsActive,
                    CreatedAt = this.CreatedAt
                };
            }
        }

       

        public UserDTO UDTO
        {
            get
            {
                return new UserDTO
                {
                    UserID = this.UserID,
                    EmployeeID = this.EmployeeID,
                    Username = this.Username,
                    Password = this.Password,
                    RoleID = this.RoleID,
                    IsActive = this.IsActive,
                    CreatedAt = this.CreatedAt
                };
            }
        }

        public UserWithRoleDTO URDTO
        {
            get
            {
                return new UserWithRoleDTO
                {
                    UserID = this.UserID,
                    Username = this.Username,
                    RoleID = this.RoleID,
                    RoleName = this.RoleName,
                    UserIsActive = this.IsActive,
                    CreatedAt = this.CreatedAt
                };
            }
        }

        public int UserID { get; set; }
        public int EmployeeID { get; set; }
        public string? EmployeeCode { get; set; }
        public string? FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
        public string? RoleName { get; set; }
        public bool IsActive { get; set; }
        public bool EmployeeIsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        public clsUser(
            FullUserDTO FUDTO,
            enMode cMode = enMode.AddNew,
            string? passwordHash = null)
        {
            UserID = FUDTO.UserID;
            EmployeeID = FUDTO.EmployeeID;
            EmployeeCode = FUDTO.EmployeeCode;
            FullName = FUDTO.FullName;
            Username = FUDTO.Username;
            RoleID = FUDTO.RoleID;
            RoleName = FUDTO.RoleName;
            IsActive = FUDTO.IsActive;
            CreatedAt = FUDTO.CreatedAt;

            _PasswordHash = passwordHash;
            Mode = cMode;
        }

        public clsUser(
            UserWithRoleDTO URUDTO,
            enMode cMode = enMode.AddNew,
            string? passwordHash = null)
        {
            UserID = URUDTO.UserID;
            Username = URUDTO.Username;
            RoleID = URUDTO.RoleID;
            RoleName = URUDTO.RoleName;
            IsActive = URUDTO.UserIsActive;
            CreatedAt = URUDTO.CreatedAt;

            _PasswordHash = passwordHash;
            Mode = cMode;
        }

        public clsUser(
            LoginDTO LDTO,
            enMode cMode = enMode.AddNew)
        {
            UserID = LDTO.UserID;
            EmployeeID = LDTO.EmployeeID;
            EmployeeCode = LDTO.EmployeeCode;
            FullName = LDTO.FullName;
            Username = LDTO.Username;
            RoleID = LDTO.RoleID;
            RoleName = LDTO.RoleName;
            EmployeeIsActive = LDTO.EmployeeIsActive;
            IsActive = LDTO.IsActive;
            CreatedAt = LDTO.CreatedAt;

            _PasswordHash = LDTO.PasswordHash;
            Mode = cMode;
        }

        public clsUser(
            UserDTO UDTO,
            enMode cMode = enMode.AddNew,
            string? passwordHash = null)
        {
            UserID = UDTO.UserID;
            EmployeeID = UDTO.EmployeeID;
            Username = UDTO.Username;
            Password = UDTO.Password;
            RoleID = UDTO.RoleID;
            IsActive = UDTO.IsActive;
            CreatedAt = UDTO.CreatedAt;

            _PasswordHash = passwordHash;
            Mode = cMode;
        }

        private bool _AddNewUser()
        {
            UserID = UserData.AddUser(
                UDTO
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

        public static List<FullUserDTO> GetAllUsers()
        {
            return UserData.GetAllUsers();
        }

        public static clsUser? FindById(int userID)
        {
            FullUserDTO? FUDTO = UserData.GetFullUserById(userID);

            if (FUDTO != null)
                return new clsUser(FUDTO, enMode.Update);

            return null;
        }

        public static clsUser? FindByEmpID(int empId)
        {
            UserWithRoleDTO? UWUDTO = UserData.GetFullUserByEmpID(empId);

            if (UWUDTO != null)
                return new clsUser(UWUDTO, enMode.Update);

            return null;
        }

        // مخصص لجلب بيانات المستخدم عند تسجيل الدخول.
        public static clsUser? LoginUser(string username)
        {
            LoginDTO? LDTO = UserData.LoginUser(username);

            if (LDTO != null)
                return new clsUser(LDTO, enMode.Update);

            return null;
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

        public static bool SetUserActiveStatus(int userID, bool isActive)
        {
            return UserData.SetUserActiveStatus(userID, isActive);
        }

        public bool VerifyPassword(string passwordInput)
        {
            return PasswordHasher.VerifyPassword(password: passwordInput, hashedPassword: this._PasswordHash);
        }

        public static string HashPassword(string PasswordInput)
        {
            return PasswordHasher.HashPassword(password: PasswordInput);
        }
    }
}
