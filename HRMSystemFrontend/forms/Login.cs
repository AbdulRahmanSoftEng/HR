using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using HRMSystemFrontend.Settings;
using System.Net.Http.Json;
using HRMSystemFrontend.DTOs;
namespace HRMSystemFrontend.forms
{
    public partial class Login : Form
    {
        private readonly string Obj = "Users/";
        private string Url = string.Empty;

        public Login()
        {
            InitializeComponent();
            Init();
        }

        private async Task Init()
        {
            Url = ConfigurationManager.AppSettings["Url"] + Obj;

            Globle.httpClient.BaseAddress = new Uri(Url);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            LoginByUsernameAndPassword(txtUsername.Text, txtPassword.Text);           
        }

        private async Task LoginByUsernameAndPassword(string username, string password)
        {
            // Implement your logic to check the username and password
            // For example, you can call an API or check against a database
            // Return true if valid, false otherwise
            try
            {
                var response = await Globle.httpClient.GetAsync($"Login/{username}/{password}");

                if(response.IsSuccessStatusCode)
                {
                    // Login successful
                    MessageBox.Show("Login successful!");
                    this.Hide();
                    Main mainForm = new Main();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    // Invalid credentials
                    MessageBox.Show("Invalid username or password.");
                }
                else
                {
                    // Other error
                    MessageBox.Show("An error occurred while trying to log in.");
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
    }
}
