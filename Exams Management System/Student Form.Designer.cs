
namespace Exams_Management_System
{
    partial class Student_Form
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
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowExams = new System.Windows.Forms.Button();
            this.examsDataGridView = new System.Windows.Forms.DataGridView();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradesDataGridView = new System.Windows.Forms.DataGridView();
            this.The_Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.the_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.the_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowGrades = new System.Windows.Forms.Button();
            this.btnWriteNote = new System.Windows.Forms.Button();
            this.assignmentDataGridView = new System.Windows.Forms.DataGridView();
            this.course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowAssignments = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.examsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Location = new System.Drawing.Point(1006, 1);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(25, 29);
            this.btnMaximize.TabIndex = 5;
            this.btnMaximize.Text = "M";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Location = new System.Drawing.Point(983, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 29);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "M";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(1028, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 29);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowExams
            // 
            this.btnShowExams.Location = new System.Drawing.Point(12, 12);
            this.btnShowExams.Name = "btnShowExams";
            this.btnShowExams.Size = new System.Drawing.Size(131, 29);
            this.btnShowExams.TabIndex = 6;
            this.btnShowExams.Text = "Show Exams";
            this.btnShowExams.UseVisualStyleBackColor = true;
            this.btnShowExams.Click += new System.EventHandler(this.btnShowExams_Click);
            // 
            // examsDataGridView
            // 
            this.examsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subject,
            this.type,
            this.date});
            this.examsDataGridView.Location = new System.Drawing.Point(149, 1);
            this.examsDataGridView.Name = "examsDataGridView";
            this.examsDataGridView.RowHeadersWidth = 51;
            this.examsDataGridView.RowTemplate.Height = 29;
            this.examsDataGridView.Size = new System.Drawing.Size(429, 444);
            this.examsDataGridView.TabIndex = 7;
            // 
            // subject
            // 
            this.subject.HeaderText = "Subject";
            this.subject.MinimumWidth = 6;
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            this.subject.Width = 125;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 125;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 125;
            // 
            // gradesDataGridView
            // 
            this.gradesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.The_Grade,
            this.the_Type,
            this.the_Date});
            this.gradesDataGridView.Location = new System.Drawing.Point(412, 0);
            this.gradesDataGridView.Name = "gradesDataGridView";
            this.gradesDataGridView.RowHeadersWidth = 51;
            this.gradesDataGridView.RowTemplate.Height = 29;
            this.gradesDataGridView.Size = new System.Drawing.Size(568, 444);
            this.gradesDataGridView.TabIndex = 8;
            // 
            // The_Grade
            // 
            this.The_Grade.HeaderText = "Grade";
            this.The_Grade.MinimumWidth = 6;
            this.The_Grade.Name = "The_Grade";
            this.The_Grade.ReadOnly = true;
            this.The_Grade.Width = 125;
            // 
            // the_Type
            // 
            this.the_Type.HeaderText = "Type";
            this.the_Type.MinimumWidth = 6;
            this.the_Type.Name = "the_Type";
            this.the_Type.ReadOnly = true;
            this.the_Type.Width = 125;
            // 
            // the_Date
            // 
            this.the_Date.HeaderText = "Date";
            this.the_Date.MinimumWidth = 6;
            this.the_Date.Name = "the_Date";
            this.the_Date.ReadOnly = true;
            this.the_Date.Width = 125;
            // 
            // btnShowGrades
            // 
            this.btnShowGrades.Location = new System.Drawing.Point(12, 187);
            this.btnShowGrades.Name = "btnShowGrades";
            this.btnShowGrades.Size = new System.Drawing.Size(131, 29);
            this.btnShowGrades.TabIndex = 9;
            this.btnShowGrades.Text = "Show Grades";
            this.btnShowGrades.UseVisualStyleBackColor = true;
            this.btnShowGrades.Click += new System.EventHandler(this.btnShowGrades_Click);
            // 
            // btnWriteNote
            // 
            this.btnWriteNote.Location = new System.Drawing.Point(12, 362);
            this.btnWriteNote.Name = "btnWriteNote";
            this.btnWriteNote.Size = new System.Drawing.Size(131, 29);
            this.btnWriteNote.TabIndex = 10;
            this.btnWriteNote.Text = "Write a note";
            this.btnWriteNote.UseVisualStyleBackColor = true;
            this.btnWriteNote.Click += new System.EventHandler(this.btnWriteNote_Click);
            // 
            // assignmentDataGridView
            // 
            this.assignmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.course,
            this.marks});
            this.assignmentDataGridView.Location = new System.Drawing.Point(298, 170);
            this.assignmentDataGridView.Name = "assignmentDataGridView";
            this.assignmentDataGridView.RowHeadersWidth = 51;
            this.assignmentDataGridView.RowTemplate.Height = 29;
            this.assignmentDataGridView.Size = new System.Drawing.Size(522, 355);
            this.assignmentDataGridView.TabIndex = 11;
            // 
            // course
            // 
            this.course.HeaderText = "Course";
            this.course.MinimumWidth = 6;
            this.course.Name = "course";
            this.course.ReadOnly = true;
            this.course.Width = 125;
            // 
            // marks
            // 
            this.marks.HeaderText = "Marks";
            this.marks.MinimumWidth = 6;
            this.marks.Name = "marks";
            this.marks.ReadOnly = true;
            this.marks.Width = 125;
            // 
            // btnShowAssignments
            // 
            this.btnShowAssignments.Location = new System.Drawing.Point(12, 476);
            this.btnShowAssignments.Name = "btnShowAssignments";
            this.btnShowAssignments.Size = new System.Drawing.Size(162, 29);
            this.btnShowAssignments.TabIndex = 12;
            this.btnShowAssignments.Text = "Show Assignments";
            this.btnShowAssignments.UseVisualStyleBackColor = true;
            this.btnShowAssignments.Click += new System.EventHandler(this.btnShowAssignments_Click);
            // 
            // Student_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 562);
            this.Controls.Add(this.btnShowAssignments);
            this.Controls.Add(this.assignmentDataGridView);
            this.Controls.Add(this.btnWriteNote);
            this.Controls.Add(this.btnShowGrades);
            this.Controls.Add(this.gradesDataGridView);
            this.Controls.Add(this.examsDataGridView);
            this.Controls.Add(this.btnShowExams);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Name = "Student_Form";
            this.Text = "Student_Form";
            this.Load += new System.EventHandler(this.Student_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShowExams;
        private System.Windows.Forms.DataGridView examsDataGridView;
        private System.Windows.Forms.DataGridView gradesDataGridView;
        private System.Windows.Forms.Button btnShowGrades;
        private System.Windows.Forms.Button btnWriteNote;
        private System.Windows.Forms.DataGridView assignmentDataGridView;
        private System.Windows.Forms.Button btnShowAssignments;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn The_Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn the_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn the_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn course;
        private System.Windows.Forms.DataGridViewTextBoxColumn marks;
    }
}