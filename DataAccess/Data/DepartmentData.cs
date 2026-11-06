
using DataAccess.DTOs;
using Microsoft.Data.SqlClient;
using System.Data;
using DataAccess.Settings;
namespace DataAccessLayer.Data
{
    public class DepartmentData
    {
        // =========================================
        // 1. Get All Departments
        // =========================================

        public static List<DepartmentDTO> GetAllDepartments()
        {
            var departmentsList = new List<DepartmentDTO>();

            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_GetAllDepartments", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            departmentsList.Add(new DepartmentDTO(
                                reader.GetInt32(reader.GetOrdinal("DepartmentID")),
                                reader.GetString(reader.GetOrdinal("DepartmentName")),
                                reader.IsDBNull(reader.GetOrdinal("Description"))
                                    ? null
                                    : reader.GetString(reader.GetOrdinal("Description")),
                                reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedAt"))
                            ));
                        }
                    }
                }
            }

            return departmentsList;
        }


        // =========================================
        // 2. Get Department By ID
        // =========================================

        public static DepartmentDTO? GetDepartmentById(int departmentID)
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_GetDepartmentById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@DepartmentID", SqlDbType.Int)
                        .Value = departmentID;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new DepartmentDTO(
                                reader.GetInt32(reader.GetOrdinal("DepartmentID")),
                                reader.GetString(reader.GetOrdinal("DepartmentName")),
                                reader.IsDBNull(reader.GetOrdinal("Description"))
                                    ? null
                                    : reader.GetString(reader.GetOrdinal("Description")),
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
        // 3. Add Department
        // =========================================

        public static int AddDepartment(DepartmentDTO departmentDTO)
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_AddDepartment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@DepartmentName", SqlDbType.NVarChar, 100)
                        .Value = departmentDTO.DepartmentName;

                    command.Parameters.Add("@Description", SqlDbType.NVarChar, 500)
                        .Value = (object?)departmentDTO.Description ?? DBNull.Value;

                    SqlParameter outputID = new SqlParameter(
                        "@NewDepartmentID", SqlDbType.Int)
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
        // 4. Update Department
        // =========================================

        public static bool UpdateDepartment(DepartmentDTO departmentDTO)
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_UpdateDepartment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@DepartmentID", SqlDbType.Int)
                        .Value = departmentDTO.DepartmentID;

                    command.Parameters.Add("@DepartmentName", SqlDbType.NVarChar, 100)
                        .Value = departmentDTO.DepartmentName;

                    command.Parameters.Add("@Description", SqlDbType.NVarChar, 500)
                        .Value = (object?)departmentDTO.Description ?? DBNull.Value;

                    connection.Open();

                    int rowsAffected = Convert.ToInt32(command.ExecuteScalar());

                    return rowsAffected == 1;
                }
            }
        }


        // =========================================
        // 5. Deactivate Department
        // =========================================

        public static bool DeactivateDepartment(int departmentID)
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_DeactivateDepartment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@DepartmentID", SqlDbType.Int)
                        .Value = departmentID;

                    connection.Open();

                    int rowsAffected = Convert.ToInt32(command.ExecuteScalar());

                    return rowsAffected == 1;
                }
            }
        }
    }
}
