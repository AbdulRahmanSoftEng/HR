using BuisnessLogic;
using DataAccess.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMSystem.Controllers
{
    [Route("api/RPermission")]
    [ApiController]
    public class RPermissionController : ControllerBase
    {
        [HttpGet("All/{roleID}", Name = "GetPermissionsByRole")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<RolePermissionDTO>> GetPermissionsByRole(int roleID)
        {
            if (roleID <= 0)
            {
                return BadRequest("Data is invalid");
            }

            try
            {
                // سوف يتم استبدال عمليه التحقق بدوال افضل من حيث التحميل للنتيجه
                Role? role = Role.FindByRoleID(roleID);
                if (role == null)
                    return NotFound($"dose not exists role by id {role}");

                List<RolePermissionDTO> rolePermissions = RolePermission.GetPermissionsByRole(roleID);
                return Ok(rolePermissions);
            }
            catch (Exception ex)
            {
                return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "An unexpected error occurred."
                    );
            }
        }

        [HttpPost("Assign", Name = "AssignPermissionToRole")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult AddNewPermission(int roleID, int permissionID)
        {
            if (roleID <= 0 || permissionID <= 0)
            {
                return BadRequest("Data is invalid");
            }
            try
            {
                // سوف يتم استبدال عمليه التحقق بدوال افضل من حيث التحميل للنتيجه
                Role? role = Role.FindByRoleID(roleID);
                if (role == null)
                    return NotFound($"dose not exists role by id {role}");


                // سوف يتم استبدال عمليه التحقق بدوال افضل من حيث التحميل للنتيجه
                Permission? permission = Permission.FindByID(permissionID);
                if (permission == null)
                    return NotFound($"dose not exists permission by id {permissionID}");


                bool isAssigned = RolePermission.AssignPermissionToRole(
                    roleID, permissionID);

                if (!isAssigned)
                    return StatusCode(
                            StatusCodes.Status500InternalServerError,
                            "internal server error");

                return Ok("Assigned Permission to role successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "An unexpected error occurred." + ex.Message
                    );
            }
        }

        [HttpDelete("{roleID}/{permissionID}", Name = "RemovePermissionFromRole")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult RemovePermissionFromRole(int roleID, int permissionID)
        {
            if (roleID <= 0 || permissionID <= 0)
            {
                return BadRequest("Data is invalid");
            }
            try
            {
                // سوف يتم استبدال عمليه التحقق بدوال افضل من حيث التحميل للنتيجه
                Role? role = Role.FindByRoleID(roleID);
                if (role == null)
                    return NotFound($"dose not exists role by id {role}");


                // سوف يتم استبدال عمليه التحقق بدوال افضل من حيث التحميل للنتيجه
                Permission? permission = Permission.FindByID(permissionID);
                if (permission == null)
                    return NotFound($"dose not exists permission by id {permissionID}");


                bool isRemoved = RolePermission.RemovePermissionFromRole(
                    roleID, permissionID);

                if (!isRemoved)
                    return StatusCode(
                            StatusCodes.Status500InternalServerError,
                            "internal server error");

                return Ok("Assigned Permission to role successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "An unexpected error occurred." + ex.Message
                    );
            }
        }
    }
}
