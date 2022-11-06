namespace SEN_381_Final_Project.Medical_Department.Presentation
{
    partial class fMedical
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMedical));
            this.btn_provider = new System.Windows.Forms.Button();
            this.btn_product = new System.Windows.Forms.Button();
            this.btn_medical = new System.Windows.Forms.Button();
            this.btn_clientpolicy = new System.Windows.Forms.Button();
            this.btn_callcentre = new System.Windows.Forms.Button();
            this.dgv_Treatment = new System.Windows.Forms.DataGridView();
            this.dgv_MC = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_SearchTreatment = new System.Windows.Forms.Button();
            this.txt_TreatmentNameSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtxt_TreatmentDescription = new System.Windows.Forms.RichTextBox();
            this.btn_DeleteTreatment = new System.Windows.Forms.Button();
            this.btn_UpdateTreatment = new System.Windows.Forms.Button();
            this.btn_AddTreatment = new System.Windows.Forms.Button();
            this.cb_TreatmentMC = new System.Windows.Forms.ComboBox();
            this.txt_TreatmentName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_CID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_SearchMC = new System.Windows.Forms.Button();
            this.txt_MCNameSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtxt_MCInformation = new System.Windows.Forms.RichTextBox();
            this.btn_DeleteMC = new System.Windows.Forms.Button();
            this.btn_UpdateMC = new System.Windows.Forms.Button();
            this.btn_AddMC = new System.Windows.Forms.Button();
            this.txt_MCName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_Reload = new System.Windows.Forms.Button();
            this.btn_reload2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Treatment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_provider
            // 
            this.btn_provider.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_provider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_provider.Location = new System.Drawing.Point(751, 12);
            this.btn_provider.Name = "btn_provider";
            this.btn_provider.Size = new System.Drawing.Size(75, 24);
            this.btn_provider.TabIndex = 9;
            this.btn_provider.Text = "Provider";
            this.btn_provider.UseVisualStyleBackColor = false;
            this.btn_provider.Click += new System.EventHandler(this.btn_provider_Click);
            // 
            // btn_product
            // 
            this.btn_product.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_product.Location = new System.Drawing.Point(567, 12);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(75, 24);
            this.btn_product.TabIndex = 8;
            this.btn_product.Text = "Product";
            this.btn_product.UseVisualStyleBackColor = false;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // btn_medical
            // 
            this.btn_medical.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_medical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_medical.Location = new System.Drawing.Point(407, 11);
            this.btn_medical.Name = "btn_medical";
            this.btn_medical.Size = new System.Drawing.Size(75, 24);
            this.btn_medical.TabIndex = 7;
            this.btn_medical.Text = "Medical";
            this.btn_medical.UseVisualStyleBackColor = false;
            this.btn_medical.Click += new System.EventHandler(this.btn_medical_Click);
            // 
            // btn_clientpolicy
            // 
            this.btn_clientpolicy.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_clientpolicy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientpolicy.Location = new System.Drawing.Point(229, 11);
            this.btn_clientpolicy.Name = "btn_clientpolicy";
            this.btn_clientpolicy.Size = new System.Drawing.Size(87, 24);
            this.btn_clientpolicy.TabIndex = 6;
            this.btn_clientpolicy.Text = "Management";
            this.btn_clientpolicy.UseVisualStyleBackColor = false;
            this.btn_clientpolicy.Click += new System.EventHandler(this.btn_clientpolicy_Click);
            // 
            // btn_callcentre
            // 
            this.btn_callcentre.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_callcentre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_callcentre.Location = new System.Drawing.Point(84, 11);
            this.btn_callcentre.Name = "btn_callcentre";
            this.btn_callcentre.Size = new System.Drawing.Size(75, 24);
            this.btn_callcentre.TabIndex = 5;
            this.btn_callcentre.Text = "Call Centre";
            this.btn_callcentre.UseVisualStyleBackColor = false;
            this.btn_callcentre.Click += new System.EventHandler(this.btn_callcentre_Click);
            // 
            // dgv_Treatment
            // 
            this.dgv_Treatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Treatment.Location = new System.Drawing.Point(6, 56);
            this.dgv_Treatment.Name = "dgv_Treatment";
            this.dgv_Treatment.Size = new System.Drawing.Size(418, 203);
            this.dgv_Treatment.TabIndex = 10;
            this.dgv_Treatment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Treatment_CellClick);
            // 
            // dgv_MC
            // 
            this.dgv_MC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MC.Location = new System.Drawing.Point(6, 63);
            this.dgv_MC.Name = "dgv_MC";
            this.dgv_MC.Size = new System.Drawing.Size(453, 203);
            this.dgv_MC.TabIndex = 11;
            this.dgv_MC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MC_CellClick_1);
            this.dgv_MC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MC_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Reload);
            this.groupBox1.Controls.Add(this.txt_TID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btn_SearchTreatment);
            this.groupBox1.Controls.Add(this.txt_TreatmentNameSearch);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rtxt_TreatmentDescription);
            this.groupBox1.Controls.Add(this.btn_DeleteTreatment);
            this.groupBox1.Controls.Add(this.btn_UpdateTreatment);
            this.groupBox1.Controls.Add(this.btn_AddTreatment);
            this.groupBox1.Controls.Add(this.cb_TreatmentMC);
            this.groupBox1.Controls.Add(this.txt_TreatmentName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgv_Treatment);
            this.groupBox1.Location = new System.Drawing.Point(2, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 451);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Treatment";
            // 
            // txt_TID
            // 
            this.txt_TID.Location = new System.Drawing.Point(90, 274);
            this.txt_TID.Name = "txt_TID";
            this.txt_TID.Size = new System.Drawing.Size(300, 20);
            this.txt_TID.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "ID";
            // 
            // btn_SearchTreatment
            // 
            this.btn_SearchTreatment.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_SearchTreatment.BackgroundImage = global::SEN_381_Final_Project.Properties.Resources.searchmagnifierinterfacesymbol_798941;
            this.btn_SearchTreatment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SearchTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchTreatment.Image = global::SEN_381_Final_Project.Properties.Resources.searchmagnifierinterfacesymbol_79894;
            this.btn_SearchTreatment.Location = new System.Drawing.Point(349, 25);
            this.btn_SearchTreatment.Name = "btn_SearchTreatment";
            this.btn_SearchTreatment.Size = new System.Drawing.Size(25, 22);
            this.btn_SearchTreatment.TabIndex = 21;
            this.btn_SearchTreatment.UseVisualStyleBackColor = false;
            this.btn_SearchTreatment.Click += new System.EventHandler(this.btn_SearchTreatment_Click);
            // 
            // txt_TreatmentNameSearch
            // 
            this.txt_TreatmentNameSearch.Location = new System.Drawing.Point(51, 27);
            this.txt_TreatmentNameSearch.Name = "txt_TreatmentNameSearch";
            this.txt_TreatmentNameSearch.Size = new System.Drawing.Size(292, 20);
            this.txt_TreatmentNameSearch.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Name";
            // 
            // rtxt_TreatmentDescription
            // 
            this.rtxt_TreatmentDescription.Location = new System.Drawing.Point(90, 331);
            this.rtxt_TreatmentDescription.Name = "rtxt_TreatmentDescription";
            this.rtxt_TreatmentDescription.Size = new System.Drawing.Size(300, 42);
            this.rtxt_TreatmentDescription.TabIndex = 18;
            this.rtxt_TreatmentDescription.Text = "";
            // 
            // btn_DeleteTreatment
            // 
