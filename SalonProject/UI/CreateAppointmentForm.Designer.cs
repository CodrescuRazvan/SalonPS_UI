
namespace SalonProject.UI
{
    partial class CreateAppointmentForm
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
            this.submitBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.dateTimeTB = new System.Windows.Forms.TextBox();
            this.clientNameTB = new System.Windows.Forms.TextBox();
            this.phoneNoTB = new System.Windows.Forms.TextBox();
            this.serviesTB = new System.Windows.Forms.TextBox();
            this.dateLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.phoneNumberLbl = new System.Windows.Forms.Label();
            this.servicesLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(319, 375);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(155, 48);
            this.submitBtn.TabIndex = 0;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(604, 375);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(156, 48);
            this.logoutBtn.TabIndex = 1;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // dateTimeTB
            // 
            this.dateTimeTB.Location = new System.Drawing.Point(353, 121);
            this.dateTimeTB.Name = "dateTimeTB";
            this.dateTimeTB.Size = new System.Drawing.Size(167, 22);
            this.dateTimeTB.TabIndex = 2;
            this.dateTimeTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // clientNameTB
            // 
            this.clientNameTB.Location = new System.Drawing.Point(353, 178);
            this.clientNameTB.Name = "clientNameTB";
            this.clientNameTB.Size = new System.Drawing.Size(167, 22);
            this.clientNameTB.TabIndex = 3;
            // 
            // phoneNoTB
            // 
            this.phoneNoTB.Location = new System.Drawing.Point(353, 235);
            this.phoneNoTB.Name = "phoneNoTB";
            this.phoneNoTB.Size = new System.Drawing.Size(167, 22);
            this.phoneNoTB.TabIndex = 4;
            // 
            // serviesTB
            // 
            this.serviesTB.Location = new System.Drawing.Point(353, 281);
            this.serviesTB.Name = "serviesTB";
            this.serviesTB.Size = new System.Drawing.Size(167, 22);
            this.serviesTB.TabIndex = 5;
            this.serviesTB.TextChanged += new System.EventHandler(this.serviesTB_TextChanged);
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(219, 126);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(89, 17);
            this.dateLbl.TabIndex = 6;
            this.dateLbl.Text = "Date & Hour : ";
            this.dateLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(219, 183);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(92, 17);
            this.nameLbl.TabIndex = 7;
            this.nameLbl.Text = "Client Name :";
            // 
            // phoneNumberLbl
            // 
            this.phoneNumberLbl.AutoSize = true;
            this.phoneNumberLbl.Location = new System.Drawing.Point(219, 240);
            this.phoneNumberLbl.Name = "phoneNumberLbl";
            this.phoneNumberLbl.Size = new System.Drawing.Size(115, 17);
            this.phoneNumberLbl.TabIndex = 8;
            this.phoneNumberLbl.Text = "Phone Number : ";
            // 
            // servicesLbl
            // 
            this.servicesLbl.AutoSize = true;
            this.servicesLbl.Location = new System.Drawing.Point(219, 286);
            this.servicesLbl.Name = "servicesLbl";
            this.servicesLbl.Size = new System.Drawing.Size(74, 17);
            this.servicesLbl.TabIndex = 9;
            this.servicesLbl.Text = "Services : ";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(12, 375);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(182, 48);
            this.backBtn.TabIndex = 10;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // CreateAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.servicesLbl);
            this.Controls.Add(this.phoneNumberLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.serviesTB);
            this.Controls.Add(this.phoneNoTB);
            this.Controls.Add(this.clientNameTB);
            this.Controls.Add(this.dateTimeTB);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.submitBtn);
            this.Name = "CreateAppointmentForm";
            this.Text = "CreateAppointmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.TextBox dateTimeTB;
        private System.Windows.Forms.TextBox clientNameTB;
        private System.Windows.Forms.TextBox phoneNoTB;
        private System.Windows.Forms.TextBox serviesTB;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label phoneNumberLbl;
        private System.Windows.Forms.Label servicesLbl;
        private System.Windows.Forms.Button backBtn;
    }
}