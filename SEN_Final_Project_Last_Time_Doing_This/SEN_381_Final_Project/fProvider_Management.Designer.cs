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
            this.btn_Clear = new System.Windows.Forms.Button();
            this.cb_Location = new System.Windows.Forms.ComboBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Location = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_MainMenu = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lbl_Serach = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolicyDetails)).BeginInit();
            this.gBPolicyDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPolicyDetails
            // 
            this.dgvPolicyDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolicyDetails.Location = new System.Drawing.Point(12, 33);
            this.dgvPolicyDetails.Name = "dgvPolicyDetails";
            this.dgvPolicyDetails.Size = new System.Drawing.Size(563, 352);
            this.dgvPolicyDetails.TabIndex = 0;
            this.dgvPolicyDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolicyDetails_CellClick);
            // 
            // gBPolicyDetails
            // 
            this.gBPolicyDetails.Controls.Add(this.btn_Clear);
            this.gBPolicyDetails.Controls.Add(this.cb_Location);
            this.gBPolicyDetails.Controls.Add(this.lbl_Status);
            this.gBPolicyDetails.Controls.Add(this.lbl_Address);
            this.gBPolicyDetails.Controls.Add(this.lbl_Location);
            this.gBPolicyDetails.Controls.Add(this.lbl_Name);
            this.gBPolicyDetails.Controls.Add(this.lbl_ID);
            this.gBPolicyDetails.Controls.Add(this.cb_Status);
            this.gBPolicyDetails.Controls.Add(this.txt_Address);
            this.gBPolicyDetails.Controls.Add(this.txt_Name);
            this.gBPolicyDetails.Controls.Add(this.txt_ID);
            this.gBPolicyDetails.Controls.Add(this.btn_Update);
            this.gBPolicyDetails.Controls.Add(this.btn_Add);
            this.gBPolicyDetails.Location = new System.Drawing.Point(588, 33);
            this.gBPolicyDetails.Name = "gBPolicyDetails";
            this.gBPolicyDetails.Size = new System.Drawing.Size(235, 352);
            this.gBPolicyDetails.TabIndex = 1;
            this.gBPolicyDetails.TabStop = false;
            this.gBPolicyDetails.Text = "Policy Details";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(77, 284);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 13;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // cb_Location
            // 
            this.cb_Location.FormattingEnabled = true;
            this.cb_Location.Items.AddRange(new object[] {
            "Gauteng",
            "Northen Cape",
            "Western Cape",
            "Eastern Cape",
            "Free State",
            "Kwazulu-Natal",
            "Limpopo",
            "Mpumalange",
            "North-West",
            "Nation Wide"});
            this.cb_Location.Location = new System.Drawing.Point(92, 138);
            this.cb_Location.Name = "cb_Location";
            this.cb_Location.Size = new System.Drawing.Size(131, 21);
            this.cb_Location.TabIndex = 12;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(7, 249);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(37, 13);
            this.lbl_Status.TabIndex = 11;
            this.lbl_Status.Text = "Status";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(7, 195);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(45, 13);
            this.lbl_Address.TabIndex = 10;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Location = new System.Drawing.Point(7, 141);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(48, 13);
            this.lbl_Location.TabIndex = 9;
            this.lbl_Location.Text = "Location";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(7, 80);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 8;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(7, 37);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(65, 13);
            this.lbl_ID.TabIndex = 7;
            this.lbl_ID.Text = "Company ID";
            // 
            // cb_Status
            // 
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "Active",
            "Blacklisted",
            "Not-Active"});
            this.cb_Status.Location = new System.Drawing.Point(92, 241);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(131, 21);
            this.cb_Status.TabIndex = 6;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(95, 188);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(128, 20);
            this.txt_Address.TabIndex = 5;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(95, 80);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(128, 20);
            this.txt_Name.TabIndex = 3;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(95, 31);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(128, 20);
            this.txt_ID.TabIndex = 2;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(148, 323);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(6, 323);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_MainMenu
            // 
            this.btn_MainMenu.Location = new System.Drawing.Point(195, 404);
            this.btn_MainMenu.Name = "btn_MainMenu";
            this.btn_MainMenu.Size = new System.Drawing.Size(75, 23);
            this.btn_MainMenu.TabIndex = 3;
            this.btn_MainMenu.Text = "Main Menu";
            this.btn_MainMenu.UseVisualStyleBackColor = true;
            this.btn_MainMenu.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(356, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(154, 5);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(185, 20);
            this.txt_Search.TabIndex = 5;
            this.txt_Search.Text = "\r\n";
            this.txt_Search.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lbl_Serach
            // 
            this.lbl_Serach.AutoSize = true;
            this.lbl_Serach.Location = new System.Drawing.Point(23, 9);
            this.lbl_Serach.Name = "lbl_Serach";
            this.lbl_Serach.Size = new System.Drawing.Size(114, 13);
            this.lbl_Serach.TabIndex = 6;
            this.lbl_Serach.Text = "Serach Provider Name";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(651, 404);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(39, 404);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(110, 23);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh Table";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fProvider_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.lbl_Serach);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_MainMenu);
            this.Controls.Add(this.gBPolicyDetails);
            this.Controls.Add(this.dgvPolicyDetails);
            this.Name = "fProvider_Management";
            this.Text = "fProvider_Management";
            this.Load += new System.EventHandler(this.fProvider_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolicyDetails)).EndInit();
            this.gBPolicyDetails.ResumeLayout(false);
            this.gBPolicyDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPolicyDetails;
        private System.Windows.Forms.GroupBox gBPolicyDetails;
        private System.Windows.Forms.Button btn_MainMenu;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label lbl_Serach;
        private System.Windows.Forms.ComboBox cb_Location;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button button1;
    }
}