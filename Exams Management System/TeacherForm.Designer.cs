
namespace Exams_Management_System
{
    partial class TeacherForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreateExam = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Month = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Course = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.TextBox();
            this.btnAddExam = new System.Windows.Forms.Button();
            this.btnEditExam = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewExam = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.courseEdit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.levelEdit = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.courseDelete = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.levelDelete = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnDeleteExam = new System.Windows.Forms.Button();
            this.btnViewGrades = new System.Windows.Forms.Button();
            this.btnCreateReport = new System.Windows.Forms.Button();
            this.btnCreateAssignment = new System.Windows.Forms.Button();
            this.btnSendNotification = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(1016, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 29);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Location = new System.Drawing.Point(971, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 29);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "M";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Location = new System.Drawing.Point(994, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(25, 29);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.Text = "M";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreateExam);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Month);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Day);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Course);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.typeComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Level);
            this.panel1.Location = new System.Drawing.Point(178, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 449);
            this.panel1.TabIndex = 3;
            // 
            // btnCreateExam
            // 
            this.btnCreateExam.Location = new System.Drawing.Point(98, 371);
            this.btnCreateExam.Name = "btnCreateExam";
            this.btnCreateExam.Size = new System.Drawing.Size(94, 29);
            this.btnCreateExam.TabIndex = 10;
            this.btnCreateExam.Text = "Add";
            this.btnCreateExam.UseVisualStyleBackColor = true;
            this.btnCreateExam.Click += new System.EventHandler(this.btnCreateExam_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Month";
            // 
            // Month
            // 
            this.Month.Location = new System.Drawing.Point(185, 173);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(38, 27);
            this.Month.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Day";
            // 
            // Day
            // 
            this.Day.Location = new System.Drawing.Point(83, 172);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(38, 27);
            this.Day.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Course";
            // 
            // Course
            // 
            this.Course.Location = new System.Drawing.Point(98, 106);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(125, 27);
            this.Course.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "monthly",
            "weekly",
            "final"});
            this.typeComboBox.Location = new System.Drawing.Point(98, 261);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(125, 28);
            this.typeComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Level";
            // 
            // Level
            // 
            this.Level.Location = new System.Drawing.Point(98, 32);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(125, 27);
            this.Level.TabIndex = 0;
            // 
            // btnAddExam
            // 
            this.btnAddExam.Location = new System.Drawing.Point(44, 30);
            this.btnAddExam.Name = "btnAddExam";
            this.btnAddExam.Size = new System.Drawing.Size(108, 29);
            this.btnAddExam.TabIndex = 4;
            this.btnAddExam.Text = "Add Exam";
            this.btnAddExam.UseVisualStyleBackColor = true;
            this.btnAddExam.Click += new System.EventHandler(this.btnAddExam_Click);
            // 
            // btnEditExam
            // 
            this.btnEditExam.Location = new System.Drawing.Point(44, 87);
            this.btnEditExam.Name = "btnEditExam";
            this.btnEditExam.Size = new System.Drawing.Size(108, 29);
            this.btnEditExam.TabIndex = 5;
            this.btnEditExam.Text = "Edit Exam";
            this.btnEditExam.UseVisualStyleBackColor = true;
            this.btnEditExam.Click += new System.EventHandler(this.btnEditExam_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.viewExam);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.courseEdit);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.levelEdit);
            this.panel2.Location = new System.Drawing.Point(451, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 232);
            this.panel2.TabIndex = 6;
            // 
            // viewExam
            // 
            this.viewExam.Location = new System.Drawing.Point(103, 186);
            this.viewExam.Name = "viewExam";
            this.viewExam.Size = new System.Drawing.Size(94, 29);
            this.viewExam.TabIndex = 12;
            this.viewExam.Text = "View Exam";
            this.viewExam.UseVisualStyleBackColor = true;
            this.viewExam.Click += new System.EventHandler(this.viewExam_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Course";
            // 
            // courseEdit
            // 
            this.courseEdit.Location = new System.Drawing.Point(88, 131);
            this.courseEdit.Name = "courseEdit";
            this.courseEdit.Size = new System.Drawing.Size(125, 27);
            this.courseEdit.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Level";
            // 
            // levelEdit
            // 
            this.levelEdit.Location = new System.Drawing.Point(88, 32);
            this.levelEdit.Name = "levelEdit";
            this.levelEdit.Size = new System.Drawing.Size(125, 27);
            this.levelEdit.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.courseDelete);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.levelDelete);
            this.panel3.Location = new System.Drawing.Point(734, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 232);
            this.panel3.TabIndex = 13;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(103, 186);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Course";
            // 
            // courseDelete
            // 
            this.courseDelete.Location = new System.Drawing.Point(88, 131);
            this.courseDelete.Name = "courseDelete";
            this.courseDelete.Size = new System.Drawing.Size(125, 27);
            this.courseDelete.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Level";
            // 
            // levelDelete
            // 
            this.levelDelete.Location = new System.Drawing.Point(88, 32);
            this.levelDelete.Name = "levelDelete";
            this.levelDelete.Size = new System.Drawing.Size(125, 27);
            this.levelDelete.TabIndex = 0;
            // 
            // btnDeleteExam
            // 
            this.btnDeleteExam.Location = new System.Drawing.Point(44, 138);
            this.btnDeleteExam.Name = "btnDeleteExam";
            this.btnDeleteExam.Size = new System.Drawing.Size(108, 29);
            this.btnDeleteExam.TabIndex = 14;
            this.btnDeleteExam.Text = "Delete Exam";
            this.btnDeleteExam.UseVisualStyleBackColor = true;
            this.btnDeleteExam.Click += new System.EventHandler(this.btnDeleteExam_Click);
            // 
            // btnViewGrades
            // 
            this.btnViewGrades.Location = new System.Drawing.Point(44, 189);
            this.btnViewGrades.Name = "btnViewGrades";
            this.btnViewGrades.Size = new System.Drawing.Size(108, 29);
            this.btnViewGrades.TabIndex = 15;
            this.btnViewGrades.Text = "View Grades";
            this.btnViewGrades.UseVisualStyleBackColor = true;
            this.btnViewGrades.Click += new System.EventHandler(this.btnViewGrades_Click);
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Location = new System.Drawing.Point(44, 240);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(108, 29);
            this.btnCreateReport.TabIndex = 16;
            this.btnCreateReport.Text = "Issue Report";
            this.btnCreateReport.UseVisualStyleBackColor = true;
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            // 
            // btnCreateAssignment
            // 
            this.btnCreateAssignment.Location = new System.Drawing.Point(20, 292);
            this.btnCreateAssignment.Name = "btnCreateAssignment";
            this.btnCreateAssignment.Size = new System.Drawing.Size(152, 29);
            this.btnCreateAssignment.TabIndex = 17;
            this.btnCreateAssignment.Text = "Create Assignment";
            this.btnCreateAssignment.UseVisualStyleBackColor = true;
            this.btnCreateAssignment.Click += new System.EventHandler(this.btnCreateAssignment_Click);
            // 
            // btnSendNotification
            // 
            this.btnSendNotification.Location = new System.Drawing.Point(20, 336);
            this.btnSendNotification.Name = "btnSendNotification";
            this.btnSendNotification.Size = new System.Drawing.Size(152, 29);
            this.btnSendNotification.TabIndex = 18;
            this.btnSendNotification.Text = "Send Notification";
            this.btnSendNotification.UseVisualStyleBackColor = true;
            this.btnSendNotification.Click += new System.EventHandler(this.btnSendNotification_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 450);
            this.Controls.Add(this.btnSendNotification);
            this.Controls.Add(this.btnCreateAssignment);
            this.Controls.Add(this.btnCreateReport);
            this.Controls.Add(this.btnViewGrades);
            this.Controls.Add(this.btnDeleteExam);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnEditExam);
            this.Controls.Add(this.btnAddExam);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddExam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Level;
        private System.Windows.Forms.Button btnCreateExam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Month;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Day;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Course;
        private System.Windows.Forms.Button btnEditExam;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox courseEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox levelEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button viewExam;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox courseDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox levelDelete;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnDeleteExam;
        private System.Windows.Forms.Button btnViewGrades;
        private System.Windows.Forms.Button btnCreateReport;
        private System.Windows.Forms.Button btnCreateAssignment;
        private System.Windows.Forms.Button btnSendNotification;
    }
}