<<<<<<< Updated upstream
            this.btn_DeleteTreatment.BackColor = System.Drawing.Color.DimGray;
            this.btn_DeleteTreatment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_DeleteTreatment.Location = new System.Drawing.Point(223, 412);
=======
            this.btn_DeleteTreatment.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_DeleteTreatment.BackgroundImage = global::SEN_381_Final_Project.Properties.Resources.waste_bin_delete_remove_recycle_icon_123840;
            this.btn_DeleteTreatment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DeleteTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteTreatment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_DeleteTreatment.Location = new System.Drawing.Point(262, 406);
>>>>>>> Stashed changes
            this.btn_DeleteTreatment.Name = "btn_DeleteTreatment";
            this.btn_DeleteTreatment.Size = new System.Drawing.Size(36, 34);
            this.btn_DeleteTreatment.TabIndex = 17;
            this.btn_DeleteTreatment.UseVisualStyleBackColor = false;
            this.btn_DeleteTreatment.Click += new System.EventHandler(this.btn_DeleteTreatment_Click);
            // 
            // btn_UpdateTreatment
            // 
<<<<<<< Updated upstream
            this.btn_UpdateTreatment.BackColor = System.Drawing.Color.DimGray;
            this.btn_UpdateTreatment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_UpdateTreatment.Location = new System.Drawing.Point(112, 412);
