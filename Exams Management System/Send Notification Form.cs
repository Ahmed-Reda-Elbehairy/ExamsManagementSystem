using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exams_Management_System
{
    public partial class Send_Notification_Form : Form
    {
        public Send_Notification_Form()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
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

        private void Send_Notification_Form_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
        private List<string> GetSelectedOptionsFromGroupBox()
        {
            List<string> selectedOptions = new List<string>();

            foreach (Control control in groupBox1.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    selectedOptions.Add(checkBox.Text);
                }
            }

            return selectedOptions;
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = Notification.Text;
            List<string> options = GetSelectedOptionsFromGroupBox();
            notificationFactory factory = new notificationFactory();
            List<Notification> notificationsList = factory.createNotification(message, options);
            foreach (var val in notificationsList)
            {
                School.NotificationsList.Add(val);
            }
            MessageBox.Show("Sent Successfully");
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeacherForm obj = new TeacherForm();
            this.Hide();
            obj.Show();
        }
    }
}
