
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BuisnessLogic;
using DataAccess.DTOs;

namespace HRMSystem.Controllers
{
    [Route("api/Employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        // GET: api/Employees/All
        [HttpGet("All", Name = "GetAllEmployees")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<EmployeeDTO>> GetAllEmployees()
        {
            try
            {
                List<EmployeeDTO> employees = Employee.GetAllEmployees();

                return Ok(employees);
            }
            catch (Exception)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    "An unexpected error occurred."
                );
            }
        }

        // POST: api/Employees/AddNew
        [HttpPost("AddNew", Name = "AddNewEmployee")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<EmployeeDTO> AddNewEmployee(EmployeeDTO newEmployee)
        {
            if (newEmployee == null ||
                string.IsNullOrWhiteSpace(newEmployee.EmployeeCode) ||
                string.IsNullOrWhiteSpace(newEmployee.FullName) ||
                newEmployee.DepartmentID <= 0)
            {
                return BadRequest("Invalid employee data.");
            }

            try
            {
                Employee employee = new Employee(newEmployee);

                if (!employee.Save())
                {
                    return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "Failed to add employee."
                    );
                }

                newEmployee.EmployeeID = employee.EmployeeID;

                return CreatedAtRoute(
                    "FindEmployeeById",
                    new { id = newEmployee.EmployeeID },
                    newEmployee
                );
            }
            catch (Exception)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    "An unexpected error occurred."
                );
            }
        }

        // PUT: api/Employees/Update?employeeId=1
        [HttpPut("Update", Name = "UpdateEmployee")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<EmployeeDTO> UpdateEmployee(
            int employeeId,
            EmployeeDTO updateEmployee)
        {
            if (employeeId <= 0 ||
                updateEmployee == null ||
                string.IsNullOrWhiteSpace(updateEmployee.EmployeeCode) ||
                string.IsNullOrWhiteSpace(updateEmployee.FullName) ||
                updateEmployee.DepartmentID <= 0)
            {
                return BadRequest("Invalid employee data.");
            }

            try
            {
                Employee employee = Employee.Find(employeeId);

                if (employee == null)
                {
                    return NotFound(
                        $"Employee with ID {employeeId} was not found."
                    );
                }

                employee.EmployeeCode = updateEmployee.EmployeeCode;
                employee.FullName = updateEmployee.FullName;
                employee.Phone = updateEmployee.Phone;
                employee.DepartmentID = updateEmployee.DepartmentID;
                employee.JobTitle = updateEmployee.JobTitle;

                if (!employee.Save())
                {
                    return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "Failed to update employee."
                    );
                }

                return Ok(employee.EDTO);
            }
            catch (Exception)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    "An unexpected error occurred."
                );
            }
        }

        // GET: api/Employees/ById/1
        [HttpGet("ById/{id}", Name = "FindEmployeeById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<EmployeeDTO> FindById(int id)
        {
            if (id <= 0)
            {
                return BadRequest($"The ID {id} is not valid.");
            }

            try
            {
                Employee employee = Employee.Find(id);

                if (employee == null)
                {
                    return NotFound(
                        $"Employee with ID {id} was not found."
                    );
                }

                return Ok(employee.EDTO);
            }
            catch (Exception)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    "An unexpected error occurred."
                );
            }
        }

        // PUT: api/Employees/1/Status?isActive=false
        [HttpPut("{id:int}/Status", Name = "SetEmployeeActiveStatus")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<string> SetActiveStatus(
            int id,
            bool isActive)
        {
            if (id <= 0)
            {
                return BadRequest($"The ID {id} is not valid.");
            }

            try
            {
                Employee employee = Employee.Find(id);

                if (employee == null)
                {
                    return NotFound(
                        $"Employee with ID {id} was not found."
                    );
                }

                if (employee.IsActive == isActive)
                {
                    return Ok(
                        isActive
                            ? "Employee is already active."
                            : "Employee is already deactivated."
                    );
                }

                bool isSuccess =
                    Employee.SetEmployeeActiveStatus(id, isActive);

                if (!isSuccess)
                {
                    return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "Failed to change employee status."
                    );
                }

                return Ok(
                    isActive
                        ? "Employee activated successfully."
                        : "Employee deactivated successfully."
                );
            }
            catch (Exception)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    "An unexpected error occurred."
                );
            }
        }
    }
}
