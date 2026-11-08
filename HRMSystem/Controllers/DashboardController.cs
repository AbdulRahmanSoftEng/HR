using BuisnessLogic;
using DataAccess.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMSystem.Controllers
{
    [Route("api/Dashboard")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        [HttpGet("Statistics", Name = "GetStatistics")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<DashboardDTO> GetStatistics()
        {
            try
            {
                Dashboard dashboard = Dashboard.GetStatistics();

                if (dashboard == null)
                    return StatusCode(
                            StatusCodes.Status500InternalServerError,
                            "Internale server error to featch data");

                return Ok(dashboard.DDTO);

            }catch(Exception ex)
            {
                return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "An axexception error failed");
            }
        }


        [HttpGet("RecentAttendances", Name = "GetRecentAttendances")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<RecentAttendanceDTO> GetRecentAttendances()
        {
            try
            {
                List<RecentAttendanceDTO> attendances = Dashboard.GetRecentAttendances();

                
                return Ok(attendances);

            }catch(Exception ex)
            {
                return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "An axexception error failed");
            }
        }
    }
}
