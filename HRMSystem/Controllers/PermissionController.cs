using BuisnessLogic;
using DataAccess.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace HRMSystem.Controllers
{
    [Route("api/Permission")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        [HttpGet("All", Name = "GetAllPermission")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<PermissionDTO>> GetAllPermission()
        {

            try
            {

                List<PermissionDTO> permissions = Permission.GetAllPermissions();
                return Ok(permissions);
            }
            catch (Exception ex)
            {
                return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "An unexpected error occurred."
                    );
            }
        }

        [HttpPost("AddNew", Name = "AddNewPermission")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<PermissionDTO> AddNewPermission(PermissionDTO newPermission)
        {
            if (newPermission == null ||
               string.IsNullOrWhiteSpace(newPermission.PermissionName))
            {
                return BadRequest("Data is invalid");
            }
            try
            {

                Permission permission = new Permission(newPermission);

                if (!permission.Save())
                    return StatusCode(
                            StatusCodes.Status500InternalServerError,
                            "internal server error");

                newPermission.PermissionID = permission.PermissionID;

                return CreatedAtRoute("FindByPermissionID", new { permissionID = newPermission.PermissionID }, newPermission);
            }
            catch (Exception ex)
            {
                return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "An unexpected error occurred." + ex.Message
                    );
            }
        }

        [HttpPut("Update", Name = "UpdatePermission")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<PermissionDTO> UpdatePermission(int permissionID, PermissionDTO updatePermission)
        {
            if (permissionID <= 0 ||
               updatePermission == null ||
               string.IsNullOrWhiteSpace(updatePermission.PermissionName))
            {
                return BadRequest("Data is invalid");
            }
            try
            {

                Permission? permission = Permission.FindByID(permissionID);

                permission.PermissionName = updatePermission.PermissionName;
                permission.Description = updatePermission.Description;

                if (!permission.Save())
                    return StatusCode(
                            StatusCodes.Status500InternalServerError,
                            "internal server error");

                return Ok(permission.PDTO);
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
        [HttpGet("Find/{permissionID}", Name = "FindByPermissionID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<UserDTO> FindByPermissionID(int permissionID)
        {
            if (permissionID <= 0)
            {
                return BadRequest("Data is invalid");
            }

            try
            {
                Permission? permission = Permission.FindByID(permissionID);
                if (permission == null)
                    return NotFound($"dose not exists permission by id {permissionID}");


                return Ok(permission.PDTO);
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
