using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt;
namespace BuisnessLogic.Utilities
{
    public class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            // Implement your password hashing logic here
            // For example, you can use a hashing algorithm like bcrypt or SHA256
            // This is a placeholder implementation
            return BCrypt.Net.BCrypt.HashPassword(password, workFactor : 12).ToString();
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            // Implement your password verification logic here
            // This is a placeholder implementation
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
}
