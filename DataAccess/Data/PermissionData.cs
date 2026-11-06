using DataAccess.DTOs;
using Microsoft.Data.SqlClient;
using System.Data;
using DataAccess.Settings;

namespace DataAccess.Data
{
    public class PermissionData
    {
        // =========================================
        // 1. Get All Permissions
        // =========================================

        public static List<PermissionDTO> GetAllPermissions()
        {
            var permissionsList = new List<PermissionDTO>();

            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_GetAllPermissions", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            permissionsList.Add(new PermissionDTO(
                                reader.GetInt32(reader.GetOrdinal("PermissionID")),
                                reader.GetString(reader.GetOrdinal("PermissionName")),
                                reader.IsDBNull(reader.GetOrdinal("Description"))
                                    ? null
                                    : reader.GetString(reader.GetOrdinal("Description"))
                            ));
                        }
                    }
                }
            }

            return permissionsList;
        }


        // =========================================
        // 2. Get Permission By ID
        // =========================================

        public static PermissionDTO? GetPermissionById(int permissionID)
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_GetPermissionById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@PermissionID", SqlDbType.Int)
                        .Value = permissionID;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new PermissionDTO(
                                reader.GetInt32(reader.GetOrdinal("PermissionID")),
                                reader.GetString(reader.GetOrdinal("PermissionName")),
                                reader.IsDBNull(reader.GetOrdinal("Description"))
                                    ? null
                                    : reader.GetString(reader.GetOrdinal("Description"))
                            );
                        }
                    }
                }
            }

            return null;
        }


        // =========================================
        // 3. Add Permission
        // =========================================

        public static int AddPermission(PermissionDTO permissionDTO)
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_AddPermission", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@PermissionName", SqlDbType.NVarChar, 100)
                        .Value = permissionDTO.PermissionName;

                    command.Parameters.Add("@Description", SqlDbType.NVarChar, 250)
                        .Value = (object?)permissionDTO.Description ?? DBNull.Value;

                    SqlParameter outputID = new SqlParameter(
                        "@NewPermissionID", SqlDbType.Int)
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
        // 4. Update Permission
        // =========================================

        public static bool UpdatePermission(PermissionDTO permissionDTO)
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_UpdatePermission", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@PermissionID", SqlDbType.Int)
                        .Value = permissionDTO.PermissionID;

                    command.Parameters.Add("@PermissionName", SqlDbType.NVarChar, 100)
                        .Value = permissionDTO.PermissionName;

                    command.Parameters.Add("@Description", SqlDbType.NVarChar, 250)
                        .Value = (object?)permissionDTO.Description ?? DBNull.Value;

                    connection.Open();

                    int rowsAffected = Convert.ToInt32(command.ExecuteScalar());

                    return rowsAffected == 1;
                }
            }
        }
    }
}
