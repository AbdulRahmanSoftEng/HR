using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystemFrontend.DTOs.Dashbord
{
    public class DashboardDTO
    { 
        
        public int ActiveEmployees { get; set; }
        public int ActiveDepartments { get; set; }
        public int TodayAttendance { get; set; }
        public int TodayAbsence { get; set; }
    }
}