=======
            this.btn_UpdateTreatment.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_UpdateTreatment.BackgroundImage = global::SEN_381_Final_Project.Properties.Resources.refresh_paper_load_update_icon_141966;
            this.btn_UpdateTreatment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_UpdateTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateTreatment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_UpdateTreatment.Location = new System.Drawing.Point(208, 407);
>>>>>>> Stashed changes
            this.btn_UpdateTreatment.Name = "btn_UpdateTreatment";
            this.btn_UpdateTreatment.Size = new System.Drawing.Size(37, 33);
            this.btn_UpdateTreatment.TabIndex = 16;
            this.btn_UpdateTreatment.UseVisualStyleBackColor = false;
            this.btn_UpdateTreatment.Click += new System.EventHandler(this.btn_UpdateTreatment_Click);
            // 
            // btn_AddTreatment
            // 
<<<<<<< Updated upstream
            this.btn_AddTreatment.BackColor = System.Drawing.Color.DimGray;
            this.btn_AddTreatment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AddTreatment.Location = new System.Drawing.Point(10, 412);
=======
            this.btn_AddTreatment.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_AddTreatment.BackgroundImage = global::SEN_381_Final_Project.Properties.Resources.add_circle_create_expand_new_plus_icon_123218;
            this.btn_AddTreatment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AddTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddTreatment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AddTreatment.Location = new System.Drawing.Point(154, 407);
