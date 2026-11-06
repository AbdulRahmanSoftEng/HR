using DataAccess.DTOs;
using Microsoft.Data.SqlClient;
using System.Data;
using DataAccess.Settings;

namespace DataAccess.Data
{
    public class UserData
    {
        // =========================================
        // 1. Get All Users
        // =========================================

        public static List<UserDTO> GetAllUsers()
        {
            var usersList = new List<UserDTO>();

            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_GetAllUsers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usersList.Add(new UserDTO(
                                reader.GetInt32(reader.GetOrdinal("UserID")),
                                reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                reader.GetString(reader.GetOrdinal("EmployeeCode")),
                                reader.GetString(reader.GetOrdinal("FullName")),
                                reader.GetString(reader.GetOrdinal("Username")),
                                reader.GetInt32(reader.GetOrdinal("RoleID")),
                                reader.GetString(reader.GetOrdinal("RoleName")),
                                reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedAt"))
                            ));
                        }
                    }
                }
            }

            return usersList;
        }


        // =========================================
        // 2. Get User By ID
        // =========================================

        public static UserDTO? GetUserById(int userID)
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_GetUserById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@UserID", SqlDbType.Int)
                        .Value = userID;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new UserDTO(
                                reader.GetInt32(reader.GetOrdinal("UserID")),
                                reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                reader.GetString(reader.GetOrdinal("EmployeeCode")),
                                reader.GetString(reader.GetOrdinal("FullName")),
                                reader.GetString(reader.GetOrdinal("Username")),
                                reader.GetInt32(reader.GetOrdinal("RoleID")),
                                reader.GetString(reader.GetOrdinal("RoleName")),
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
        // 3. Get User By Username
        // =========================================

        public static UserLoginDTO? GetUserByUsername(string username)
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_GetUserByUsername", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@Username", SqlDbType.NVarChar, 100)
                        .Value = username;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new UserLoginDTO(
                                reader.GetInt32(reader.GetOrdinal("UserID")),
                                reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                reader.GetString(reader.GetOrdinal("Username")),
                                reader.GetString(reader.GetOrdinal("PasswordHash")),
                                reader.GetInt32(reader.GetOrdinal("RoleID")),
                                reader.GetString(reader.GetOrdinal("RoleName")),
                                reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                reader.GetString(reader.GetOrdinal("FullName")),
                                reader.GetBoolean(reader.GetOrdinal("EmployeeIsActive"))
                            );
                        }
                    }
                }
            }

            return null;
        }


        // =========================================
        // 4. Add User
        // =========================================

        public static int AddUser(
            int employeeID,
            string username,
            string passwordHash,
            int roleID)
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_AddUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@EmployeeID", SqlDbType.Int)
                        .Value = employeeID;

                    command.Parameters.Add("@Username", SqlDbType.NVarChar, 100)
                        .Value = username;

                    command.Parameters.Add("@PasswordHash", SqlDbType.NVarChar, 255)
                        .Value = passwordHash;

                    command.Parameters.Add("@RoleID", SqlDbType.Int)
                        .Value = roleID;

                    SqlParameter outputID = new SqlParameter(
                        "@NewUserID", SqlDbType.Int)
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
        // 5. Update User
        // =========================================

        public static bool UpdateUser(
            int userID,
            string username,
            string? passwordHash,
            int roleID)
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_UpdateUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@UserID", SqlDbType.Int)
                        .Value = userID;

                    command.Parameters.Add("@Username", SqlDbType.NVarChar, 100)
                        .Value = username;

                    command.Parameters.Add("@PasswordHash", SqlDbType.NVarChar, 255)
                        .Value = (object?)passwordHash ?? DBNull.Value;

                    command.Parameters.Add("@RoleID", SqlDbType.Int)
                        .Value = roleID;

                    connection.Open();

                    int rowsAffected = Convert.ToInt32(command.ExecuteScalar());

                    return rowsAffected == 1;
                }
            }
        }


        // =========================================
        // 6. Set User Active Status
        // =========================================

        public static bool SetUserActiveStatus(int userID, bool isActive)
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_SetUserActiveStatus", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@UserID", SqlDbType.Int)
                        .Value = userID;

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