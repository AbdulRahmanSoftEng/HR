using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BuisnessLogic;
using DataAccess.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;
namespace HRMSystem.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/Departement")]
    [ApiController]
    public class DepartementController : ControllerBase
    {
        [HttpGet("All", Name = "GetAllDepartment")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<DepartmentDTO>> GetAllDepartment()
        {
            var departments = Department.GetAllDepartments();
            if(departments == null || departments.Count == 0)
            {
                return NotFound("Dont have any Department is empty");
            }

            return Ok(departments);
        }


        [HttpPost("AddNew", Name = "AddNewDepartment")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<DepartmentDTO> AddNewDepartment(DepartmentDTO newDepartment)
        {
            try
            {
                if (
                newDepartment == null ||
                string.IsNullOrWhiteSpace(newDepartment.DepartmentName))
                {
                    return BadRequest("ERROR: nvalid data of department");
                }

                Department departmentInserted = new Department(newDepartment);
                departmentInserted.Save();

                newDepartment.DepartmentID = departmentInserted.DepartmentID;

            }catch(Exception ex)
            {
                return BadRequest($"ERROR: {ex.Message}");
            }

            return CreatedAtRoute("AddNewDepartment", new { id = newDepartment.DepartmentID }, newDepartment);
        }


        [HttpPut("Update", Name = "UpdateDepartment")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<DepartmentDTO> UpdateDepartment(int departmentId, DepartmentDTO updateDepartment)
        {
            Department department;
            try
            {
                if (
                    departmentId < 0 ||
                    updateDepartment == null ||
                    string.IsNullOrWhiteSpace(updateDepartment.DepartmentName))
                {
                    return BadRequest("ERROR: nvalid data of department");
                }

                department = Department.Find(departmentId);

                if (department == null)
                    return NotFound("ERROR: Department dose not exists!!.");

                if (department.DepartmentName == updateDepartment.DepartmentName)
                    return BadRequest($"Department name {updateDepartment.DepartmentName} already exists, shows anther name.");

                department.DepartmentName = updateDepartment.DepartmentName;
                department.Description = updateDepartment.Description;

                department.Save();

            }
            catch (Exception ex)
            {
                return BadRequest($"ERROR: {ex.Message}");
            }

            return Ok(department.DDTO);
        }
    }
}
