namespace SEN_381_Final_Project
{
    partial class fCall_Center
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCall_Center));
            this.btn_callcentre = new System.Windows.Forms.Button();
            this.btn_clientpolicy = new System.Windows.Forms.Button();
            this.btn_medical = new System.Windows.Forms.Button();
            this.btn_product = new System.Windows.Forms.Button();
            this.btn_provider = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CallTimeSecondsLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CallTimeMinutesLabel = new System.Windows.Forms.Label();
            this.txt_ClientID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_endCall = new System.Windows.Forms.Button();
            this.btn_StartCall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Client = new System.Windows.Forms.DataGridView();
            this.btn_approve = new System.Windows.Forms.Button();
            this.btn_decline = new System.Windows.Forms.Button();
            this.btn_pending = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_Provider = new System.Windows.Forms.ComboBox();
            this.cb_Treatment = new System.Windows.Forms.ComboBox();
            this.cb_Condition = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.call_timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Client)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_callcentre
            // 
            this.btn_callcentre.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_callcentre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_callcentre.Location = new System.Drawing.Point(257, 11);
            this.btn_callcentre.Name = "btn_callcentre";
            this.btn_callcentre.Size = new System.Drawing.Size(75, 24);
            this.btn_callcentre.TabIndex = 0;
            this.btn_callcentre.Text = "Call Centre";
            this.btn_callcentre.UseVisualStyleBackColor = false;
            this.btn_callcentre.Click += new System.EventHandler(this.btn_callcentre_Click);
            // 
            // btn_clientpolicy
            // 
            this.btn_clientpolicy.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_clientpolicy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientpolicy.Location = new System.Drawing.Point(402, 11);
            this.btn_clientpolicy.Name = "btn_clientpolicy";
            this.btn_clientpolicy.Size = new System.Drawing.Size(87, 24);
            this.btn_clientpolicy.TabIndex = 1;
            this.btn_clientpolicy.Text = "Management";
            this.btn_clientpolicy.UseVisualStyleBackColor = false;
            this.btn_clientpolicy.Click += new System.EventHandler(this.btn_clientpolicy_Click);
            // 
            // btn_medical
            // 
            this.btn_medical.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_medical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_medical.Location = new System.Drawing.Point(580, 11);
            this.btn_medical.Name = "btn_medical";
            this.btn_medical.Size = new System.Drawing.Size(75, 24);
            this.btn_medical.TabIndex = 2;
            this.btn_medical.Text = "Medical";
            this.btn_medical.UseVisualStyleBackColor = false;
            this.btn_medical.Click += new System.EventHandler(this.btn_medical_Click);
            // 
            // btn_product
            // 
            this.btn_product.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_product.Location = new System.Drawing.Point(740, 12);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(75, 24);
            this.btn_product.TabIndex = 3;
            this.btn_product.Text = "Product";
            this.btn_product.UseVisualStyleBackColor = false;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // btn_provider
            // 
            this.btn_provider.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_provider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_provider.Location = new System.Drawing.Point(924, 12);
            this.btn_provider.Name = "btn_provider";
            this.btn_provider.Size = new System.Drawing.Size(75, 24);
            this.btn_provider.TabIndex = 4;
            this.btn_provider.Text = "Provider";
            this.btn_provider.UseVisualStyleBackColor = false;
            this.btn_provider.Click += new System.EventHandler(this.btn_provider_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CallTimeSecondsLabel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CallTimeMinutesLabel);
            this.groupBox1.Controls.Add(this.txt_ClientID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_endCall);
            this.groupBox1.Controls.Add(this.btn_StartCall);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(453, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 198);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // CallTimeSecondsLabel
            // 
            this.CallTimeSecondsLabel.AutoSize = true;
            this.CallTimeSecondsLabel.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CallTimeSecondsLabel.Location = new System.Drawing.Point(181, 69);
            this.CallTimeSecondsLabel.Name = "CallTimeSecondsLabel";
            this.CallTimeSecondsLabel.Size = new System.Drawing.Size(45, 36);
            this.CallTimeSecondsLabel.TabIndex = 10;
            this.CallTimeSecondsLabel.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(164, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 33);
            this.label9.TabIndex = 9;
            this.label9.Text = ":";
            // 
            // CallTimeMinutesLabel
            // 
            this.CallTimeMinutesLabel.AutoSize = true;
            this.CallTimeMinutesLabel.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CallTimeMinutesLabel.Location = new System.Drawing.Point(141, 69);
            this.CallTimeMinutesLabel.Name = "CallTimeMinutesLabel";
            this.CallTimeMinutesLabel.Size = new System.Drawing.Size(30, 36);
            this.CallTimeMinutesLabel.TabIndex = 8;
            this.CallTimeMinutesLabel.Text = "0";
            // 
            // txt_ClientID
            // 
            this.txt_ClientID.Location = new System.Drawing.Point(136, 151);
            this.txt_ClientID.Name = "txt_ClientID";
            this.txt_ClientID.Size = new System.Drawing.Size(100, 20);
            this.txt_ClientID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Client ID to Call";
            // 
            // btn_endCall
            // 
            this.btn_endCall.BackgroundImage = global::SEN_381_Final_Project.Properties.Resources.ic_call_end_128_28144;
            this.btn_endCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_endCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_endCall.Location = new System.Drawing.Point(264, 69);
            this.btn_endCall.Name = "btn_endCall";
            this.btn_endCall.Size = new System.Drawing.Size(75, 73);
            this.btn_endCall.TabIndex = 2;
            this.btn_endCall.UseVisualStyleBackColor = true;
            this.btn_endCall.Click += new System.EventHandler(this.btn_endCall_Click);
            // 
            // btn_StartCall
            // 
            this.btn_StartCall.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_StartCall.BackgroundImage = global::SEN_381_Final_Project.Properties.Resources.ic_call_128_28145;
            this.btn_StartCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_StartCall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_StartCall.ForeColor = System.Drawing.Color.Transparent;
            this.btn_StartCall.Location = new System.Drawing.Point(28, 69);
            this.btn_StartCall.Name = "btn_StartCall";
            this.btn_StartCall.Size = new System.Drawing.Size(73, 73);
            this.btn_StartCall.TabIndex = 1;
            this.btn_StartCall.UseVisualStyleBackColor = false;
            this.btn_StartCall.Click += new System.EventHandler(this.btn_StartCall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Call A Client";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Name);
            this.groupBox2.Controls.Add(this.txt_Surname);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dgv_Client);
            this.groupBox2.Location = new System.Drawing.Point(98, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 303);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client Details";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(90, 20);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(137, 20);
            this.txt_Name.TabIndex = 5;
            // 
            // txt_Surname
            // 
            this.txt_Surname.Location = new System.Drawing.Point(90, 48);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(137, 20);
            this.txt_Surname.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Client Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Client Name";
            // 
            // dgv_Client
            // 
            this.dgv_Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Client.Location = new System.Drawing.Point(6, 84);
            this.dgv_Client.Name = "dgv_Client";
            this.dgv_Client.Size = new System.Drawing.Size(520, 213);
            this.dgv_Client.TabIndex = 0;
            this.dgv_Client.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Client_CellClick);
            // 
            // btn_approve
            // 
            this.btn_approve.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_approve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_approve.Location = new System.Drawing.Point(114, 622);
            this.btn_approve.Name = "btn_approve";
            this.btn_approve.Size = new System.Drawing.Size(91, 23);
            this.btn_approve.TabIndex = 7;
            this.btn_approve.Text = "Approve";
            this.btn_approve.UseVisualStyleBackColor = false;
            this.btn_approve.Click += new System.EventHandler(this.btn_approve_Click);
            // 
            // btn_decline
            // 
            this.btn_decline.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_decline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_decline.Location = new System.Drawing.Point(221, 622);
            this.btn_decline.Name = "btn_decline";
            this.btn_decline.Size = new System.Drawing.Size(91, 23);
            this.btn_decline.TabIndex = 8;
            this.btn_decline.Text = "Decline";
            this.btn_decline.UseVisualStyleBackColor = false;
            this.btn_decline.Click += new System.EventHandler(this.btn_decline_Click);
            // 
            // btn_pending
            // 
            this.btn_pending.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_pending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pending.Location = new System.Drawing.Point(325, 622);
            this.btn_pending.Name = "btn_pending";
            this.btn_pending.Size = new System.Drawing.Size(91, 23);
            this.btn_pending.TabIndex = 9;
            this.btn_pending.Text = "Pending";
            this.btn_pending.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_Provider);
            this.groupBox3.Controls.Add(this.cb_Treatment);
            this.groupBox3.Controls.Add(this.cb_Condition);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(652, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(545, 344);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Claim Details";
            // 
            // cb_Provider
            // 
            this.cb_Provider.FormattingEnabled = true;
            this.cb_Provider.Location = new System.Drawing.Point(331, 33);
            this.cb_Provider.Name = "cb_Provider";
            this.cb_Provider.Size = new System.Drawing.Size(121, 21);
            this.cb_Provider.TabIndex = 10;
            // 
            // cb_Treatment
            // 
            this.cb_Treatment.FormattingEnabled = true;
            this.cb_Treatment.Location = new System.Drawing.Point(88, 81);
            this.cb_Treatment.Name = "cb_Treatment";
            this.cb_Treatment.Size = new System.Drawing.Size(121, 21);
            this.cb_Treatment.TabIndex = 11;
            // 
            // cb_Condition
            // 
            this.cb_Condition.FormattingEnabled = true;
            this.cb_Condition.Location = new System.Drawing.Point(88, 33);
            this.cb_Condition.Name = "cb_Condition";
            this.cb_Condition.Size = new System.Drawing.Size(121, 21);
            this.cb_Condition.TabIndex = 5;
            this.cb_Condition.SelectedIndexChanged += new System.EventHandler(this.cb_Condition_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Provider";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Treatment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Condition";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 125);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(520, 213);
            this.dataGridView2.TabIndex = 1;
            // 
            // call_timer
            // 
            this.call_timer.Interval = 1000;
            this.call_timer.Tick += new System.EventHandler(this.call_timer_Tick_1);
            // 
            // fCall_Center
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1261, 655);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_pending);
            this.Controls.Add(this.btn_decline);
            this.Controls.Add(this.btn_approve);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_provider);
            this.Controls.Add(this.btn_product);
            this.Controls.Add(this.btn_medical);
            this.Controls.Add(this.btn_clientpolicy);
            this.Controls.Add(this.btn_callcentre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fCall_Center";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Call Center ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Client)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_callcentre;
        private System.Windows.Forms.Button btn_clientpolicy;
        private System.Windows.Forms.Button btn_medical;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_provider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_endCall;
        private System.Windows.Forms.Button btn_StartCall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ClientID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_Client;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button btn_approve;
        private System.Windows.Forms.Button btn_decline;
        private System.Windows.Forms.Button btn_pending;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cb_Provider;
        private System.Windows.Forms.ComboBox cb_Treatment;
        private System.Windows.Forms.ComboBox cb_Condition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label CallTimeSecondsLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label CallTimeMinutesLabel;
        private System.Windows.Forms.Timer call_timer;
    }
}