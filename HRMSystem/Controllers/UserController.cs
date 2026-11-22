using BuisnessLogic;
using BuisnessLogic.Utilities;
using DataAccess.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace HRMSystem.Controllers
{
    [Route("api/Users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/User/All
        [HttpGet("All", Name = "GetAllUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<FullUserDTO>> GetAllUser()
        {
            
            try
            {
                
                List<FullUserDTO> users = clsUser.GetAllUsers();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "An unexpected error occurred."
                    );
            }
        }

        // GET: api/User/All
        [HttpPost("AddNew", Name = "AddNewUser")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<FullUserDTO> AddNewUser(UserDTO newUser)
        {
            if(newUser == null ||
                newUser.EmployeeID <= 0 ||
                string.IsNullOrWhiteSpace(newUser.Username) ||
                string.IsNullOrWhiteSpace(newUser.Password) ||
                newUser.RoleID <= 0)
            {
                return BadRequest("Data is invalid");
            }

            try
            {
                newUser.Password = clsUser.HashPassword(newUser.Password); 

                clsUser user = new clsUser(newUser);
                if (!user.Save())
                    return StatusCode(
                            StatusCodes.Status500InternalServerError,
                            "internal server error");

                user = clsUser.FindById(user.UserID);

                return Ok(user.FUDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "An unexpected error occurred."+ex.Message
                    );
            }
        }

        // GET: api/User/Login
        [HttpGet("Login/{username}/{password}", Name = "LoginUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<FullUserDTO> LoginUser(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username)
                || string.IsNullOrWhiteSpace(password))
            {
                return BadRequest("Data is invalid");
            }

            try
            {

                clsUser user = clsUser.LoginUser(username);
                if (user == null)
                    return NotFound($"dose not exists user by Username {username}");

                if(!user.VerifyPassword(password))
                {
                    return Unauthorized("Invalid password");
                }

                return Ok(user.FUDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "An unexpected error occurred." + ex.Message
                    );
            }
        }

        // GET: api/User/Login
        [HttpGet("{userID}", Name = "FindByUserID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<FullUserDTO> FindByUserID(int userID)
        {
            if (userID <= 0 )
            {
                return BadRequest("Data is invalid");
            }

            try
            {
                clsUser? user = clsUser.FindById(userID);
                if (user == null)
                    return NotFound($"dose not exists user by id {userID}");


                return Ok(user.FUDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "An unexpected error occurred." + ex.Message
                    );
            }
        }

        // GET: api/User/UpdateStatus
        [HttpPut("UpdateStatus", Name = "SetUserActiveStatus")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<UserDTO> SetUserActiveStatus(int userID, bool status)
        {
            if (userID <= 0)
            {
                return BadRequest("Data is invalid");
            }

            try
            {
                clsUser clsUser = clsUser.FindById(userID);
                if (clsUser == null)
                    return NotFound($"dose not exists user by id {userID}");

                bool Result = clsUser.SetUserActiveStatus(userID, status);

                if(!Result)
                    return StatusCode(
                            StatusCodes.Status500InternalServerError,
                            "internal server error");
                return Ok("Update Status successfully");
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
