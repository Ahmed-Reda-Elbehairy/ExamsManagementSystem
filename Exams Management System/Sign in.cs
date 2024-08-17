using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Exams_Management_System;

namespace Exams_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            School.readData();
            this.ControlBox = false;
        }

        private void SignIN_Click(object sender, EventArgs e)
        {

            facadeSignIn signInObject = new facadeSignIn();
            
            signInObject.goToForm(userName.Text, Password.Text);
            if (signInObject.Found == false)
            {
                MessageBox.Show("Invalid User!");
            }
            else
            {
                this.Hide();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            School.writeData();
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
