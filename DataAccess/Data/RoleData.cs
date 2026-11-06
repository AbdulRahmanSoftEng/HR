using DataAccess.DTOs;
using Microsoft.Data.SqlClient;
using System.Data;
using DataAccess.Settings;

namespace DataAccessLayer.Data
{
    public class RoleData
    {
        // =========================================
        // 1. Get All Roles
        // =========================================

        public static List<RoleDTO> GetAllRoles()
        {
            var rolesList = new List<RoleDTO>();

            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_GetAllRoles", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rolesList.Add(new RoleDTO(
                                reader.GetInt32(reader.GetOrdinal("RoleID")),
                                reader.GetString(reader.GetOrdinal("RoleName")),
                                reader.IsDBNull(reader.GetOrdinal("Description"))
                                    ? null
                                    : reader.GetString(reader.GetOrdinal("Description")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedAt"))
                            ));
                        }
                    }
                }
            }

            return rolesList;
        }


        // =========================================
        // 2. Get Role By ID
        // =========================================

        public static RoleDTO? GetRoleById(int roleID)
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_GetRoleById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@RoleID", SqlDbType.Int)
                        .Value = roleID;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new RoleDTO(
                                reader.GetInt32(reader.GetOrdinal("RoleID")),
                                reader.GetString(reader.GetOrdinal("RoleName")),
                                reader.IsDBNull(reader.GetOrdinal("Description"))
                                    ? null
                                    : reader.GetString(reader.GetOrdinal("Description")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedAt"))
                            );
                        }
                    }
                }
            }

            return null;
        }


        // =========================================
        // 3. Add Role
        // =========================================

        public static int AddRole(RoleDTO roleDTO)
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_AddRole", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@RoleName", SqlDbType.NVarChar, 50)
                        .Value = roleDTO.RoleName;

                    command.Parameters.Add("@Description", SqlDbType.NVarChar, 250)
                        .Value = (object?)roleDTO.Description ?? DBNull.Value;

                    SqlParameter outputID = new SqlParameter(
                        "@NewRoleID", SqlDbType.Int)
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
        // 4. Update Role
        // =========================================

        public static bool UpdateRole(RoleDTO roleDTO)
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_UpdateRole", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@RoleID", SqlDbType.Int)
                        .Value = roleDTO.RoleID;

                    command.Parameters.Add("@RoleName", SqlDbType.NVarChar, 50)
                        .Value = roleDTO.RoleName;

                    command.Parameters.Add("@Description", SqlDbType.NVarChar, 250)
                        .Value = (object?)roleDTO.Description ?? DBNull.Value;

                    connection.Open();

                    int rowsAffected = Convert.ToInt32(command.ExecuteScalar());

                    return rowsAffected == 1;
                }
            }
        }
    }
}