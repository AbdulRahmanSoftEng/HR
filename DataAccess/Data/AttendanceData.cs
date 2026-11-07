using DataAccess.DTOs;
using Microsoft.Data.SqlClient;
using System.Data;
using DataAccess.Settings;

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
                            attendanceList.Add(new AttendanceDTO(
                                reader.GetInt32(reader.GetOrdinal("AttendanceID")),
                                reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                reader.GetString(reader.GetOrdinal("FullName")),
                                reader.GetDateTime(reader.GetOrdinal("AttendanceDate")),
                                reader.GetTimeSpan(reader.GetOrdinal("CheckIn")),

                                reader.IsDBNull(reader.GetOrdinal("CheckOut"))
                                    ? null
                                    : reader.GetTimeSpan(reader.GetOrdinal("CheckOut")),

                                reader.IsDBNull(reader.GetOrdinal("Notes"))
                                    ? null
                                    : reader.GetString(reader.GetOrdinal("Notes"))
                            ));
                        }
                    }
                }
            }

            return attendanceList;
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
                            return new AttendanceDTO(
                                reader.GetInt32(reader.GetOrdinal("AttendanceID")),
                                reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                reader.GetString(reader.GetOrdinal("FullName")),
                                reader.GetDateTime(reader.GetOrdinal("AttendanceDate")),
                                reader.GetTimeSpan(reader.GetOrdinal("CheckIn")),

                                reader.IsDBNull(reader.GetOrdinal("CheckOut"))
                                    ? null
                                    : reader.GetTimeSpan(reader.GetOrdinal("CheckOut")),

                                reader.IsDBNull(reader.GetOrdinal("Notes"))
                                    ? null
                                    : reader.GetString(reader.GetOrdinal("Notes"))
                            );
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
                            attendanceList.Add(new AttendanceDTO(
                                reader.GetInt32(reader.GetOrdinal("AttendanceID")),
                                reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                reader.GetString(reader.GetOrdinal("FullName")),
                                reader.GetDateTime(reader.GetOrdinal("AttendanceDate")),
                                reader.GetTimeSpan(reader.GetOrdinal("CheckIn")),

                                reader.IsDBNull(reader.GetOrdinal("CheckOut"))
                                    ? null
                                    : reader.GetTimeSpan(reader.GetOrdinal("CheckOut")),

                                reader.IsDBNull(reader.GetOrdinal("Notes"))
                                    ? null
                                    : reader.GetString(reader.GetOrdinal("Notes"))
                            ));
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
    }
}