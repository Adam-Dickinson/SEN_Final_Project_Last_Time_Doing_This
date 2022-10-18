namespace SEN_381_Final_Project
{
    partial class fMainMenu
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
            this.btn_clientAndpolicyManagement = new System.Windows.Forms.Button();
            this.btn_productMaintenance = new System.Windows.Forms.Button();
            this.btn_medicalDepartment = new System.Windows.Forms.Button();
            this.btn_providerManagement = new System.Windows.Forms.Button();
            this.btn_callCenter = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_clientAndpolicyManagement
            // 
            this.btn_clientAndpolicyManagement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_clientAndpolicyManagement.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientAndpolicyManagement.Location = new System.Drawing.Point(57, 96);
            this.btn_clientAndpolicyManagement.Name = "btn_clientAndpolicyManagement";
            this.btn_clientAndpolicyManagement.Size = new System.Drawing.Size(229, 26);
            this.btn_clientAndpolicyManagement.TabIndex = 1;
            this.btn_clientAndpolicyManagement.Text = "Client And Policy Management";
            this.btn_clientAndpolicyManagement.UseVisualStyleBackColor = false;
            this.btn_clientAndpolicyManagement.Click += new System.EventHandler(this.btn_clientAndpolicyManagement_Click);
            // 
            // btn_productMaintenance
            // 
            this.btn_productMaintenance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_productMaintenance.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productMaintenance.Location = new System.Drawing.Point(81, 153);
            this.btn_productMaintenance.Name = "btn_productMaintenance";
            this.btn_productMaintenance.Size = new System.Drawing.Size(171, 26);
            this.btn_productMaintenance.TabIndex = 2;
            this.btn_productMaintenance.Text = "Product Maintenance";
            this.btn_productMaintenance.UseVisualStyleBackColor = false;
            this.btn_productMaintenance.Click += new System.EventHandler(this.btn_productMaintenance_Click);
            // 
            // btn_medicalDepartment
            // 
            this.btn_medicalDepartment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_medicalDepartment.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_medicalDepartment.Location = new System.Drawing.Point(86, 210);
            this.btn_medicalDepartment.Name = "btn_medicalDepartment";
            this.btn_medicalDepartment.Size = new System.Drawing.Size(160, 26);
            this.btn_medicalDepartment.TabIndex = 3;
            this.btn_medicalDepartment.Text = "Medical Department";
            this.btn_medicalDepartment.UseVisualStyleBackColor = false;
            this.btn_medicalDepartment.Click += new System.EventHandler(this.btn_medicalDepartment_Click);
            // 
            // btn_providerManagement
            // 
            this.btn_providerManagement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_providerManagement.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_providerManagement.Location = new System.Drawing.Point(81, 267);
            this.btn_providerManagement.Name = "btn_providerManagement";
            this.btn_providerManagement.Size = new System.Drawing.Size(176, 27);
            this.btn_providerManagement.TabIndex = 4;
            this.btn_providerManagement.Text = "Provider Management";
            this.btn_providerManagement.UseVisualStyleBackColor = false;
            this.btn_providerManagement.Click += new System.EventHandler(this.btn_providerManagement_Click);
            // 
            // btn_callCenter
            // 
            this.btn_callCenter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_callCenter.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_callCenter.Location = new System.Drawing.Point(110, 38);
            this.btn_callCenter.Name = "btn_callCenter";
            this.btn_callCenter.Size = new System.Drawing.Size(105, 26);
            this.btn_callCenter.TabIndex = 5;
            this.btn_callCenter.Text = "Call Center";
            this.btn_callCenter.UseVisualStyleBackColor = false;
            this.btn_callCenter.Click += new System.EventHandler(this.btn_callCenter_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Exit.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(134, 350);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(66, 27);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // fMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(346, 389);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_callCenter);
            this.Controls.Add(this.btn_providerManagement);
            this.Controls.Add(this.btn_medicalDepartment);
            this.Controls.Add(this.btn_productMaintenance);
            this.Controls.Add(this.btn_clientAndpolicyManagement);
            this.Name = "fMainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_clientAndpolicyManagement;
        private System.Windows.Forms.Button btn_productMaintenance;
        private System.Windows.Forms.Button btn_medicalDepartment;
        private System.Windows.Forms.Button btn_providerManagement;
        private System.Windows.Forms.Button btn_callCenter;
        private System.Windows.Forms.Button btn_Exit;
    }
}

