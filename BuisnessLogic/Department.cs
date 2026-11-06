using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Data;
using DataAccess.DTOs;

namespace BuisnessLogic
{
    public class Department
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1
        }

        public enMode Mode = enMode.AddNew;


        // =========================================
        // DTO Object
        // =========================================

        public DepartmentDTO DDTO
        {
            get
            {
                return new DepartmentDTO(
                    this.DepartmentID,
                    this.DepartmentName,
                    this.Description,
                    this.IsActive,
                    this.CreatedAt
                );
            }
        }


        // =========================================
        // Properties
        // =========================================

        public int DepartmentID { get; set; }

        public string DepartmentName { get; set; }

        public string? Description { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }


        // =========================================
        // Constructor
        // =========================================

        public Department(
            DepartmentDTO DDTO,
            enMode cMode = enMode.AddNew)
        {
            this.DepartmentID = DDTO.DepartmentID;
            this.DepartmentName = DDTO.DepartmentName;
            this.Description = DDTO.Description;
            this.IsActive = DDTO.IsActive;
            this.CreatedAt = DDTO.CreatedAt;

            Mode = cMode;
        }


        // =========================================
        // Add New Department
        // =========================================

        private bool _AddNewDepartment()
        {
            this.DepartmentID = DepartmentData.AddDepartment(DDTO);

            return this.DepartmentID > 0;
        }


        // =========================================
        // Update Department
        // =========================================

        private bool _UpdateDepartment()
        {
            return DepartmentData.UpdateDepartment(DDTO);
        }


        // =========================================
        // Get All Departments
        // =========================================

        public static List<DepartmentDTO> GetAllDepartments()
        {
            return DepartmentData.GetAllDepartments();
        }


        // =========================================
        // Find Department By ID
        // =========================================

        public static Department? Find(int departmentID)
        {
            DepartmentDTO? DDTO =
                DepartmentData.GetDepartmentById(departmentID);

            if (DDTO != null)
            {
                return new Department(DDTO, enMode.Update);
            }

            return null;
        }


        // =========================================
        // Save Department
        // =========================================

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewDepartment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;


                case enMode.Update:

                    return _UpdateDepartment();
            }

            return false;
        }


        // =========================================
        // Deactivate Department
        // =========================================

        public static bool DeactivateDepartment(int departmentID)
        {
            return DepartmentData.DeactivateDepartment(departmentID);
        }
    }
}
