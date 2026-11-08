using BuisnessLogic;
using DataAccess.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMSystem.Controllers
{
    [Route("api/Role")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        [HttpGet("All", Name = "GetAllRole")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<RoleDTO>> GetAllUser()
        {

            try
            {

                List<RoleDTO> roles = Role.GetAllRoles();
                return Ok(roles);
            }
            catch (Exception ex)
            {
                return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "An unexpected error occurred."
                    );
            }
        }

        [HttpPost("AddNew", Name = "AddNewRole")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<RoleDTO> AddNewRole(RoleDTO newRole)
        {
            if (newRole == null ||
               string.IsNullOrWhiteSpace(newRole.RoleName))
            {
                return BadRequest("Data is invalid");
            }
            try
            {

                Role role = new Role(newRole);

                if (!role.Save())
                    return StatusCode(
                            StatusCodes.Status500InternalServerError,
                            "internal server error");

                newRole.RoleID = role.RoleID;

                return CreatedAtRoute("FindByRoleID", new { roleID = newRole.RoleID }, newRole);
            }
            catch (Exception ex)
            {
                return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "An unexpected error occurred."+ex.Message
                    );
            }
        }

        [HttpPut("Update", Name = "UpdateRole")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<RoleDTO> UpdateRole(int roleID, RoleDTO updateRole)
        {
            if (roleID <= 0 ||
               updateRole == null ||
               string.IsNullOrWhiteSpace(updateRole.RoleName))
            {
                return BadRequest("Data is invalid");
            }
            try
            {

                Role? role = Role.FindByRoleID(roleID);

               role.RoleName = updateRole.RoleName;
               role.Description = updateRole.Description;

                if (!role.Save())
                    return StatusCode(
                            StatusCodes.Status500InternalServerError,
                            "internal server error");

                return Ok(role.RDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "An unexpected error occurred."
                    );
            }
        }

        // GET: api/User/Login
        [HttpGet("Find/{roleID}", Name = "FindByRoleID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<UserDTO> FindByRoleID(int roleID)
        {
            if (roleID <= 0)
            {
                return BadRequest("Data is invalid");
            }

            try
            {
                Role? role = Role.FindByRoleID(roleID);
                if (role == null)
                    return NotFound($"dose not exists role by id {roleID}");


                return Ok(role.RDTO);
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
