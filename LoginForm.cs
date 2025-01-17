﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamperBookingSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Classes.User oUser = new Classes.User();
            oUser = Classes.User.Find(txtUserName.Text);

            if (oUser != null && oUser.username == txtUserName.Text)
            {
                UserMenu userMenu = new UserMenu();
                this.Hide();
                userMenu.Show();
            }
            else
            {
                MessageBox.Show("Wrong!");
            }
        }

    }
}
