
namespace SalonProject.UI
{
    partial class CreateServiceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.servicePriceTB = new System.Windows.Forms.TextBox();
            this.serviceNameTB = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.oldNameTB = new System.Windows.Forms.TextBox();
            this.oldPriceTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Service Price :";
            // 
            // servicePriceTB
            // 
            this.servicePriceTB.Location = new System.Drawing.Point(174, 159);
            this.servicePriceTB.Name = "servicePriceTB";
            this.servicePriceTB.Size = new System.Drawing.Size(100, 22);
            this.servicePriceTB.TabIndex = 2;
            // 
            // serviceNameTB
            // 
            this.serviceNameTB.Location = new System.Drawing.Point(174, 77);
            this.serviceNameTB.Name = "serviceNameTB";
            this.serviceNameTB.Size = new System.Drawing.Size(100, 22);
            this.serviceNameTB.TabIndex = 3;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(3, 381);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(113, 57);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(144, 381);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(120, 57);
            this.createBtn.TabIndex = 5;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(285, 381);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(136, 57);
            this.updateBtn.TabIndex = 6;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(454, 381);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(147, 57);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(636, 381);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(152, 57);
            this.logoutBtn.TabIndex = 8;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // oldNameTB
            // 
            this.oldNameTB.Location = new System.Drawing.Point(574, 77);
            this.oldNameTB.Name = "oldNameTB";
            this.oldNameTB.Size = new System.Drawing.Size(100, 22);
            this.oldNameTB.TabIndex = 9;
            // 
            // oldPriceTB
            // 
            this.oldPriceTB.Location = new System.Drawing.Point(574, 159);
            this.oldPriceTB.Name = "oldPriceTB";
            this.oldPriceTB.Size = new System.Drawing.Size(100, 22);
            this.oldPriceTB.TabIndex = 10;
            this.oldPriceTB.TextChanged += new System.EventHandler(this.oldPriceTB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Old Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "OldPrice :";
            // 
            // CreateServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oldPriceTB);
            this.Controls.Add(this.oldNameTB);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.serviceNameTB);
            this.Controls.Add(this.servicePriceTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateServiceForm";
            this.Text = "CreateService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox servicePriceTB;
        private System.Windows.Forms.TextBox serviceNameTB;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.TextBox oldNameTB;
        private System.Windows.Forms.TextBox oldPriceTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}