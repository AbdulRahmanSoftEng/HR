using Microsoft.Data.SqlClient;
using System.Data;
using DataAccess.Settings;
using DataAccess.DTOs.Attendance;
using DataAccess.DTOs.Dashbord;

namespace DataAccess.Data
{
    public class AttendanceData
    {
        // =========================================
        // 1. Get All Attendance
        // =========================================

        public static List<AttendanceDTO> GetAllAttendance()
        {
            var attendanceList = new List<AttendanceDTO>();

            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_GetAllAttendance", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            attendanceList.Add(new AttendanceDTO
                            {
                                AttendanceID = reader.GetInt32(reader.GetOrdinal("AttendanceID")),
                                EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                FullName = reader.GetString(reader.GetOrdinal("FullName")),
                                AttendanceDate = reader.GetDateTime(reader.GetOrdinal("AttendanceDate")),
                                CheckIn = reader.GetTimeSpan(reader.GetOrdinal("CheckIn")),

                                CheckOut = reader.IsDBNull(reader.GetOrdinal("CheckOut"))
                                    ? null
                                    : reader.GetTimeSpan(reader.GetOrdinal("CheckOut")),

                                Notes = reader.IsDBNull(reader.GetOrdinal("Notes"))
                                    ? null
                                    : reader.GetString(reader.GetOrdinal("Notes"))
                            });
                        }
                    }
                }
            }

            return attendanceList;
        }


        // =========================================
        // 1. Get All Attendance tody
        // =========================================

        public static List<TodayAttendanceRecords> GetTodayAttendanceRecords(TodayAttendanceRecordPagination pagination)
        {
            var todayAttendanceRecords = new List<TodayAttendanceRecords>();

            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_GetTodayAttendanceRecords", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@PageNumber", SqlDbType.Int)
                        .Value = pagination.PageNumber;

                    command.Parameters.Add("@PagePerNumber", SqlDbType.Int)
                        .Value = pagination.PagePerNumber;
                        
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            todayAttendanceRecords.Add(new TodayAttendanceRecords
                            {
                                AttendanceID = reader.IsDBNull(reader.GetOrdinal("AttendanceID"))
                                    ? null
                                    : reader.GetInt32(reader.GetOrdinal("AttendanceID")),

                                EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                FullName = reader.GetString(reader.GetOrdinal("FullName")),
                                DepartmentName = reader.GetString(reader.GetOrdinal("DepartmentName")),

                                CheckIn = reader.IsDBNull(reader.GetOrdinal("CheckIn"))
                                    ? null
                                    : reader.GetTimeSpan(reader.GetOrdinal("CheckIn")),

                                CheckOut = reader.IsDBNull(reader.GetOrdinal("CheckOut"))
                                    ? null
                                    : reader.GetTimeSpan(reader.GetOrdinal("CheckOut")),

                                Status = reader.GetString(reader.GetOrdinal("Status"))
                            });
                        }
                    }
                }
            }

            return todayAttendanceRecords;
        }


        // =========================================
        // 1. Get All Employees FOr Attendance
        // =========================================

        public static List<EmployeeForAttendanceDTO> GetEmployeesForAttendance()
        {
            var employeeForAttendances = new List<EmployeeForAttendanceDTO>();

            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_GetEmployeesForAttendance", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employeeForAttendances.Add(new EmployeeForAttendanceDTO
                            {
                                EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                Name = reader.GetString(reader.GetOrdinal("Name"))
                            });
                        }
                    }
                }
            }

            return employeeForAttendances;
        }


        // =========================================
        // 2. Get Attendance By ID
        // =========================================

        public static AttendanceDTO? GetAttendanceById(int attendanceID)
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_GetAttendanceById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@AttendanceID", SqlDbType.Int)
                        .Value = attendanceID;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new AttendanceDTO {
                                 AttendanceID = reader.GetInt32(reader.GetOrdinal("AttendanceID")),
                                 EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                 FullName = reader.GetString(reader.GetOrdinal("FullName")),
                                 AttendanceDate = reader.GetDateTime(reader.GetOrdinal("AttendanceDate")),
                                 CheckIn = reader.GetTimeSpan(reader.GetOrdinal("CheckIn")),

                                 CheckOut = reader.IsDBNull(reader.GetOrdinal("CheckOut"))
                                    ? null
                                    : reader.GetTimeSpan(reader.GetOrdinal("CheckOut")),

                                 Notes = reader.IsDBNull(reader.GetOrdinal("Notes"))
                                    ? null
                                    : reader.GetString(reader.GetOrdinal("Notes"))
                            };
                        }
                    }
                }
            }

            return null;
        }


        // =========================================
        // 3. Get Attendance By Employee
        // =========================================

        public static List<AttendanceDTO> GetAttendanceByEmployee(int employeeID)
        {
            var attendanceList = new List<AttendanceDTO>();

            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_GetAttendanceByEmployee", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@EmployeeID", SqlDbType.Int)
                        .Value = employeeID;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            attendanceList.Add(new AttendanceDTO
                            {
                                AttendanceID = reader.GetInt32(reader.GetOrdinal("AttendanceID")),
                                EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                FullName = reader.GetString(reader.GetOrdinal("FullName")),
                                AttendanceDate = reader.GetDateTime(reader.GetOrdinal("AttendanceDate")),
                                CheckIn = reader.GetTimeSpan(reader.GetOrdinal("CheckIn")),

                                CheckOut = reader.IsDBNull(reader.GetOrdinal("CheckOut"))
                                    ? null
                                    : reader.GetTimeSpan(reader.GetOrdinal("CheckOut")),

                                Notes = reader.IsDBNull(reader.GetOrdinal("Notes"))
                                    ? null
                                    : reader.GetString(reader.GetOrdinal("Notes"))
                            });
                        }
                    }
                }
            }

            return attendanceList;
        }


        // =========================================
        // 4. Check In
        // =========================================

        public static int CheckIn(int employeeID, string? notes = null)
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_CheckIn", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@EmployeeID", SqlDbType.Int)
                        .Value = employeeID;

                    command.Parameters.Add("@Notes", SqlDbType.NVarChar, 500)
                        .Value = (object?)notes ?? DBNull.Value;

                    SqlParameter outputID = new SqlParameter(
                        "@NewAttendanceID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(outputID);

                    connection.Open();

                    command.ExecuteNonQuery();

                    return Convert.ToInt32(outputID.Value);
                }
            }
        }


        // =========================================
        // 5. Check Out
        // =========================================

        public static bool CheckOut(int attendanceID)
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_CheckOut", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@AttendanceID", SqlDbType.Int)
                        .Value = attendanceID;

                    connection.Open();

                    int rowsAffected = Convert.ToInt32(command.ExecuteScalar());

                    return rowsAffected == 1;
                }
            }
        }

        // =========================================
        // 1. this is funcation retreving data of card in screen attendances:
        // Today Attendance Statistics 
        // =========================================

        public static TodayAttendanceStatisticsDTO GetTodayAttendanceStatistics()
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_GetTodayAttendanceStatistics", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new TodayAttendanceStatisticsDTO
                            {
                                TotalEmployees = reader.GetInt32(reader.GetOrdinal("TotalEmployees")),
                                PresentToday = reader.GetInt32(reader.GetOrdinal("PresentToday")),
                                AbsentToday = reader.GetInt32(reader.GetOrdinal("AbsentToday")),
                            };
                        }
                    }
                }
            }

            return new TodayAttendanceStatisticsDTO
            {
                TotalEmployees = 0,
                PresentToday = 0,
                AbsentToday = 0
            };
        }
    }
}