>>>>>>> Stashed changes
            this.btn_AddTreatment.Name = "btn_AddTreatment";
            this.btn_AddTreatment.Size = new System.Drawing.Size(38, 33);
            this.btn_AddTreatment.TabIndex = 15;
            this.btn_AddTreatment.UseVisualStyleBackColor = false;
            this.btn_AddTreatment.Click += new System.EventHandler(this.btn_AddTreatment_Click);
            // 
            // cb_TreatmentMC
            // 
            this.cb_TreatmentMC.FormattingEnabled = true;
            this.cb_TreatmentMC.Location = new System.Drawing.Point(90, 379);
            this.cb_TreatmentMC.Name = "cb_TreatmentMC";
            this.cb_TreatmentMC.Size = new System.Drawing.Size(300, 21);
            this.cb_TreatmentMC.TabIndex = 17;
            this.cb_TreatmentMC.TextChanged += new System.EventHandler(this.cb_TreatmentMC_TextChanged);
            this.cb_TreatmentMC.Enter += new System.EventHandler(this.cb_TreatmentMC_Enter);
            this.cb_TreatmentMC.Leave += new System.EventHandler(this.cb_TreatmentMC_Leave);
            // 
            // txt_TreatmentName
            // 
            this.txt_TreatmentName.Location = new System.Drawing.Point(90, 305);
            this.txt_TreatmentName.Name = "txt_TreatmentName";
            this.txt_TreatmentName.Size = new System.Drawing.Size(300, 20);
            this.txt_TreatmentName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Medical Condition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_reload2);
            this.groupBox2.Controls.Add(this.txt_CID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btn_SearchMC);
            this.groupBox2.Controls.Add(this.txt_MCNameSearch);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rtxt_MCInformation);
            this.groupBox2.Controls.Add(this.btn_DeleteMC);
            this.groupBox2.Controls.Add(this.btn_UpdateMC);
            this.groupBox2.Controls.Add(this.btn_AddMC);
            this.groupBox2.Controls.Add(this.txt_MCName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dgv_MC);
            this.groupBox2.Location = new System.Drawing.Point(487, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 451);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medical Conditions";
            // 
            // txt_CID
            // 
            this.txt_CID.Location = new System.Drawing.Point(93, 278);
            this.txt_CID.Name = "txt_CID";
            this.txt_CID.Size = new System.Drawing.Size(300, 20);
            this.txt_CID.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "ID";
            // 
            // btn_SearchMC
            // 
            this.btn_SearchMC.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_SearchMC.BackgroundImage = global::SEN_381_Final_Project.Properties.Resources.searchmagnifierinterfacesymbol_798941;
            this.btn_SearchMC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SearchMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchMC.Location = new System.Drawing.Point(384, 25);
            this.btn_SearchMC.Name = "btn_SearchMC";
            this.btn_SearchMC.Size = new System.Drawing.Size(26, 23);
            this.btn_SearchMC.TabIndex = 24;
            this.btn_SearchMC.UseVisualStyleBackColor = false;
            this.btn_SearchMC.Click += new System.EventHandler(this.btn_SearchMC_Click);
            // 
            // txt_MCNameSearch
            // 
            this.txt_MCNameSearch.Location = new System.Drawing.Point(47, 27);
            this.txt_MCNameSearch.Name = "txt_MCNameSearch";
            this.txt_MCNameSearch.Size = new System.Drawing.Size(331, 20);
            this.txt_MCNameSearch.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Name";
            // 
            // rtxt_MCInformation
            // 
            this.rtxt_MCInformation.Location = new System.Drawing.Point(93, 331);
            this.rtxt_MCInformation.Name = "rtxt_MCInformation";
            this.rtxt_MCInformation.Size = new System.Drawing.Size(300, 39);
            this.rtxt_MCInformation.TabIndex = 21;
            this.rtxt_MCInformation.Text = "";
            // 
            // btn_DeleteMC
            // 
<<<<<<< Updated upstream
            this.btn_DeleteMC.BackColor = System.Drawing.Color.DimGray;
            this.btn_DeleteMC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_DeleteMC.Location = new System.Drawing.Point(233, 382);
=======
            this.btn_DeleteMC.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_DeleteMC.BackgroundImage = global::SEN_381_Final_Project.Properties.Resources.waste_bin_delete_remove_recycle_icon_123840;
            this.btn_DeleteMC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DeleteMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteMC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_DeleteMC.Location = new System.Drawing.Point(266, 405);
>>>>>>> Stashed changes
            this.btn_DeleteMC.Name = "btn_DeleteMC";
            this.btn_DeleteMC.Size = new System.Drawing.Size(38, 35);
            this.btn_DeleteMC.TabIndex = 20;
            this.btn_DeleteMC.UseVisualStyleBackColor = false;
            this.btn_DeleteMC.Click += new System.EventHandler(this.btn_DeleteMC_Click);
            // 
            // btn_UpdateMC
            // 
<<<<<<< Updated upstream
            this.btn_UpdateMC.BackColor = System.Drawing.Color.DimGray;
            this.btn_UpdateMC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_UpdateMC.Location = new System.Drawing.Point(122, 382);
=======
            this.btn_UpdateMC.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_UpdateMC.BackgroundImage = global::SEN_381_Final_Project.Properties.Resources.refresh_paper_load_update_icon_141966;
            this.btn_UpdateMC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_UpdateMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateMC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_UpdateMC.Location = new System.Drawing.Point(213, 406);
