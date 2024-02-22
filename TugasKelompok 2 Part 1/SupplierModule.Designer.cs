namespace Kelompok2Tugas
{
    partial class SupplierModule
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
            this.labelPegawai = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cancel = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.alaSup = new System.Windows.Forms.TextBox();
            this.namSup = new System.Windows.Forms.TextBox();
            this.idSup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.noSup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelJudul.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelJudul
            // 
            this.panelJudul.Controls.Add(this.Exit);
            this.panelJudul.Controls.Add(this.labelPegawai);
            this.panelJudul.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelJudul.Location = new System.Drawing.Point(0, 0);
            this.panelJudul.Name = "panelJudul";
            this.panelJudul.Size = new System.Drawing.Size(457, 62);
            this.panelJudul.TabIndex = 1;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(428, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(26, 22);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // labelPegawai
            // 
            this.labelPegawai.AutoSize = true;
            this.labelPegawai.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPegawai.Location = new System.Drawing.Point(31, 24);
            this.labelPegawai.Name = "labelPegawai";
            this.labelPegawai.Size = new System.Drawing.Size(133, 22);
            this.labelPegawai.TabIndex = 0;
            this.labelPegawai.Text = "Data Supplier";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Cancel);
            this.panel2.Controls.Add(this.update);
            this.panel2.Controls.Add(this.Save);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 52);
            this.panel2.TabIndex = 2;
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Location = new System.Drawing.Point(361, 17);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // update
            // 
            this.update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.ForeColor = System.Drawing.Color.Gainsboro;
            this.update.Location = new System.Drawing.Point(270, 17);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 8;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.BackColor = System.Drawing.Color.Blue;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.ForeColor = System.Drawing.Color.Gainsboro;
            this.Save.Location = new System.Drawing.Point(176, 17);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // alaSup
            // 
            this.alaSup.Location = new System.Drawing.Point(185, 184);
            this.alaSup.Name = "alaSup";
            this.alaSup.Size = new System.Drawing.Size(191, 20);
            this.alaSup.TabIndex = 12;
            // 
            // namSup
            // 
            this.namSup.Location = new System.Drawing.Point(185, 139);
            this.namSup.Name = "namSup";
            this.namSup.Size = new System.Drawing.Size(191, 20);
            this.namSup.TabIndex = 11;
            // 
            // idSup
            // 
            this.idSup.Enabled = false;
            this.idSup.Location = new System.Drawing.Point(185, 96);
            this.idSup.Name = "idSup";
            this.idSup.Size = new System.Drawing.Size(100, 20);
            this.idSup.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Alamat Supplier    :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nama Supplier      :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID Supplier             :";
            // 
            // noSup
            // 
            this.noSup.Location = new System.Drawing.Point(185, 227);
            this.noSup.Name = "noSup";
            this.noSup.Size = new System.Drawing.Size(191, 20);
            this.noSup.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nomor Supplier     :";
            // 
            // SupplierModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 355);
            this.Controls.Add(this.noSup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alaSup);
            this.Controls.Add(this.namSup);
            this.Controls.Add(this.idSup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelJudul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupplierModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplierModule";
            this.panelJudul.ResumeLayout(false);
            this.panelJudul.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelJudul;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label labelPegawai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Cancel;
        public System.Windows.Forms.TextBox alaSup;
        public System.Windows.Forms.TextBox namSup;
        public System.Windows.Forms.TextBox idSup;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox noSup;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button update;
        public System.Windows.Forms.Button Save;
    }
}