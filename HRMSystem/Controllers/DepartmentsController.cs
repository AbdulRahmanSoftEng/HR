using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BuisnessLogic;
using DataAccess.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;
namespace HRMSystem.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/Departements")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        [HttpGet("All", Name = "GetAllDepartment")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<DepartmentDTO>> GetAllDepartment()
        {
            try
            {
                List<DepartmentDTO> departments = Department.GetAllDepartments();
                return Ok(departments);
            }catch(Exception ex)
            {
                return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "An unexpected error occurred."
                    );
            }
        }


        [HttpPost("AddNew", Name = "AddNewDepartment")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<DepartmentDTO> AddNewDepartment(DepartmentDTO newDepartment)
        {
            if (newDepartment == null ||
                string.IsNullOrWhiteSpace(newDepartment.DepartmentName))
            {
                return BadRequest("ERROR: nvalid data of department");
            }

            try
            {
                
                Department departmentInserted = new Department(newDepartment);
                if (!departmentInserted.Save())
                {
                    return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "Failed to add department");
                }

                newDepartment.DepartmentID = departmentInserted.DepartmentID;

                return CreatedAtRoute(
                       "FindDepartmentById",
                       new { id = newDepartment.DepartmentID },
                       newDepartment
                   );

            }
            catch(Exception ex)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError, 
                    "An unexpected error occurred."
                    );
            }
        }


        [HttpPut("Update", Name = "UpdateDepartment")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<DepartmentDTO> UpdateDepartment(int departmentId, DepartmentDTO updateDepartment)
        {
            if (departmentId <= 0 ||
                updateDepartment == null ||
                string.IsNullOrWhiteSpace(updateDepartment.DepartmentName))
            {
                return BadRequest("ERROR: nvalid data of department");
            }

            try
            {

                Department? department = Department.Find(departmentId);

                if (department == null)
                    return NotFound("ERROR: Department dose not exists!!.");

                department.DepartmentName = updateDepartment.DepartmentName;
                department.Description = updateDepartment.Description;


                if (!department.Save())
                    return StatusCode(
                            StatusCodes.Status500InternalServerError,
                            "Failed to update department."
                        );

                return Ok(department.DDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "An unexpected error occurred."
                    );
            }
        }

        [HttpGet("ById/{id}", Name = "FindDepartmentById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<DepartmentDTO> FindById(int id)
        {
            if (id <= 0)
                return BadRequest($"The value {id} is not valid");

            try
            {
               
                Department?  department = Department.Find(id);

                if (department == null)
                    return NotFound($"Department with ID {id} was not found");

                return Ok(department.DDTO);

            } catch (Exception ex) {

                // Log exception error
                return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "An unexpected error occurred."
                    );
            }
        }

        [HttpPut("DeActivate", Name = "DeActivateDepartment")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<string> DeActivateDepartment(int id)
        {
            if (id <= 0)
                return BadRequest($"The ID {id} is not valid");

            try
            {
                Department? department = Department.Find(id);

                if (department == null)
                    return NotFound($"Department with ID {id} was not found.");

                if (!department.IsActive)
                    return Ok($"department Is already deActivated");

                bool isSuccess = Department.DeactivateDepartment(id);

                if (!isSuccess)
                    return StatusCode(
                            StatusCodes.Status500InternalServerError,
                            "Failed to deactivate department");
                else
                    return BadRequest($"Department deactviated successfully.");
            }catch(Exception ex)
            {
                return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "An unexpected error occoured."
                    );
            }
        }
    }
}
