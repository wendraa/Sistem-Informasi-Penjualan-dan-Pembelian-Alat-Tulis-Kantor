namespace Kelompok2Tugas
{
    partial class ProductModule
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
            this.panelJudul = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.labelProduct = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cancel = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.namPrdk = new System.Windows.Forms.TextBox();
            this.idPrdk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comCat = new System.Windows.Forms.ComboBox();
            this.harPrdk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.updPrdk = new System.Windows.Forms.NumericUpDown();
            this.panelJudul.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updPrdk)).BeginInit();
            this.SuspendLayout();
            // 
            // panelJudul
            // 
            this.panelJudul.Controls.Add(this.Exit);
            this.panelJudul.Controls.Add(this.labelProduct);
            this.panelJudul.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelJudul.Location = new System.Drawing.Point(0, 0);
            this.panelJudul.Name = "panelJudul";
            this.panelJudul.Size = new System.Drawing.Size(644, 62);
            this.panelJudul.TabIndex = 4;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(618, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(26, 22);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.Location = new System.Drawing.Point(31, 24);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(135, 22);
            this.labelProduct.TabIndex = 0;
            this.labelProduct.Text = "Data Product";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Cancel);
            this.panel2.Controls.Add(this.update);
            this.panel2.Controls.Add(this.Save);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 52);
            this.panel2.TabIndex = 5;
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Location = new System.Drawing.Point(548, 17);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            // 
            // update
            // 
            this.update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.ForeColor = System.Drawing.Color.Gainsboro;
            this.update.Location = new System.Drawing.Point(457, 17);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 8;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.BackColor = System.Drawing.Color.Blue;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.ForeColor = System.Drawing.Color.Gainsboro;
            this.Save.Location = new System.Drawing.Point(363, 17);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // namPrdk
            // 
            this.namPrdk.Location = new System.Drawing.Point(197, 145);
            this.namPrdk.Name = "namPrdk";
            this.namPrdk.Size = new System.Drawing.Size(191, 20);
            this.namPrdk.TabIndex = 25;
            // 
            // idPrdk
            // 
            this.idPrdk.Enabled = false;
            this.idPrdk.Location = new System.Drawing.Point(197, 102);
            this.idPrdk.Name = "idPrdk";
            this.idPrdk.Size = new System.Drawing.Size(100, 20);
            this.idPrdk.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nama Product       :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID Product              :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Category Product  :";
            // 
            // comCat
            // 
            this.comCat.FormattingEnabled = true;
            this.comCat.Location = new System.Drawing.Point(197, 192);
            this.comCat.Name = "comCat";
            this.comCat.Size = new System.Drawing.Size(191, 21);
            this.comCat.TabIndex = 27;
            // 
            // harPrdk
            // 
            this.harPrdk.Location = new System.Drawing.Point(197, 238);
            this.harPrdk.Name = "harPrdk";
            this.harPrdk.Size = new System.Drawing.Size(191, 20);
            this.harPrdk.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Harga Product       :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Jumlah Product     :";
            // 
            // updPrdk
            // 
            this.updPrdk.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updPrdk.Location = new System.Drawing.Point(197, 286);
            this.updPrdk.Name = "updPrdk";
            this.updPrdk.Size = new System.Drawing.Size(120, 23);
            this.updPrdk.TabIndex = 31;
            this.updPrdk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updPrdk.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ProductModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 402);
            this.Controls.Add(this.updPrdk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.harPrdk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namPrdk);
            this.Controls.Add(this.idPrdk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelJudul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductModule";
            this.panelJudul.ResumeLayout(false);
            this.panelJudul.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.updPrdk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelJudul;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Cancel;
        public System.Windows.Forms.Button update;
        public System.Windows.Forms.Button Save;
        public System.Windows.Forms.TextBox namPrdk;
        public System.Windows.Forms.TextBox idPrdk;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox harPrdk;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comCat;
        public System.Windows.Forms.NumericUpDown updPrdk;
    }
}