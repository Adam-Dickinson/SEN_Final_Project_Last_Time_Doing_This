namespace SEN_381_Final_Project
{
    partial class fProvider_Management
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
            this.dgvPolicyDetails = new System.Windows.Forms.DataGridView();
            this.gBPolicyDetails = new System.Windows.Forms.GroupBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lbl_Serach = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_provider = new System.Windows.Forms.Button();
            this.btn_product = new System.Windows.Forms.Button();
            this.btn_medical = new System.Windows.Forms.Button();
            this.btn_clientpolicy = new System.Windows.Forms.Button();
            this.btn_callcentre = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolicyDetails)).BeginInit();
            this.gBPolicyDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPolicyDetails
            // 
            this.dgvPolicyDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolicyDetails.Location = new System.Drawing.Point(119, 80);
            this.dgvPolicyDetails.Name = "dgvPolicyDetails";
            this.dgvPolicyDetails.Size = new System.Drawing.Size(563, 580);
            this.dgvPolicyDetails.TabIndex = 0;
            this.dgvPolicyDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolicyDetails_CellClick);
            this.dgvPolicyDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolicyDetails_CellContentClick);
            // 
            // gBPolicyDetails
            // 
            this.gBPolicyDetails.Controls.Add(this.txt_ID);
            this.gBPolicyDetails.Controls.Add(this.label3);
            this.gBPolicyDetails.Controls.Add(this.txt_email);
            this.gBPolicyDetails.Controls.Add(this.lbl_email);
            this.gBPolicyDetails.Controls.Add(this.txt_PhoneNumber);
            this.gBPolicyDetails.Controls.Add(this.btn_Delete);
            this.gBPolicyDetails.Controls.Add(this.label2);
            this.gBPolicyDetails.Controls.Add(this.btn_Clear);
            this.gBPolicyDetails.Controls.Add(this.lbl_Status);
            this.gBPolicyDetails.Controls.Add(this.lbl_Address);
            this.gBPolicyDetails.Controls.Add(this.lbl_Name);
            this.gBPolicyDetails.Controls.Add(this.cb_Status);
            this.gBPolicyDetails.Controls.Add(this.txt_Address);
            this.gBPolicyDetails.Controls.Add(this.txt_Name);
            this.gBPolicyDetails.Controls.Add(this.btn_Update);
            this.gBPolicyDetails.Controls.Add(this.btn_Add);
            this.gBPolicyDetails.Location = new System.Drawing.Point(705, 80);
            this.gBPolicyDetails.Name = "gBPolicyDetails";
            this.gBPolicyDetails.Size = new System.Drawing.Size(261, 424);
            this.gBPolicyDetails.TabIndex = 1;
            this.gBPolicyDetails.TabStop = false;
            this.gBPolicyDetails.Text = "Policy Details";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(104, 27);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(146, 20);
            this.txt_ID.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Provider ID";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(104, 163);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(146, 20);
            this.txt_email.TabIndex = 19;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(14, 170);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 18;
            this.lbl_email.Text = "Email";
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(104, 203);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(146, 20);
            this.txt_PhoneNumber.TabIndex = 17;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(94, 384);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Phone Number";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(94, 285);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 13;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(12, 245);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(37, 13);
            this.lbl_Status.TabIndex = 11;
            this.lbl_Status.Text = "Status";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(14, 122);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(45, 13);
            this.lbl_Address.TabIndex = 10;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(9, 77);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(77, 13);
            this.lbl_Name.TabIndex = 8;
            this.lbl_Name.Text = "Provider Name";
            // 
            // cb_Status
            // 
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "Active",
            "No Longer Active"});
            this.cb_Status.Location = new System.Drawing.Point(104, 237);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(149, 21);
            this.cb_Status.TabIndex = 6;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(106, 122);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(146, 20);
            this.txt_Address.TabIndex = 5;
            this.txt_Address.TextChanged += new System.EventHandler(this.txt_Address_TextChanged);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(106, 70);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(146, 20);
            this.txt_Name.TabIndex = 3;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(165, 324);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(23, 324);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(473, 51);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(271, 52);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(185, 20);
            this.txt_Search.TabIndex = 5;
            this.txt_Search.Text = "\r\n";
            this.txt_Search.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lbl_Serach
            // 
            this.lbl_Serach.AutoSize = true;
            this.lbl_Serach.Location = new System.Drawing.Point(140, 56);
            this.lbl_Serach.Name = "lbl_Serach";
            this.lbl_Serach.Size = new System.Drawing.Size(114, 13);
            this.lbl_Serach.TabIndex = 6;
            this.lbl_Serach.Text = "Serach Provider Name";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(346, 666);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(110, 23);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh Table";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_provider
            // 
            this.btn_provider.Location = new System.Drawing.Point(905, 12);
            this.btn_provider.Name = "btn_provider";
            this.btn_provider.Size = new System.Drawing.Size(75, 23);
            this.btn_provider.TabIndex = 12;
            this.btn_provider.Text = "Provider";
            this.btn_provider.UseVisualStyleBackColor = true;
            // 
            // btn_product
            // 
            this.btn_product.Location = new System.Drawing.Point(743, 12);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(75, 23);
            this.btn_product.TabIndex = 11;
            this.btn_product.Text = "Product";
            this.btn_product.UseVisualStyleBackColor = true;
            // 
            // btn_medical
            // 
            this.btn_medical.Location = new System.Drawing.Point(417, 12);
            this.btn_medical.Name = "btn_medical";
            this.btn_medical.Size = new System.Drawing.Size(75, 23);
            this.btn_medical.TabIndex = 10;
            this.btn_medical.Text = "Medical";
            this.btn_medical.UseVisualStyleBackColor = true;
            // 
            // btn_clientpolicy
            // 
            this.btn_clientpolicy.Location = new System.Drawing.Point(573, 12);
            this.btn_clientpolicy.Name = "btn_clientpolicy";
            this.btn_clientpolicy.Size = new System.Drawing.Size(87, 23);
            this.btn_clientpolicy.TabIndex = 9;
            this.btn_clientpolicy.Text = "Management";
            this.btn_clientpolicy.UseVisualStyleBackColor = true;
            // 
            // btn_callcentre
            // 
            this.btn_callcentre.Location = new System.Drawing.Point(243, 12);
            this.btn_callcentre.Name = "btn_callcentre";
            this.btn_callcentre.Size = new System.Drawing.Size(87, 23);
            this.btn_callcentre.TabIndex = 8;
            this.btn_callcentre.Text = "Call Centre";
            this.btn_callcentre.UseVisualStyleBackColor = true;
            this.btn_callcentre.Click += new System.EventHandler(this.btn_callcentre_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(705, 510);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 179);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Treatments Treated By Providers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(501, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // fProvider_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 724);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_provider);
            this.Controls.Add(this.btn_product);
            this.Controls.Add(this.btn_medical);
            this.Controls.Add(this.btn_clientpolicy);
            this.Controls.Add(this.btn_callcentre);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.lbl_Serach);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.gBPolicyDetails);
            this.Controls.Add(this.dgvPolicyDetails);
            this.Name = "fProvider_Management";
            this.Load += new System.EventHandler(this.fProvider_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolicyDetails)).EndInit();
            this.gBPolicyDetails.ResumeLayout(false);
            this.gBPolicyDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPolicyDetails;
        private System.Windows.Forms.GroupBox gBPolicyDetails;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label lbl_Serach;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_provider;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_medical;
        private System.Windows.Forms.Button btn_clientpolicy;
        private System.Windows.Forms.Button btn_callcentre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label3;
    }
}