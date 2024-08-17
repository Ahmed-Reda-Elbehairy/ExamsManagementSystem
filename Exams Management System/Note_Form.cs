using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exams_Management_System
{
    public partial class Note_Form : Form
    {
        private string name;

        public string Name1 { get => name; set => name = value; }

        public Note_Form()
        {
            InitializeComponent();
        }

        private void Note_Form_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {

            School.writeData();
            Application.Exit();
        }

        private void btnMaximize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Note theNote = new Note(note.Text, Name1);
            School.Notes1.Add(theNote);
            MessageBox.Show("Sent Successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student_Form obj = new Student_Form();
            this.Hide();
            obj.Show();
        }
    }
}
