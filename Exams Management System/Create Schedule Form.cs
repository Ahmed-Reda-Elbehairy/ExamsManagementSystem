using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exams_Management_System
{
    public partial class Create_Schedule_Form : Form
    {
        public Create_Schedule_Form()
        {
            InitializeComponent();
        }

        private void Create_Schedule_Form_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday" };
            foreach (string day in daysOfWeek)
            {
                createTableDataGridView.Rows.Add(day);
            }

        }

        private void extBtn_Click(object sender, EventArgs e)
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

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            string level = Level.Text;

            List<KeyValuePair<string, string>> sunday = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, string>> monday = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, string>> tuesday = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, string>> wednesday = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, string>> thursday = new List<KeyValuePair<string, string>>();

            

            for (int i = 1; i < 5; i++) 
            {
                sunday.Add(new KeyValuePair<string, string>(
                    createTableDataGridView.Columns[i].HeaderText, 
                    createTableDataGridView.Rows[1].Cells[i].Value?.ToString() 
                ));

                monday.Add(new KeyValuePair<string, string>(
                    createTableDataGridView.Columns[i].HeaderText,
                    createTableDataGridView.Rows[2].Cells[i].Value?.ToString()
                ));

                tuesday.Add(new KeyValuePair<string, string>(
                    createTableDataGridView.Columns[i].HeaderText,
                    createTableDataGridView.Rows[3].Cells[i].Value?.ToString()
                ));

                wednesday.Add(new KeyValuePair<string, string>(
                    createTableDataGridView.Columns[i].HeaderText,
                    createTableDataGridView.Rows[4].Cells[i].Value?.ToString()
                ));

                thursday.Add(new KeyValuePair<string, string>(
                    createTableDataGridView.Columns[i].HeaderText,
                    createTableDataGridView.Rows[5].Cells[i].Value?.ToString()
                ));
            }

            TimeTable obj = new TimeTable(level, sunday, monday, tuesday, wednesday, thursday);
            School.TablesList.Add(obj);
            MessageBox.Show("Created Succefully");

        }

        private void createTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

