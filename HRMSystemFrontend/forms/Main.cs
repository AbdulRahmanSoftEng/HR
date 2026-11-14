using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HRMSystemFrontend.DTOs;
using HRMSystemFrontend.Settings;
using System.Configuration;
using System.Net.Http.Json;

namespace HRMSystemFrontend.forms
{
    public partial class Main : Form
    {
        private readonly string Obj = "Users/";
        private string Url = string.Empty;

        public Main()
        {
            InitializeComponent();
            Init();
        }

        private async Task Init()
        {
            Url = ConfigurationManager.AppSettings["Url"] + Obj;

            Globle.httpClient.BaseAddress = new Uri(Url);

            await GetAllUsers();
        }

        private async Task GetAllUsers()
        {
            try
            {
                var response = await Globle.httpClient.GetAsync("All");

                if (response.IsSuccessStatusCode)
                {
                    List<FullUserDTO>? users = await response.Content.ReadFromJsonAsync<List<FullUserDTO>>();
                    if (users != null)
                    {
                        dataGridView1.DataSource = users;
                    }
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)

                {
                    MessageBox.Show("Not Found users");

                }
            }
            catch (Exception ex)
            {
                // implements error hier;
            }
            ;
        }
    }
}
