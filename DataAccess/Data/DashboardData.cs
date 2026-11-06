using DataAccess.DTOs;
using Microsoft.Data.SqlClient;
using System.Data;
using DataAccess.Settings;

namespace DataAccessLayer.Data
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
                            return new DashboardDTO(
                                reader.GetInt32(reader.GetOrdinal("ActiveEmployees")),
                                reader.GetInt32(reader.GetOrdinal("ActiveDepartments")),
                                reader.GetInt32(reader.GetOrdinal("TodayAttendance")),
                                reader.GetInt32(reader.GetOrdinal("TodayAbsence"))
                            );
                        }
                    }
                }
            }

            return new DashboardDTO(0, 0, 0, 0);
        }
    }
}