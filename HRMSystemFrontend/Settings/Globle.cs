using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystemFrontend.Settings
{
    public static class Globle
    {
        public static readonly HttpClient httpClient = new HttpClient();

        private static readonly string PATH_URL = "http://localhost:5268/api/";


    }
}
