
namespace Exams_Management_System
{
    partial class Send_Notification_Form
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
            this.Notification = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.whatsAppBox = new System.Windows.Forms.CheckBox();
            this.SMSBox = new System.Windows.Forms.CheckBox();
            this.emailBox = new System.Windows.Forms.CheckBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Location = new System.Drawing.Point(753, 0);
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
            this.btnMinimize.Location = new System.Drawing.Point(730, 0);
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
            this.btnExit.Location = new System.Drawing.Point(775, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 29);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Notification
            // 
            this.Notification.Location = new System.Drawing.Point(249, 32);
            this.Notification.Name = "Notification";
            this.Notification.Size = new System.Drawing.Size(327, 251);
            this.Notification.TabIndex = 6;
            this.Notification.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter your message";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.whatsAppBox);
            this.groupBox1.Controls.Add(this.SMSBox);
            this.groupBox1.Controls.Add(this.emailBox);
            this.groupBox1.Location = new System.Drawing.Point(283, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 125);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose the type of notification";
            // 
            // whatsAppBox
            // 
            this.whatsAppBox.AutoSize = true;
            this.whatsAppBox.Location = new System.Drawing.Point(6, 80);
            this.whatsAppBox.Name = "whatsAppBox";
            this.whatsAppBox.Size = new System.Drawing.Size(100, 24);
            this.whatsAppBox.TabIndex = 2;
            this.whatsAppBox.Text = "WhatsApp";
            this.whatsAppBox.UseVisualStyleBackColor = true;
            // 
            // SMSBox
            // 
            this.SMSBox.AutoSize = true;
            this.SMSBox.Location = new System.Drawing.Point(6, 50);
            this.SMSBox.Name = "SMSBox";
            this.SMSBox.Size = new System.Drawing.Size(60, 24);
            this.SMSBox.TabIndex = 1;
            this.SMSBox.Text = "SMS";
            this.SMSBox.UseVisualStyleBackColor = true;
            // 
            // emailBox
            // 
            this.emailBox.AutoSize = true;
            this.emailBox.Location = new System.Drawing.Point(6, 26);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(68, 24);
            this.emailBox.TabIndex = 0;
            this.emailBox.Text = "Email";
            this.emailBox.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(340, 440);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 29);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 34;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Send_Notification_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Notification);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Name = "Send_Notification_Form";
            this.Text = "Send_Notification_Form";
            this.Load += new System.EventHandler(this.Send_Notification_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox Notification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox whatsAppBox;
        private System.Windows.Forms.CheckBox SMSBox;
        private System.Windows.Forms.CheckBox emailBox;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button button1;
    }
}