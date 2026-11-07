using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccess.Settings
{
    public static class DbSettings
    {
        // ضع Connection String هنا
        public static readonly string connection =
            @"Server=ABDULRAHMAN\MSSQLSERVER2022; 
            Database=HRManagementSystem;
            Integrated Security=true;
            TrustServerCertificate=True;
            Connection Timeout=30;";


    }
}