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
            this.btn_callcentre = new System.Windows.Forms.Button();
            this.btn_clientpolicy = new System.Windows.Forms.Button();
            this.btn_medical = new System.Windows.Forms.Button();
            this.btn_product = new System.Windows.Forms.Button();
            this.btn_provider = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_callcentre
            // 
            this.btn_callcentre.Location = new System.Drawing.Point(23, 30);
            this.btn_callcentre.Name = "btn_callcentre";
            this.btn_callcentre.Size = new System.Drawing.Size(75, 23);
            this.btn_callcentre.TabIndex = 0;
            this.btn_callcentre.Text = "Call Centre";
            this.btn_callcentre.UseVisualStyleBackColor = true;
            // 
            // btn_clientpolicy
            // 
            this.btn_clientpolicy.Location = new System.Drawing.Point(23, 99);
            this.btn_clientpolicy.Name = "btn_clientpolicy";
            this.btn_clientpolicy.Size = new System.Drawing.Size(87, 23);
            this.btn_clientpolicy.TabIndex = 1;
            this.btn_clientpolicy.Text = "Management";
            this.btn_clientpolicy.UseVisualStyleBackColor = true;
            // 
            // btn_medical
            // 
            this.btn_medical.Location = new System.Drawing.Point(23, 178);
            this.btn_medical.Name = "btn_medical";
            this.btn_medical.Size = new System.Drawing.Size(75, 23);
            this.btn_medical.TabIndex = 2;
            this.btn_medical.Text = "Medical";
            this.btn_medical.UseVisualStyleBackColor = true;
            // 
            // btn_product
            // 
            this.btn_product.Location = new System.Drawing.Point(23, 267);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(75, 23);
            this.btn_product.TabIndex = 3;
            this.btn_product.Text = "Product";
            this.btn_product.UseVisualStyleBackColor = true;
            // 
            // btn_provider
            // 
            this.btn_provider.Location = new System.Drawing.Point(23, 351);
            this.btn_provider.Name = "btn_provider";
            this.btn_provider.Size = new System.Drawing.Size(75, 23);
            this.btn_provider.TabIndex = 4;
            this.btn_provider.Text = "Provider";
            this.btn_provider.UseVisualStyleBackColor = true;
            this.btn_provider.Click += new System.EventHandler(this.btn_provider_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fCall_Center
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_provider);
            this.Controls.Add(this.btn_product);
            this.Controls.Add(this.btn_medical);
            this.Controls.Add(this.btn_clientpolicy);
            this.Controls.Add(this.btn_callcentre);
            this.Name = "fCall_Center";
            this.Text = "fCall_Center";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_callcentre;
        private System.Windows.Forms.Button btn_clientpolicy;
        private System.Windows.Forms.Button btn_medical;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_provider;
        private System.Windows.Forms.Button button1;
    }
}