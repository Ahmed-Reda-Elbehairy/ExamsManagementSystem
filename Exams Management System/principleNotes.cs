using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exams_Management_System
{
    public partial class principleNotes : Form
    {
        public principleNotes()
        {
            InitializeComponent();
        }

        private void principleNotes_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            foreach (var val in School.Notes1)
            {
                notesDataGridView.Rows.Add(val.Msg, val.Student);
            }

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            PrincipleForm obj = new PrincipleForm();
            this.Hide();
            obj.Show();
        }
    }
}
