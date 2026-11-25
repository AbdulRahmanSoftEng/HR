using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs.Attendance
{
    public class TodayAttendanceRecordPagination
    {
        public int PageNumber { get; set; }
        public int PagePerNumber { get; set; }
    }
}
