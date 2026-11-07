using BuisnessLogic;
using DataAccess.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMSystem.Controllers
{
    [Route("api/Attendance")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {

        // GET: api/Attendance/All
        [HttpGet("All", Name = "GetAllAttendance")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<AttendanceDTO>> GetAllAttendance()
        {
            try
            {
                List<AttendanceDTO> attendances = Attendance.GetAllAttendance();
                return Ok(attendances);
            }
            catch (Exception ex)
            {
                return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "An unexpected error occurred."
                    );
            }
        }

        // POST: api/Attendance/CheckIn
        [HttpPost("CheckIn", Name = "CheckInAttencance")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<AttendanceDTO> CheckInAttencance(
            int employeeId,
            string? notes = null)
        {
            if (employeeId <= 0)
                return BadRequest("Invalied Employee ID");

            try
            {
                int attendanceId = Attendance.CheckIn(employeeId, notes);

                if (attendanceId > 0)
                    return Ok("Employee attendance successfully");
                
                else
                    return StatusCode(
                            StatusCodes.Status500InternalServerError,
                            "Failed to attendance employee"
                        );
            }
            catch (Exception ex)
            {
                return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "An unexpected error occurred. "
                    );
            }
        }


        // POST: api/Attendance/CheckOut
        [HttpPost("CheckOut", Name = "CheckOutAttencance")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<AttendanceDTO> CheckOutAttencance(int attendanceId)
        {
            if (attendanceId <= 0)
                return BadRequest("Invalied Attendance ID");

            try
            {
                bool IsChecked = Attendance.CheckOut(attendanceId);

                if (IsChecked)
                    return Ok("Employee attendance successfully");
                else
                    return StatusCode(
                            StatusCodes.Status500InternalServerError,
                            "Failed to attendance employee"
                        );
            }
            catch (Exception ex)
            {
                return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "An unexpected error occurred. "
                    );
            }
        }

        // GET: api/Attendance/ById
        [HttpGet("ById/{attendanceID}", Name = "FindById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<AttendanceDTO> FindById(int attendanceID)
        {
            if (attendanceID <= 0)
                return BadRequest("Invalied Attendance ID");

            try
            {
                Attendance attendance = Attendance.Find(attendanceID);
                if (attendance == null)
                    return NotFound($"Attendance with ID {attendanceID} was not found");

                return Ok(attendance.ADTO);
            }
            catch (Exception ex)
            {
                return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "An unexpected error occurred. "
                    );
            }
        }

        // GET: api/Attendance/SearchByEmpId
        [HttpGet("SearchByEmpId/{employeeId}", Name = "SearchAllAttendanceByEmpId")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<EmployeeDTO>> SearchAllAttendanceByEmpId(int employeeId)
        {
            if (employeeId <= 0)
                return BadRequest("Invalied Employee ID");

            try
            {
                var attendances = Attendance.GetByEmployee(employeeId);
                if (attendances == null)
                    return NotFound($"Employee Attendances with ID {employeeId} was not found");

                return Ok(attendances);
            }
            catch (Exception ex)
            {
                return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "An unexpected error occurred. "+ex.Message
                    );
            }
        }
    }
}
