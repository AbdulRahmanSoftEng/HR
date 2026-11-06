using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class DashboardDTO
    {
        public DashboardDTO(
            int activeEmployees,
            int activeDepartments,
            int todayAttendance,
            int todayAbsence)
        {
            ActiveEmployees = activeEmployees;
            ActiveDepartments = activeDepartments;
            TodayAttendance = todayAttendance;
            TodayAbsence = todayAbsence;
        }

        public int ActiveEmployees { get; set; }
        public int ActiveDepartments { get; set; }
        public int TodayAttendance { get; set; }
        public int TodayAbsence { get; set; }
    }
}