>>>>>>> Stashed changes
            this.btn_UpdateMC.Name = "btn_UpdateMC";
            this.btn_UpdateMC.Size = new System.Drawing.Size(38, 34);
            this.btn_UpdateMC.TabIndex = 19;
            this.btn_UpdateMC.UseVisualStyleBackColor = false;
            this.btn_UpdateMC.Click += new System.EventHandler(this.btn_UpdateMC_Click);
            // 
            // btn_AddMC
            // 
<<<<<<< Updated upstream
            this.btn_AddMC.BackColor = System.Drawing.Color.DimGray;
            this.btn_AddMC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AddMC.Location = new System.Drawing.Point(20, 382);
=======
            this.btn_AddMC.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_AddMC.BackgroundImage = global::SEN_381_Final_Project.Properties.Resources.add_circle_create_expand_new_plus_icon_1232181;
            this.btn_AddMC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AddMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddMC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AddMC.Location = new System.Drawing.Point(161, 405);
>>>>>>> Stashed changes
            this.btn_AddMC.Name = "btn_AddMC";
            this.btn_AddMC.Size = new System.Drawing.Size(37, 35);
            this.btn_AddMC.TabIndex = 18;
            this.btn_AddMC.UseVisualStyleBackColor = false;
            this.btn_AddMC.Click += new System.EventHandler(this.btn_AddMC_Click);
            // 
            // txt_MCName
            // 
            this.txt_MCName.Location = new System.Drawing.Point(93, 305);
            this.txt_MCName.Name = "txt_MCName";
            this.txt_MCName.Size = new System.Drawing.Size(300, 20);
            this.txt_MCName.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Name";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_Reload
            // 
            this.btn_Reload.BackColor = System.Drawing.Color.DimGray;
            this.btn_Reload.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Reload.Location = new System.Drawing.Point(329, 412);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(75, 23);
            this.btn_Reload.TabIndex = 29;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = false;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // btn_reload2
            // 
            this.btn_reload2.BackColor = System.Drawing.Color.DimGray;
            this.btn_reload2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_reload2.Location = new System.Drawing.Point(345, 382);
            this.btn_reload2.Name = "btn_reload2";
            this.btn_reload2.Size = new System.Drawing.Size(75, 23);
            this.btn_reload2.TabIndex = 30;
            this.btn_reload2.Text = "Reload";
            this.btn_reload2.UseVisualStyleBackColor = false;
            this.btn_reload2.Click += new System.EventHandler(this.btn_reload2_Click);
            // 
            // fMedical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1005, 527);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_provider);
            this.Controls.Add(this.btn_product);
            this.Controls.Add(this.btn_medical);
            this.Controls.Add(this.btn_clientpolicy);
            this.Controls.Add(this.btn_callcentre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMedical";
            this.Text = "Medical Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fMedical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Treatment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_provider;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_medical;
        private System.Windows.Forms.Button btn_clientpolicy;
        private System.Windows.Forms.Button btn_callcentre;
        private System.Windows.Forms.DataGridView dgv_Treatment;
        private System.Windows.Forms.DataGridView dgv_MC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TreatmentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_TreatmentMC;
        private System.Windows.Forms.TextBox txt_MCName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_SearchTreatment;
        private System.Windows.Forms.TextBox txt_TreatmentNameSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtxt_TreatmentDescription;
        private System.Windows.Forms.Button btn_DeleteTreatment;
        private System.Windows.Forms.Button btn_UpdateTreatment;
        private System.Windows.Forms.Button btn_AddTreatment;
        private System.Windows.Forms.Button btn_SearchMC;
        private System.Windows.Forms.TextBox txt_MCNameSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtxt_MCInformation;
        private System.Windows.Forms.Button btn_DeleteMC;
        private System.Windows.Forms.Button btn_UpdateMC;
        private System.Windows.Forms.Button btn_AddMC;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_TID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_CID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button btn_reload2;
    }
}