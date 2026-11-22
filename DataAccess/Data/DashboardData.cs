using DataAccess.DTOs;
using DataAccess.Settings;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Reflection.PortableExecutable;

namespace DataAccess.Data
{
    public class DashboardData
    {
        // =========================================
        // 1. Get Dashboard Statistics
        // =========================================

        public static DashboardDTO GetDashboardStatistics()
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_GetDashboardStatistics", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new DashboardDTO
                            {
                                ActiveEmployees = reader.GetInt32(reader.GetOrdinal("ActiveEmployees")),
                                ActiveDepartments = reader.GetInt32(reader.GetOrdinal("ActiveDepartments")),
                                TodayAttendance = reader.GetInt32(reader.GetOrdinal("TodayAttendance")),
                                TodayAbsence = reader.GetInt32(reader.GetOrdinal("TodayAbsence"))
                            };
                        }
                    }
                }
            }

            return new DashboardDTO
            {
                ActiveEmployees = 0,
                ActiveDepartments = 0,
                TodayAttendance = 0,
                TodayAbsence = 0
            };
        }

        // =========================================
        // 1. Get Dashboard Recent Attendances
        // =========================================

        public static List<RecentAttendanceDTO> GetRecentAttendances()
        {
            List<RecentAttendanceDTO> recentAttendances = new List<RecentAttendanceDTO>();
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_GetRecentAttendances", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            recentAttendances.Add(
                                new RecentAttendanceDTO
                                {

                                    AttendanceID = reader.GetInt32(reader.GetOrdinal("AttendanceID")),
                                    FullName = reader.GetString(reader.GetOrdinal("FullName")),
                                    DepartmentName = reader.GetString(reader.GetOrdinal("DepartmentName")),
                                    CheckIn = reader.GetTimeSpan(reader.GetOrdinal("CheckIn")),
                                    CheckOut = reader.IsDBNull(reader.GetOrdinal("CheckOut"))
                                    ? null
                                    : reader.GetTimeSpan(reader.GetOrdinal("CheckOut"))

                                }
                            );
                        }
                    }
                }
            }

            return recentAttendances;
        }
    }
}