using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HRMSystemFrontend.Settings
{
   
    public static class Globle
    {
        public static readonly HttpClient httpClient =
            new HttpClient
            {
                BaseAddress = new Uri(
                    ConfigurationManager.AppSettings["Url"]?? "http://localhost:5223/api/"
                ),

                Timeout = TimeSpan.FromSeconds(30)
            };
    }
    
}
