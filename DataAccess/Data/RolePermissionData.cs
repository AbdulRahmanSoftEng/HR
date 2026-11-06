using DataAccess.DTOs;
using Microsoft.Data.SqlClient;
using System.Data;
using DataAccess.Settings;

namespace DataAccessLayer.Data
{
    public class RolePermissionData
    {
        // =========================================
        // 1. Get Permissions By Role
        // =========================================

        public static List<RolePermissionDTO> GetPermissionsByRole(int roleID)
        {
            var permissionsList = new List<RolePermissionDTO>();

            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_GetPermissionsByRole", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@RoleID", SqlDbType.Int)
                        .Value = roleID;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            permissionsList.Add(new RolePermissionDTO(
                                reader.GetInt32(reader.GetOrdinal("RoleID")),
                                reader.GetString(reader.GetOrdinal("RoleName")),
                                reader.GetInt32(reader.GetOrdinal("PermissionID")),
                                reader.GetString(reader.GetOrdinal("PermissionName")),

                                reader.IsDBNull(reader.GetOrdinal("Description"))
                                    ? null
                                    : reader.GetString(reader.GetOrdinal("Description")),

                                reader.GetDateTime(reader.GetOrdinal("AssignedAt"))
                            ));
                        }
                    }
                }
            }

            return permissionsList;
        }


        // =========================================
        // 2. Assign Permission To Role
        // =========================================

        public static bool AssignPermissionToRole(
            int roleID, int permissionID)
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_AssignPermissionToRole", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@RoleID", SqlDbType.Int)
                        .Value = roleID;

                    command.Parameters.Add("@PermissionID", SqlDbType.Int)
                        .Value = permissionID;

                    connection.Open();

                    object? result = command.ExecuteScalar();

                    return result != null &&
                           result != DBNull.Value &&
                           Convert.ToBoolean(result);
                }
            }
        }


        // =========================================
        // 3. Remove Permission From Role
        // =========================================

        public static bool RemovePermissionFromRole(
            int roleID, int permissionID)
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_RemovePermissionFromRole", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@RoleID", SqlDbType.Int)
                        .Value = roleID;

                    command.Parameters.Add("@PermissionID", SqlDbType.Int)
                        .Value = permissionID;

                    connection.Open();

                    int rowsAffected = Convert.ToInt32(command.ExecuteScalar());

                    return rowsAffected == 1;
                }
            }
        }
    }
}