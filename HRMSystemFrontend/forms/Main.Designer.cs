using HRMSystemFrontend.Properties;

namespace HRMSystemFrontend.forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStripMain = new MenuStrip();
            dashboarToolStripMenuItem = new ToolStripMenuItem();
            manageDashbordToolStripMenuItem = new ToolStripMenuItem();
            attendancesToolStripMenuItem = new ToolStripMenuItem();
            attendancesToolStripMenuItem1 = new ToolStripMenuItem();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            manageEmployeesToolStripMenuItem = new ToolStripMenuItem();
            departmentsToolStripMenuItem = new ToolStripMenuItem();
            manageDepartmentsToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            userManagementsToolStripMenuItem = new ToolStripMenuItem();
            rolePermissionsToolStripMenuItem = new ToolStripMenuItem();
            manageRolesAndPermissionsToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            managePermissionsToolStripMenuItem = new ToolStripMenuItem();
            menuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.ImageScalingSize = new Size(20, 20);
            menuStripMain.Items.AddRange(new ToolStripItem[] { dashboarToolStripMenuItem, attendancesToolStripMenuItem, employeesToolStripMenuItem, departmentsToolStripMenuItem, usersToolStripMenuItem, rolePermissionsToolStripMenuItem, settingsToolStripMenuItem });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(1668, 28);
            menuStripMain.TabIndex = 1;
            menuStripMain.Text = "menuStrip1";
            // 
            // dashboarToolStripMenuItem
            // 
            dashboarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageDashbordToolStripMenuItem });
            dashboarToolStripMenuItem.Name = "dashboarToolStripMenuItem";
            dashboarToolStripMenuItem.Size = new Size(87, 24);
            dashboarToolStripMenuItem.Text = "Dashboar";
            // 
            // manageDashbordToolStripMenuItem
            // 
            manageDashbordToolStripMenuItem.Name = "manageDashbordToolStripMenuItem";
            manageDashbordToolStripMenuItem.Size = new Size(213, 26);
            manageDashbordToolStripMenuItem.Text = "manage dashbord";
            manageDashbordToolStripMenuItem.Click += manageDashbordToolStripMenuItem_Click;
            // 
            // attendancesToolStripMenuItem
            // 
            attendancesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { attendancesToolStripMenuItem1 });
            attendancesToolStripMenuItem.Name = "attendancesToolStripMenuItem";
            attendancesToolStripMenuItem.Size = new Size(105, 24);
            attendancesToolStripMenuItem.Text = "Attendances";
            // 
            // attendancesToolStripMenuItem1
            // 
            attendancesToolStripMenuItem1.Name = "attendancesToolStripMenuItem1";
            attendancesToolStripMenuItem1.Size = new Size(230, 26);
            attendancesToolStripMenuItem1.Text = "manage attendances";
            attendancesToolStripMenuItem1.Click += attendancesToolStripMenuItem_Click;
            // 
            // employeesToolStripMenuItem
            // 
            employeesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageEmployeesToolStripMenuItem });
            employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            employeesToolStripMenuItem.Size = new Size(95, 24);
            employeesToolStripMenuItem.Text = "Employees";
            // 
            // manageEmployeesToolStripMenuItem
            // 
            manageEmployeesToolStripMenuItem.Name = "manageEmployeesToolStripMenuItem";
            manageEmployeesToolStripMenuItem.Size = new Size(222, 26);
            manageEmployeesToolStripMenuItem.Text = "manage employees";
            manageEmployeesToolStripMenuItem.Click += manageEmployeesToolStripMenuItem_Click;
            // 
            // departmentsToolStripMenuItem
            // 
            departmentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageDepartmentsToolStripMenuItem });
            departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            departmentsToolStripMenuItem.Size = new Size(109, 24);
            departmentsToolStripMenuItem.Text = "Departments";
            // 
            // manageDepartmentsToolStripMenuItem
            // 
            manageDepartmentsToolStripMenuItem.Name = "manageDepartmentsToolStripMenuItem";
            manageDepartmentsToolStripMenuItem.Size = new Size(234, 26);
            manageDepartmentsToolStripMenuItem.Text = "manage departments";
            manageDepartmentsToolStripMenuItem.Click += manageDepartmentsToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userManagementsToolStripMenuItem });
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(58, 24);
            usersToolStripMenuItem.Text = "Users";
            // 
            // userManagementsToolStripMenuItem
            // 
            userManagementsToolStripMenuItem.Name = "userManagementsToolStripMenuItem";
            userManagementsToolStripMenuItem.Size = new Size(183, 26);
            userManagementsToolStripMenuItem.Text = "manage users";
            userManagementsToolStripMenuItem.Click += userManagementsToolStripMenuItem_Click;
            // 
            // rolePermissionsToolStripMenuItem
            // 
            rolePermissionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageRolesAndPermissionsToolStripMenuItem });
            rolePermissionsToolStripMenuItem.Name = "rolePermissionsToolStripMenuItem";
            rolePermissionsToolStripMenuItem.Size = new Size(59, 24);
            rolePermissionsToolStripMenuItem.Text = "Roles";
            // 
            // manageRolesAndPermissionsToolStripMenuItem
            // 
            manageRolesAndPermissionsToolStripMenuItem.Name = "manageRolesAndPermissionsToolStripMenuItem";
            manageRolesAndPermissionsToolStripMenuItem.Size = new Size(224, 26);
            manageRolesAndPermissionsToolStripMenuItem.Text = "manage roles";
            manageRolesAndPermissionsToolStripMenuItem.Click += manageRolesAndPermissionsToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { managePermissionsToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(99, 24);
            settingsToolStripMenuItem.Text = "Permissions";
            // 
            // managePermissionsToolStripMenuItem
            // 
            managePermissionsToolStripMenuItem.Name = "managePermissionsToolStripMenuItem";
            managePermissionsToolStripMenuItem.Size = new Size(228, 26);
            managePermissionsToolStripMenuItem.Text = "manage permissions";
            managePermissionsToolStripMenuItem.Click += managePermissionsToolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1668, 1054);
            Controls.Add(menuStripMain);
            Font = new Font("Tahoma", 10F);
            IsMdiContainer = true;
            MainMenuStrip = menuStripMain;
            Margin = new Padding(4);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += frmMain_Load;
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain;
        private ToolStripMenuItem dashboarToolStripMenuItem;
        private ToolStripMenuItem attendancesToolStripMenuItem;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem departmentsToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem userManagementsToolStripMenuItem;
        private ToolStripMenuItem rolePermissionsToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem attendancesToolStripMenuItem1;
        private ToolStripMenuItem manageDashbordToolStripMenuItem;
        private ToolStripMenuItem manageEmployeesToolStripMenuItem;
        private ToolStripMenuItem manageDepartmentsToolStripMenuItem;
        private ToolStripMenuItem manageRolesAndPermissionsToolStripMenuItem;
        private ToolStripMenuItem managePermissionsToolStripMenuItem;
    }
}