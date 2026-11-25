using BuisnessLogic;
using DataAccess.DTOs.Attendance;
using DataAccess.DTOs.Dashbord;
using DataAccess.DTOs.Employee;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace HRMSystem.Controllers
{
    [Route("api/Attendances")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {

        // GET: api/Attendance/All
        [HttpGet("All", Name = "GetAllAttendance")]
        [ProducesResponseType(StatusCodes.Status200OK)]
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

        // GET: api/Attendance/Employees
        [HttpGet("EmpForAtt", Name = "GetEmployeesForAttendance")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<EmployeeForAttendanceDTO>> GetEmployeesForAttendance()
        {
            try
            {
                List<EmployeeForAttendanceDTO> employeeForAttendances = Attendance.GetEmployeesForAttendance();
                return Ok(employeeForAttendances);
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
        [ProducesResponseType(StatusCodes.Status201Created)]
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

        // GET: api/Attendance/Pagination
        [HttpGet("Pagination", Name = "GetTodayAttendanceRecords")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<TodayAttendanceRecords>> GetTodayAttendanceRecords([FromQuery] TodayAttendanceRecordPagination pagination)
        {
            if (pagination.PageNumber <= 0 || pagination.PagePerNumber <= 0)
                return BadRequest("Invalied pageNumber or pagePerNumber");

            try
            {
                List<TodayAttendanceRecords> attendanceRecords = Attendance.GetTodayAttendanceRecords(pagination);

                return Ok(attendanceRecords);
            }
            catch (Exception ex)
            {
                return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "An unexpected error occurred. "+ex.Message
                    );
            }
        }

        [HttpGet("Statistics", Name = "GetTodayAttendanceStatistics")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<DashboardDTO> GetTodayAttendanceStatistics()
        {
            try
            {
                TodayAttendanceStatisticsDTO statisticsDTO = Attendance.GetTodayAttendanceStatistics();

                if (statisticsDTO == null)
                    return StatusCode(
                            StatusCodes.Status500InternalServerError,
                            "Internale server error to featch data");

                return Ok(statisticsDTO);

            }
            catch (Exception ex)
            {
                return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        "An axexception error failed");
            }
        }


    }
}
