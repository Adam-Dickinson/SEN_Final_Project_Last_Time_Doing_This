namespace SEN_381_Final_Project.Client_and_Policy_Management.Client_Management.Presentation
{
    partial class fManagment_Client
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
            this.dgv_Client = new System.Windows.Forms.DataGridView();
            this.btn_CAdd = new System.Windows.Forms.Button();
            this.btn_CUpdate = new System.Windows.Forms.Button();
            this.btn_CDelete = new System.Windows.Forms.Button();
            this.txt_CName = new System.Windows.Forms.TextBox();
            this.txt_CSurname = new System.Windows.Forms.TextBox();
            this.txt_CAddress = new System.Windows.Forms.TextBox();
            this.txt_CPhoneNumber = new System.Windows.Forms.TextBox();
            this.dtp_Client = new System.Windows.Forms.DateTimePicker();
            this.cb_CFamily = new System.Windows.Forms.ComboBox();
            this.cb_CPolicy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_provider = new System.Windows.Forms.Button();
            this.btn_product = new System.Windows.Forms.Button();
            this.btn_medical = new System.Windows.Forms.Button();
            this.btn_clientpolicy = new System.Windows.Forms.Button();
            this.btn_callcentre = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_FSearch = new System.Windows.Forms.Button();
            this.txt_FSearch = new System.Windows.Forms.TextBox();
            this.txt_FID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_FName = new System.Windows.Forms.TextBox();
            this.txt_FSurname = new System.Windows.Forms.TextBox();
            this.txt_FPhoneNumber = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dgv_Family = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_PolicyID = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_DeletFamily = new System.Windows.Forms.Button();
            this.btn_UpdateFamily = new System.Windows.Forms.Button();
            this.btn_AddFamily = new System.Windows.Forms.Button();
            this.cb_RoleID = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_CSearch = new System.Windows.Forms.Button();
            this.txt_CSearch = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txt_CID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_RoleType = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Client)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Family)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Client
            // 
            this.dgv_Client.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Client.Location = new System.Drawing.Point(6, 25);
            this.dgv_Client.Name = "dgv_Client";
            this.dgv_Client.Size = new System.Drawing.Size(488, 260);
            this.dgv_Client.TabIndex = 0;
            this.dgv_Client.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Client_CellClick);
            // 
            // btn_CAdd
            // 
            this.btn_CAdd.BackColor = System.Drawing.Color.DimGray;
            this.btn_CAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CAdd.Location = new System.Drawing.Point(503, 332);
            this.btn_CAdd.Name = "btn_CAdd";
            this.btn_CAdd.Size = new System.Drawing.Size(75, 23);
            this.btn_CAdd.TabIndex = 1;
            this.btn_CAdd.Text = "Add ";
            this.btn_CAdd.UseVisualStyleBackColor = false;
            this.btn_CAdd.Click += new System.EventHandler(this.btn_CAdd_Click);
            // 
            // btn_CUpdate
            // 
            this.btn_CUpdate.BackColor = System.Drawing.Color.DimGray;
            this.btn_CUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CUpdate.Location = new System.Drawing.Point(605, 332);
            this.btn_CUpdate.Name = "btn_CUpdate";
            this.btn_CUpdate.Size = new System.Drawing.Size(75, 23);
            this.btn_CUpdate.TabIndex = 2;
            this.btn_CUpdate.Text = "Update ";
            this.btn_CUpdate.UseVisualStyleBackColor = false;
            this.btn_CUpdate.Click += new System.EventHandler(this.btn_CUpdate_Click);
            // 
            // btn_CDelete
            // 
            this.btn_CDelete.BackColor = System.Drawing.Color.DimGray;
            this.btn_CDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CDelete.Location = new System.Drawing.Point(716, 332);
            this.btn_CDelete.Name = "btn_CDelete";
            this.btn_CDelete.Size = new System.Drawing.Size(75, 23);
            this.btn_CDelete.TabIndex = 3;
            this.btn_CDelete.Text = "Delete";
            this.btn_CDelete.UseVisualStyleBackColor = false;
            this.btn_CDelete.Click += new System.EventHandler(this.btn_CDelete_Click);
            // 
            // txt_CName
            // 
            this.txt_CName.Location = new System.Drawing.Point(586, 88);
            this.txt_CName.Name = "txt_CName";
            this.txt_CName.Size = new System.Drawing.Size(198, 20);
            this.txt_CName.TabIndex = 4;
            // 
            // txt_CSurname
            // 
            this.txt_CSurname.Location = new System.Drawing.Point(586, 114);
            this.txt_CSurname.Name = "txt_CSurname";
            this.txt_CSurname.Size = new System.Drawing.Size(197, 20);
            this.txt_CSurname.TabIndex = 5;
            // 
            // txt_CAddress
            // 
            this.txt_CAddress.Location = new System.Drawing.Point(586, 140);
            this.txt_CAddress.Name = "txt_CAddress";
            this.txt_CAddress.Size = new System.Drawing.Size(197, 20);
            this.txt_CAddress.TabIndex = 6;
            // 
            // txt_CPhoneNumber
            // 
            this.txt_CPhoneNumber.Location = new System.Drawing.Point(586, 166);
            this.txt_CPhoneNumber.Name = "txt_CPhoneNumber";
            this.txt_CPhoneNumber.Size = new System.Drawing.Size(197, 20);
            this.txt_CPhoneNumber.TabIndex = 7;
            // 
            // dtp_Client
            // 
            this.dtp_Client.Location = new System.Drawing.Point(586, 192);
            this.dtp_Client.Name = "dtp_Client";
            this.dtp_Client.Size = new System.Drawing.Size(197, 20);
            this.dtp_Client.TabIndex = 10;
            this.dtp_Client.Value = new System.DateTime(2022, 11, 7, 0, 0, 0, 0);
            // 
            // cb_CFamily
            // 
            this.cb_CFamily.FormattingEnabled = true;
            this.cb_CFamily.Items.AddRange(new object[] {
            "Individual",
            "Family"});
            this.cb_CFamily.Location = new System.Drawing.Point(587, 218);
            this.cb_CFamily.Name = "cb_CFamily";
            this.cb_CFamily.Size = new System.Drawing.Size(195, 21);
            this.cb_CFamily.TabIndex = 11;
            this.cb_CFamily.TextUpdate += new System.EventHandler(this.cb_CFamily_TextUpdate);
            // 
            // cb_CPolicy
            // 
            this.cb_CPolicy.FormattingEnabled = true;
            this.cb_CPolicy.Location = new System.Drawing.Point(587, 269);
            this.cb_CPolicy.Name = "cb_CPolicy";
            this.cb_CPolicy.Size = new System.Drawing.Size(195, 21);
            this.cb_CPolicy.TabIndex = 12;
            this.cb_CPolicy.SelectedIndexChanged += new System.EventHandler(this.cb_CPolicy_SelectedIndexChanged);
            this.cb_CPolicy.Enter += new System.EventHandler(this.cb_CPolicy_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(500, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(500, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(500, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(500, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "DOB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(500, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Is Family";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(534, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(504, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Policy Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(500, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Phone Number";
            // 
            // btn_provider
            // 
            this.btn_provider.BackColor = System.Drawing.Color.DimGray;
            this.btn_provider.ForeColor = System.Drawing.Color.Snow;
            this.btn_provider.Location = new System.Drawing.Point(1047, 26);
            this.btn_provider.Name = "btn_provider";
            this.btn_provider.Size = new System.Drawing.Size(75, 23);
            this.btn_provider.TabIndex = 27;
            this.btn_provider.Text = "Provider";
            this.btn_provider.UseVisualStyleBackColor = false;
            this.btn_provider.Click += new System.EventHandler(this.btn_provider_Click);
            // 
            // btn_product
            // 
            this.btn_product.BackColor = System.Drawing.Color.DimGray;
            this.btn_product.ForeColor = System.Drawing.Color.Snow;
            this.btn_product.Location = new System.Drawing.Point(885, 26);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(75, 23);
            this.btn_product.TabIndex = 26;
            this.btn_product.Text = "Product";
            this.btn_product.UseVisualStyleBackColor = false;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // btn_medical
            // 
            this.btn_medical.BackColor = System.Drawing.Color.DimGray;
            this.btn_medical.ForeColor = System.Drawing.Color.Snow;
            this.btn_medical.Location = new System.Drawing.Point(723, 26);
            this.btn_medical.Name = "btn_medical";
            this.btn_medical.Size = new System.Drawing.Size(75, 23);
            this.btn_medical.TabIndex = 25;
            this.btn_medical.Text = "Medical";
            this.btn_medical.UseVisualStyleBackColor = false;
            this.btn_medical.Click += new System.EventHandler(this.btn_medical_Click);
            // 
            // btn_clientpolicy
            // 
            this.btn_clientpolicy.BackColor = System.Drawing.Color.DimGray;
            this.btn_clientpolicy.ForeColor = System.Drawing.Color.Snow;
            this.btn_clientpolicy.Location = new System.Drawing.Point(555, 26);
            this.btn_clientpolicy.Name = "btn_clientpolicy";
            this.btn_clientpolicy.Size = new System.Drawing.Size(87, 23);
            this.btn_clientpolicy.TabIndex = 24;
            this.btn_clientpolicy.Text = "Management";
            this.btn_clientpolicy.UseVisualStyleBackColor = false;
            this.btn_clientpolicy.Click += new System.EventHandler(this.btn_clientpolicy_Click);
            // 
            // btn_callcentre
            // 
            this.btn_callcentre.BackColor = System.Drawing.Color.DimGray;
            this.btn_callcentre.ForeColor = System.Drawing.Color.Snow;
            this.btn_callcentre.Location = new System.Drawing.Point(385, 26);
            this.btn_callcentre.Name = "btn_callcentre";
            this.btn_callcentre.Size = new System.Drawing.Size(87, 23);
            this.btn_callcentre.TabIndex = 23;
            this.btn_callcentre.Text = "Call Centre";
            this.btn_callcentre.UseVisualStyleBackColor = false;
            this.btn_callcentre.Click += new System.EventHandler(this.btn_callcentre_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_RoleType);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.txt_FID);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_FName);
            this.groupBox1.Controls.Add(this.txt_FSurname);
            this.groupBox1.Controls.Add(this.txt_FPhoneNumber);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.dgv_Family);
            this.groupBox1.Location = new System.Drawing.Point(813, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 260);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Family";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_FSearch);
            this.groupBox6.Controls.Add(this.txt_FSearch);
            this.groupBox6.Location = new System.Drawing.Point(393, 25);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(276, 40);
            this.groupBox6.TabIndex = 32;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Search Family";
            // 
            // btn_FSearch
            // 
            this.btn_FSearch.BackColor = System.Drawing.Color.DimGray;
            this.btn_FSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_FSearch.Location = new System.Drawing.Point(161, 11);
            this.btn_FSearch.Name = "btn_FSearch";
            this.btn_FSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_FSearch.TabIndex = 26;
            this.btn_FSearch.Text = "Search";
            this.btn_FSearch.UseVisualStyleBackColor = false;
            this.btn_FSearch.Click += new System.EventHandler(this.btn_FSearch_Click);
            // 
            // txt_FSearch
            // 
            this.txt_FSearch.Location = new System.Drawing.Point(6, 14);
            this.txt_FSearch.Name = "txt_FSearch";
            this.txt_FSearch.Size = new System.Drawing.Size(108, 20);
            this.txt_FSearch.TabIndex = 25;
            // 
            // txt_FID
            // 
            this.txt_FID.Location = new System.Drawing.Point(464, 92);
            this.txt_FID.Name = "txt_FID";
            this.txt_FID.Size = new System.Drawing.Size(197, 20);
            this.txt_FID.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(381, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "ID Number";
            // 
            // txt_FName
            // 
            this.txt_FName.Location = new System.Drawing.Point(464, 115);
            this.txt_FName.Name = "txt_FName";
            this.txt_FName.Size = new System.Drawing.Size(197, 20);
            this.txt_FName.TabIndex = 25;
            // 
            // txt_FSurname
            // 
            this.txt_FSurname.Location = new System.Drawing.Point(464, 141);
            this.txt_FSurname.Name = "txt_FSurname";
            this.txt_FSurname.Size = new System.Drawing.Size(197, 20);
            this.txt_FSurname.TabIndex = 26;
            // 
            // txt_FPhoneNumber
            // 
            this.txt_FPhoneNumber.Location = new System.Drawing.Point(464, 170);
            this.txt_FPhoneNumber.Name = "txt_FPhoneNumber";
            this.txt_FPhoneNumber.Size = new System.Drawing.Size(197, 20);
            this.txt_FPhoneNumber.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(381, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Phone Number";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(381, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(381, 147);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "Surname";
            // 
            // dgv_Family
            // 
            this.dgv_Family.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_Family.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Family.Location = new System.Drawing.Point(6, 22);
            this.dgv_Family.Name = "dgv_Family";
            this.dgv_Family.Size = new System.Drawing.Size(369, 200);
            this.dgv_Family.TabIndex = 1;
            this.dgv_Family.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Family_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_PolicyID);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btn_DeletFamily);
            this.groupBox2.Controls.Add(this.btn_UpdateFamily);
            this.groupBox2.Controls.Add(this.btn_AddFamily);
            this.groupBox2.Controls.Add(this.cb_RoleID);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btn_Reload);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.txt_CID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dgv_Client);
            this.groupBox2.Controls.Add(this.txt_CName);
            this.groupBox2.Controls.Add(this.txt_CSurname);
            this.groupBox2.Controls.Add(this.txt_CAddress);
            this.groupBox2.Controls.Add(this.txt_CPhoneNumber);
            this.groupBox2.Controls.Add(this.dtp_Client);
            this.groupBox2.Controls.Add(this.cb_CFamily);
            this.groupBox2.Controls.Add(this.btn_CDelete);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_CUpdate);
            this.groupBox2.Controls.Add(this.cb_CPolicy);
            this.groupBox2.Controls.Add(this.btn_CAdd);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(792, 406);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client";
            // 
            // cb_PolicyID
            // 
            this.cb_PolicyID.FormattingEnabled = true;
            this.cb_PolicyID.Location = new System.Drawing.Point(586, 293);
            this.cb_PolicyID.Name = "cb_PolicyID";
            this.cb_PolicyID.Size = new System.Drawing.Size(196, 21);
            this.cb_PolicyID.TabIndex = 32;
            this.cb_PolicyID.SelectedIndexChanged += new System.EventHandler(this.cb_PolicyID_SelectedIndexChanged);
            this.cb_PolicyID.Enter += new System.EventHandler(this.cb_PolicyID_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(502, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Policy ID";
            // 
            // btn_DeletFamily
            // 
            this.btn_DeletFamily.BackColor = System.Drawing.Color.DimGray;
            this.btn_DeletFamily.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_DeletFamily.Location = new System.Drawing.Point(716, 355);
            this.btn_DeletFamily.Name = "btn_DeletFamily";
            this.btn_DeletFamily.Size = new System.Drawing.Size(75, 37);
            this.btn_DeletFamily.TabIndex = 31;
            this.btn_DeletFamily.Text = "Delete Family";
            this.btn_DeletFamily.UseVisualStyleBackColor = false;
            this.btn_DeletFamily.Click += new System.EventHandler(this.btn_DeletFamily_Click);
            // 
            // btn_UpdateFamily
            // 
            this.btn_UpdateFamily.BackColor = System.Drawing.Color.DimGray;
            this.btn_UpdateFamily.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_UpdateFamily.Location = new System.Drawing.Point(605, 355);
            this.btn_UpdateFamily.Name = "btn_UpdateFamily";
            this.btn_UpdateFamily.Size = new System.Drawing.Size(75, 37);
            this.btn_UpdateFamily.TabIndex = 30;
            this.btn_UpdateFamily.Text = "Update Family ";
            this.btn_UpdateFamily.UseVisualStyleBackColor = false;
            this.btn_UpdateFamily.Click += new System.EventHandler(this.btn_UpdateFamily_Click);
            // 
            // btn_AddFamily
            // 
            this.btn_AddFamily.BackColor = System.Drawing.Color.DimGray;
            this.btn_AddFamily.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AddFamily.Location = new System.Drawing.Point(503, 355);
            this.btn_AddFamily.Name = "btn_AddFamily";
            this.btn_AddFamily.Size = new System.Drawing.Size(75, 37);
            this.btn_AddFamily.TabIndex = 29;
            this.btn_AddFamily.Text = "Add Family";
            this.btn_AddFamily.UseVisualStyleBackColor = false;
            this.btn_AddFamily.Click += new System.EventHandler(this.btn_AddFamily_Click);
            this.btn_AddFamily.Enter += new System.EventHandler(this.btn_AddFamily_Enter);
            // 
            // cb_RoleID
            // 
            this.cb_RoleID.FormattingEnabled = true;
            this.cb_RoleID.Location = new System.Drawing.Point(587, 244);
            this.cb_RoleID.Name = "cb_RoleID";
            this.cb_RoleID.Size = new System.Drawing.Size(195, 21);
            this.cb_RoleID.TabIndex = 27;
            this.cb_RoleID.Enter += new System.EventHandler(this.cb_RoleID_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(502, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Role Type";
            // 
            // btn_Reload
            // 
            this.btn_Reload.BackColor = System.Drawing.Color.DimGray;
            this.btn_Reload.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Reload.Location = new System.Drawing.Point(186, 291);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(75, 23);
            this.btn_Reload.TabIndex = 26;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = false;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_CSearch);
            this.groupBox4.Controls.Add(this.txt_CSearch);
            this.groupBox4.Location = new System.Drawing.Point(507, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(276, 40);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Client";
            // 
            // btn_CSearch
            // 
            this.btn_CSearch.BackColor = System.Drawing.Color.DimGray;
            this.btn_CSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CSearch.Location = new System.Drawing.Point(161, 11);
            this.btn_CSearch.Name = "btn_CSearch";
            this.btn_CSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_CSearch.TabIndex = 26;
            this.btn_CSearch.Text = "Search";
            this.btn_CSearch.UseVisualStyleBackColor = false;
            this.btn_CSearch.Click += new System.EventHandler(this.btn_CSearch_Click);
            // 
            // txt_CSearch
            // 
            this.txt_CSearch.Location = new System.Drawing.Point(6, 14);
            this.txt_CSearch.Name = "txt_CSearch";
            this.txt_CSearch.Size = new System.Drawing.Size(108, 20);
            this.txt_CSearch.TabIndex = 25;
            // 
            // txt_CID
            // 
            this.txt_CID.Location = new System.Drawing.Point(586, 65);
            this.txt_CID.Name = "txt_CID";
            this.txt_CID.Size = new System.Drawing.Size(198, 20);
            this.txt_CID.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(500, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "ID Number";
            // 
            // txt_RoleType
            // 
            this.txt_RoleType.Location = new System.Drawing.Point(464, 196);
            this.txt_RoleType.Name = "txt_RoleType";
            this.txt_RoleType.Size = new System.Drawing.Size(197, 20);
            this.txt_RoleType.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(381, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Role Type";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(461, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "1: Main Member";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(461, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "2: Beneficiary";
            // 
            // fManagment_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1495, 483);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_provider);
            this.Controls.Add(this.btn_product);
            this.Controls.Add(this.btn_medical);
            this.Controls.Add(this.btn_clientpolicy);
            this.Controls.Add(this.btn_callcentre);
            this.Name = "fManagment_Client";
            this.Text = "fClient";
            this.Load += new System.EventHandler(this.fManagment_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Client)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Family)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Client;
        private System.Windows.Forms.Button btn_CAdd;
        private System.Windows.Forms.Button btn_CUpdate;
        private System.Windows.Forms.Button btn_CDelete;
        private System.Windows.Forms.TextBox txt_CName;
        private System.Windows.Forms.TextBox txt_CSurname;
        private System.Windows.Forms.TextBox txt_CAddress;
        private System.Windows.Forms.TextBox txt_CPhoneNumber;
        private System.Windows.Forms.DateTimePicker dtp_Client;
        private System.Windows.Forms.ComboBox cb_CFamily;
        private System.Windows.Forms.ComboBox cb_CPolicy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_provider;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_medical;
        private System.Windows.Forms.Button btn_clientpolicy;
        private System.Windows.Forms.Button btn_callcentre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Family;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_FID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_FName;
        private System.Windows.Forms.TextBox txt_FSurname;
        private System.Windows.Forms.TextBox txt_FPhoneNumber;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_CSearch;
        private System.Windows.Forms.TextBox txt_CSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_FSearch;
        private System.Windows.Forms.TextBox txt_FSearch;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.ComboBox cb_RoleID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_AddFamily;
        private System.Windows.Forms.Button btn_DeletFamily;
        private System.Windows.Forms.Button btn_UpdateFamily;
        private System.Windows.Forms.ComboBox cb_PolicyID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_CID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_RoleType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}