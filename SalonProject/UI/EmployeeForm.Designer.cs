
namespace SalonProject.UI
{
    partial class EmployeeForm
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
            this.createAppointmentBtn = new System.Windows.Forms.Button();
            this.viewAppointmentBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createAppointmentBtn
            // 
            this.createAppointmentBtn.Location = new System.Drawing.Point(272, 101);
            this.createAppointmentBtn.Name = "createAppointmentBtn";
            this.createAppointmentBtn.Size = new System.Drawing.Size(217, 56);
            this.createAppointmentBtn.TabIndex = 0;
            this.createAppointmentBtn.Text = "CreateAppointment";
            this.createAppointmentBtn.UseVisualStyleBackColor = true;
            this.createAppointmentBtn.Click += new System.EventHandler(this.createAppointmentBtn_Click);
            // 
            // viewAppointmentBtn
            // 
            this.viewAppointmentBtn.Location = new System.Drawing.Point(272, 229);
            this.viewAppointmentBtn.Name = "viewAppointmentBtn";
            this.viewAppointmentBtn.Size = new System.Drawing.Size(217, 62);
            this.viewAppointmentBtn.TabIndex = 1;
            this.viewAppointmentBtn.Text = "ViewAppointment";
            this.viewAppointmentBtn.UseVisualStyleBackColor = true;
            this.viewAppointmentBtn.Click += new System.EventHandler(this.viewAppointmentBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(602, 362);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(170, 58);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.viewAppointmentBtn);
            this.Controls.Add(this.createAppointmentBtn);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createAppointmentBtn;
        private System.Windows.Forms.Button viewAppointmentBtn;
        private System.Windows.Forms.Button logoutBtn;
    }
}