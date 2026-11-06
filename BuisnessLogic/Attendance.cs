using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.Data;
using DataAccess.DTOs;

namespace BuisnessLogic
{
    public class Attendance
    {
        public AttendanceDTO ADTO
        {
            get
            {
                return new AttendanceDTO(
                    AttendanceID,
                    EmployeeID,
                    EmployeeName,
                    AttendanceDate,
                    CheckInTime,
                    CheckOutTime,
                    Notes
                );
            }
        }

        public int AttendanceID { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public DateTime AttendanceDate { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime? CheckOutTime { get; set; }
        public string? Notes { get; set; }

        public Attendance(AttendanceDTO ADTO)
        {
            AttendanceID = ADTO.AttendanceID;
            EmployeeID = ADTO.EmployeeID;
            EmployeeName = ADTO.EmployeeName;
            AttendanceDate = ADTO.AttendanceDate;
            CheckInTime = ADTO.CheckIn;
            CheckOutTime = ADTO.CheckOut;
            Notes = ADTO.Notes;
        }

        public static List<AttendanceDTO> GetAllAttendance()
        {
            return AttendanceData.GetAllAttendance();
        }

        public static Attendance? Find(int attendanceID)
        {
            AttendanceDTO? ADTO =
                AttendanceData.GetAttendanceById(attendanceID);

            if (ADTO != null)
                return new Attendance(ADTO);

            return null;
        }

        public static List<AttendanceDTO> GetByEmployee(int employeeID)
        {
            return AttendanceData.GetAttendanceByEmployee(employeeID);
        }

        public static int CheckIn(int employeeID, string? notes = null)
        {
            return AttendanceData.CheckIn(employeeID, notes);
        }

        public static bool CheckOut(int attendanceID)
        {
            return AttendanceData.CheckOut(attendanceID);
        }
    }
}
