using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.Data;
using DataAccess.DTOs;

namespace BuisnessLogic
{
    public class Employee
    {
        public enum enMode { AddNew = 0, Update = 1 }

        public enMode Mode = enMode.AddNew;

        public EmployeeDTO EDTO
        {
            get
            {
                return new EmployeeDTO(
                    EmployeeID,
                    EmployeeCode,
                    FullName,
                    Phone,
                    DepartmentID,
                    DepartmentName,
                    JobTitle,
                    IsActive,
                    CreatedAt
                );
            }
        }

        public int EmployeeID { get; set; }
        public string EmployeeCode { get; set; }
        public string FullName { get; set; }
        public string? Phone { get; set; }
        public int DepartmentID { get; set; }
        public string? DepartmentName { get; set; }
        public string? JobTitle { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        public Employee(EmployeeDTO EDTO, enMode cMode = enMode.AddNew)
        {
            EmployeeID = EDTO.EmployeeID;
            EmployeeCode = EDTO.EmployeeCode;
            FullName = EDTO.FullName;
            Phone = EDTO.Phone;
            DepartmentID = EDTO.DepartmentID;
            DepartmentName = EDTO.DepartmentName;
            JobTitle = EDTO.JobTitle;
            IsActive = EDTO.IsActive;
            CreatedAt = EDTO.CreatedAt;

            Mode = cMode;
        }

        private bool _AddNewEmployee()
        {
            EmployeeID = EmployeeData.AddEmployee(EDTO);
            return EmployeeID > 0;
        }

        private bool _UpdateEmployee()
        {
            return EmployeeData.UpdateEmployee(EDTO);
        }

        public static List<EmployeeDTO> GetAllEmployees()
        {
            return EmployeeData.GetAllEmployees();
        }

        public static Employee? Find(int employeeID)
        {
            EmployeeDTO? EDTO = EmployeeData.GetEmployeeById(employeeID);

            if (EDTO != null)
                return new Employee(EDTO, enMode.Update);

            return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewEmployee())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateEmployee();
            }

            return false;
        }

        public static bool SetEmployeeActiveStatus(int employeeID, bool isActive)
        {
            return EmployeeData.SetEmployeeActiveStatus(employeeID, isActive);
        }
    }
}
