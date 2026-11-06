using DataAccess.DTOs;
using Microsoft.Data.SqlClient;
using System.Data;
using DataAccess.Settings;

namespace DataAccessLayer.Data
{
    public class EmployeeData
    {
        // =========================================
        // 1. Get All Employees
        // =========================================

        public static List<EmployeeDTO> GetAllEmployees()
        {
            var employeesList = new List<EmployeeDTO>();

            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_GetAllEmployees", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employeesList.Add(new EmployeeDTO(
                                reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                reader.GetString(reader.GetOrdinal("EmployeeCode")),
                                reader.GetString(reader.GetOrdinal("FullName")),

                                reader.IsDBNull(reader.GetOrdinal("Phone"))
                                    ? null
                                    : reader.GetString(reader.GetOrdinal("Phone")),

                                reader.GetInt32(reader.GetOrdinal("DepartmentID")),
                                reader.GetString(reader.GetOrdinal("DepartmentName")),

                                reader.IsDBNull(reader.GetOrdinal("JobTitle"))
                                    ? null
                                    : reader.GetString(reader.GetOrdinal("JobTitle")),

                                reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedAt"))
                            ));
                        }
                    }
                }
            }

            return employeesList;
        }


        // =========================================
        // 2. Get Employee By ID
        // =========================================

        public static EmployeeDTO? GetEmployeeById(int employeeID)
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_GetEmployeeById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@EmployeeID", SqlDbType.Int)
                        .Value = employeeID;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new EmployeeDTO(
                                reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                reader.GetString(reader.GetOrdinal("EmployeeCode")),
                                reader.GetString(reader.GetOrdinal("FullName")),

                                reader.IsDBNull(reader.GetOrdinal("Phone"))
                                    ? null
                                    : reader.GetString(reader.GetOrdinal("Phone")),

                                reader.GetInt32(reader.GetOrdinal("DepartmentID")),
                                reader.GetString(reader.GetOrdinal("DepartmentName")),

                                reader.IsDBNull(reader.GetOrdinal("JobTitle"))
                                    ? null
                                    : reader.GetString(reader.GetOrdinal("JobTitle")),

                                reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedAt"))
                            );
                        }
                    }
                }
            }

            return null;
        }


        // =========================================
        // 3. Add Employee
        // =========================================

        public static int AddEmployee(EmployeeDTO employeeDTO)
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_AddEmployee", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@EmployeeCode", SqlDbType.NVarChar, 20)
                        .Value = employeeDTO.EmployeeCode;

                    command.Parameters.Add("@FullName", SqlDbType.NVarChar, 150)
                        .Value = employeeDTO.FullName;

                    command.Parameters.Add("@Phone", SqlDbType.NVarChar, 20)
                        .Value = (object?)employeeDTO.Phone ?? DBNull.Value;

                    command.Parameters.Add("@DepartmentID", SqlDbType.Int)
                        .Value = employeeDTO.DepartmentID;

                    command.Parameters.Add("@JobTitle", SqlDbType.NVarChar, 100)
                        .Value = (object?)employeeDTO.JobTitle ?? DBNull.Value;

                    SqlParameter outputID = new SqlParameter(
                        "@NewEmployeeID", SqlDbType.Int)
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
        // 4. Update Employee
        // =========================================

        public static bool UpdateEmployee(EmployeeDTO employeeDTO)
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_UpdateEmployee", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@EmployeeID", SqlDbType.Int)
                        .Value = employeeDTO.EmployeeID;

                    command.Parameters.Add("@EmployeeCode", SqlDbType.NVarChar, 20)
                        .Value = employeeDTO.EmployeeCode;

                    command.Parameters.Add("@FullName", SqlDbType.NVarChar, 150)
                        .Value = employeeDTO.FullName;

                    command.Parameters.Add("@Phone", SqlDbType.NVarChar, 20)
                        .Value = (object?)employeeDTO.Phone ?? DBNull.Value;

                    command.Parameters.Add("@DepartmentID", SqlDbType.Int)
                        .Value = employeeDTO.DepartmentID;

                    command.Parameters.Add("@JobTitle", SqlDbType.NVarChar, 100)
                        .Value = (object?)employeeDTO.JobTitle ?? DBNull.Value;

                    connection.Open();

                    int rowsAffected = Convert.ToInt32(command.ExecuteScalar());

                    return rowsAffected == 1;
                }
            }
        }


        // =========================================
        // 5. Set Employee Active Status
        // =========================================

        public static bool SetEmployeeActiveStatus(
            int employeeID, bool isActive)
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_SetEmployeeActiveStatus", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@EmployeeID", SqlDbType.Int)
                        .Value = employeeID;

                    command.Parameters.Add("@IsActive", SqlDbType.Bit)
                        .Value = isActive;

                    connection.Open();

                    int rowsAffected = Convert.ToInt32(command.ExecuteScalar());

                    return rowsAffected == 1;
                }
            }
        }
    }
}