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

        public static List<FullUserDTO> GetAllUsers()
        {
            var usersList = new List<FullUserDTO>();

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
                            usersList.Add(new FullUserDTO
                            {
                                UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                                EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                EmployeeCode = reader.GetString(reader.GetOrdinal("EmployeeCode")),
                                FullName = reader.GetString(reader.GetOrdinal("FullName")),
                                Username = reader.GetString(reader.GetOrdinal("Username")),
                                RoleID = reader.GetInt32(reader.GetOrdinal("RoleID")),
                                RoleName = reader.GetString(reader.GetOrdinal("RoleName")),
                                IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                CreatedAt = reader.GetDateTime(reader.GetOrdinal("CreatedAt"))
                                
                            });
                        }
                    }
                }
            }

            return usersList;
        }


        // =========================================
        // 2. Get Full User By ID
        // =========================================

        public static FullUserDTO? GetFullUserById(int userID)
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_GetFullUserById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@UserID", SqlDbType.Int)
                        .Value = userID;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new FullUserDTO
                            {
                                UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                                EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                EmployeeCode = reader.GetString(reader.GetOrdinal("EmployeeCode")),
                                FullName = reader.GetString(reader.GetOrdinal("FullName")),
                                Username = reader.GetString(reader.GetOrdinal("Username")),
                                RoleID = reader.GetInt32(reader.GetOrdinal("RoleID")),
                                RoleName = reader.GetString(reader.GetOrdinal("RoleName")),
                                IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                CreatedAt = reader.GetDateTime(reader.GetOrdinal("CreatedAt"))

                            };
                        }
                    }
                }
            }

            return null;
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
                            return new UserDTO
                            {
                                UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                                EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                Username = reader.GetString(reader.GetOrdinal("Username")),
                                RoleID = reader.GetInt32(reader.GetOrdinal("RoleID")),
                                IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                CreatedAt = reader.GetDateTime(reader.GetOrdinal("CreatedAt"))

                            };
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
                            return new UserLoginDTO
                            { 
                                UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                                EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                Username = reader.GetString(reader.GetOrdinal("Username")),
                                PasswordHash = reader.GetString(reader.GetOrdinal("PasswordHash")),
                                RoleID = reader.GetInt32(reader.GetOrdinal("RoleID")),
                                RoleName = reader.GetString(reader.GetOrdinal("RoleName")),
                                IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                FullName = reader.GetString(reader.GetOrdinal("FullName")),
                                EmployeeIsActive = reader.GetBoolean(reader.GetOrdinal("EmployeeIsActive"))
                            };
                        }
                    }
                }
            }

            return null;
        }


        // =========================================
        // 4. Add User
        // =========================================

        public static int AddUser(UserDTO user)
        {
            using (SqlConnection connection =
                   new SqlConnection(DbSettings.connection))
            {
                using (SqlCommand command =
                       new SqlCommand("SP_AddUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@EmployeeID", SqlDbType.Int)
                        .Value = user.EmployeeID;

                    command.Parameters.Add("@Username", SqlDbType.NVarChar, 100)
                        .Value = user.Username;

                    command.Parameters.Add("@PasswordHash", SqlDbType.NVarChar, 255)
                        .Value = user.Password;

                    command.Parameters.Add("@RoleID", SqlDbType.Int)
                        .Value = user.RoleID;

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