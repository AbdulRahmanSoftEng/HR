using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using DataAccess.Data;
using DataAccess.DTOs;

namespace BuisnessLogic
{
    public class Dashboard
    {
        public DashboardDTO DDTO { get; set; }

        public int ActiveEmployees
        {
            get { return DDTO.ActiveEmployees; }
        }

        public int ActiveDepartments
        {
            get { return DDTO.ActiveDepartments; }
        }

        public int TodayAttendance
        {
            get { return DDTO.TodayAttendance; }
        }

        public int TodayAbsence
        {
            get { return DDTO.TodayAbsence; }
        }

        public Dashboard(DashboardDTO DDTO)
        {
            this.DDTO = DDTO;
        }

        public static Dashboard GetStatistics()
        {
            DashboardDTO DDTO =
                DashboardData.GetDashboardStatistics();

            return new Dashboard(DDTO);
        }

        public static List<RecentAttendanceDTO> GetRecentAttendances()
        {
           return DashboardData.GetRecentAttendances();

        }
    }
}
