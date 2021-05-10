
namespace SalonProject.UI
{
    partial class AdminForm
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
            this.createEmployeeBtn = new System.Windows.Forms.Button();
            this.createServiceBtn = new System.Windows.Forms.Button();
            this.viewClientAppointmentBtn = new System.Windows.Forms.Button();
            this.viewBetweenDatesBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.viewServiceBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createEmployeeBtn
            // 
            this.createEmployeeBtn.Location = new System.Drawing.Point(59, 60);
            this.createEmployeeBtn.Name = "createEmployeeBtn";
            this.createEmployeeBtn.Size = new System.Drawing.Size(158, 62);
            this.createEmployeeBtn.TabIndex = 0;
            this.createEmployeeBtn.Text = "Create Employee";
            this.createEmployeeBtn.UseVisualStyleBackColor = true;
            this.createEmployeeBtn.Click += new System.EventHandler(this.createEmployeeBtn_Click);
            // 
            // createServiceBtn
            // 
            this.createServiceBtn.Location = new System.Drawing.Point(59, 149);
            this.createServiceBtn.Name = "createServiceBtn";
            this.createServiceBtn.Size = new System.Drawing.Size(158, 59);
            this.createServiceBtn.TabIndex = 1;
            this.createServiceBtn.Text = "Manage Service";
            this.createServiceBtn.UseVisualStyleBackColor = true;
            this.createServiceBtn.Click += new System.EventHandler(this.createServiceBtn_Click);
            // 
            // viewClientAppointmentBtn
            // 
            this.viewClientAppointmentBtn.Location = new System.Drawing.Point(59, 237);
            this.viewClientAppointmentBtn.Name = "viewClientAppointmentBtn";
            this.viewClientAppointmentBtn.Size = new System.Drawing.Size(158, 67);
            this.viewClientAppointmentBtn.TabIndex = 2;
            this.viewClientAppointmentBtn.Text = "View Client Appointments";
            this.viewClientAppointmentBtn.UseVisualStyleBackColor = true;
            this.viewClientAppointmentBtn.Click += new System.EventHandler(this.viewClientAppointmentBtn_Click);
            // 
            // viewBetweenDatesBtn
            // 
            this.viewBetweenDatesBtn.Location = new System.Drawing.Point(260, 60);
            this.viewBetweenDatesBtn.Name = "viewBetweenDatesBtn";
            this.viewBetweenDatesBtn.Size = new System.Drawing.Size(166, 62);
            this.viewBetweenDatesBtn.TabIndex = 3;
            this.viewBetweenDatesBtn.Text = "View All Appointments";
            this.viewBetweenDatesBtn.UseVisualStyleBackColor = true;
            this.viewBetweenDatesBtn.Click += new System.EventHandler(this.viewBetweenDatesBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(618, 367);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(161, 59);
            this.logoutBtn.TabIndex = 6;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // viewServiceBtn
            // 
            this.viewServiceBtn.Location = new System.Drawing.Point(260, 149);
            this.viewServiceBtn.Name = "viewServiceBtn";
            this.viewServiceBtn.Size = new System.Drawing.Size(166, 59);
            this.viewServiceBtn.TabIndex = 7;
            this.viewServiceBtn.Text = "View All Services";
            this.viewServiceBtn.UseVisualStyleBackColor = true;
            this.viewServiceBtn.Click += new System.EventHandler(this.viewServiceBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewServiceBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.viewBetweenDatesBtn);
            this.Controls.Add(this.viewClientAppointmentBtn);
            this.Controls.Add(this.createServiceBtn);
            this.Controls.Add(this.createEmployeeBtn);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createEmployeeBtn;
        private System.Windows.Forms.Button createServiceBtn;
        private System.Windows.Forms.Button viewClientAppointmentBtn;
        private System.Windows.Forms.Button viewBetweenDatesBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button viewServiceBtn;
    }
}