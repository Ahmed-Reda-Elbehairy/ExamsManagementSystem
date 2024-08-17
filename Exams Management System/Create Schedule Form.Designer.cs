
namespace Exams_Management_System
{
    partial class Create_Schedule_Form
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
            this.createTableDataGridView = new System.Windows.Forms.DataGridView();
            this.theDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Second = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Third = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.extBtn = new System.Windows.Forms.Button();
            this.Level = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.createTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // createTableDataGridView
            // 
            this.createTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.createTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.theDays,
            this.First,
            this.Second,
            this.Third,
            this.Forth});
            this.createTableDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.createTableDataGridView.Location = new System.Drawing.Point(0, 0);
            this.createTableDataGridView.Name = "createTableDataGridView";
            this.createTableDataGridView.RowHeadersWidth = 51;
            this.createTableDataGridView.RowTemplate.Height = 29;
            this.createTableDataGridView.Size = new System.Drawing.Size(927, 564);
            this.createTableDataGridView.TabIndex = 0;
            this.createTableDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.createTableDataGridView_CellContentClick);
            // 
            // theDays
            // 
            this.theDays.HeaderText = "Days";
            this.theDays.MinimumWidth = 6;
            this.theDays.Name = "theDays";
            this.theDays.Width = 125;
            // 
            // First
            // 
            this.First.HeaderText = "8:00-10:00";
            this.First.MinimumWidth = 6;
            this.First.Name = "First";
            this.First.Width = 125;
            // 
            // Second
            // 
            this.Second.HeaderText = "10:00-12:00";
            this.Second.MinimumWidth = 6;
            this.Second.Name = "Second";
            this.Second.Width = 125;
            // 
            // Third
            // 
            this.Third.HeaderText = "12:00-2:00";
            this.Third.MinimumWidth = 6;
            this.Third.Name = "Third";
            this.Third.Width = 125;
            // 
            // Forth
            // 
            this.Forth.HeaderText = "2:00-4:00";
            this.Forth.MinimumWidth = 6;
            this.Forth.Name = "Forth";
            this.Forth.Width = 125;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(927, 497);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(52, 29);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Location = new System.Drawing.Point(971, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(15, 25);
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.Text = "Minimize";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Location = new System.Drawing.Point(986, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(15, 25);
            this.btnMaximize.TabIndex = 10;
            this.btnMaximize.Text = "Maximize";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // extBtn
            // 
            this.extBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.extBtn.Location = new System.Drawing.Point(1001, 3);
            this.extBtn.Name = "extBtn";
            this.extBtn.Size = new System.Drawing.Size(15, 25);
            this.extBtn.TabIndex = 9;
            this.extBtn.Text = "Exit";
            this.extBtn.UseVisualStyleBackColor = true;
            this.extBtn.Click += new System.EventHandler(this.extBtn_Click);
            // 
            // Level
            // 
            this.Level.Location = new System.Drawing.Point(967, 56);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(39, 27);
            this.Level.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(927, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Level";
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(933, 98);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(83, 29);
            this.btnCreateTable.TabIndex = 15;
            this.btnCreateTable.Text = "Create";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // Create_Schedule_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 564);
            this.Controls.Add(this.btnCreateTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.extBtn);
            this.Controls.Add(this.createTableDataGridView);
            this.Name = "Create_Schedule_Form";
            this.Text = "Create_Schedule_Form";
            this.Load += new System.EventHandler(this.Create_Schedule_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.createTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView createTableDataGridView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button extBtn;
        private System.Windows.Forms.TextBox Level;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn theDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn First;
        private System.Windows.Forms.DataGridViewTextBoxColumn Second;
        private System.Windows.Forms.DataGridViewTextBoxColumn Third;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forth;
        private System.Windows.Forms.Button btnCreateTable;
    }
}