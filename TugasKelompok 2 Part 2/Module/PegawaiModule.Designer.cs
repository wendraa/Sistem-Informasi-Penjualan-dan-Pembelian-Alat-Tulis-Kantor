namespace Kelompok2Tugas
{
    partial class PegawaiModule
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
            this.panelPegawaiModul = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idPeg = new System.Windows.Forms.TextBox();
            this.namPeg = new System.Windows.Forms.TextBox();
            this.posPeg = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.labelPegawai = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.panelPegawaiModul.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPegawaiModul
            // 
            this.panelPegawaiModul.Controls.Add(this.Exit);
            this.panelPegawaiModul.Controls.Add(this.labelPegawai);
            this.panelPegawaiModul.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPegawaiModul.Location = new System.Drawing.Point(0, 0);
            this.panelPegawaiModul.Name = "panelPegawaiModul";
            this.panelPegawaiModul.Size = new System.Drawing.Size(577, 55);
            this.panelPegawaiModul.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Pegawai";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Pegawai";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Posisi Pegawai";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // idPeg
            // 
            this.idPeg.Location = new System.Drawing.Point(179, 92);
            this.idPeg.Name = "idPeg";
            this.idPeg.Size = new System.Drawing.Size(96, 20);
            this.idPeg.TabIndex = 4;
            this.idPeg.TextChanged += new System.EventHandler(this.idPeg_TextChanged);
            // 
            // namPeg
            // 
            this.namPeg.Location = new System.Drawing.Point(179, 130);
            this.namPeg.Name = "namPeg";
            this.namPeg.Size = new System.Drawing.Size(197, 20);
            this.namPeg.TabIndex = 5;
            this.namPeg.TextChanged += new System.EventHandler(this.namPeg_TextChanged);
            // 
            // posPeg
            // 
            this.posPeg.Location = new System.Drawing.Point(179, 173);
            this.posPeg.Name = "posPeg";
            this.posPeg.Size = new System.Drawing.Size(197, 20);
            this.posPeg.TabIndex = 6;
            this.posPeg.TextChanged += new System.EventHandler(this.posPeg_TextChanged);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Blue;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(277, 259);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(81, 26);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.Location = new System.Drawing.Point(375, 259);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(81, 26);
            this.Update.TabIndex = 8;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Gainsboro;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.Black;
            this.Cancel.Location = new System.Drawing.Point(469, 259);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(81, 26);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // labelPegawai
            // 
            this.labelPegawai.AutoSize = true;
            this.labelPegawai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPegawai.Location = new System.Drawing.Point(21, 18);
            this.labelPegawai.Name = "labelPegawai";
            this.labelPegawai.Size = new System.Drawing.Size(124, 24);
            this.labelPegawai.TabIndex = 0;
            this.labelPegawai.Text = "Data Pegawai";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(546, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(28, 24);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // PegawaiModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 308);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.posPeg);
            this.Controls.Add(this.namPeg);
            this.Controls.Add(this.idPeg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelPegawaiModul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PegawaiModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PegawaiModule";
            this.panelPegawaiModul.ResumeLayout(false);
            this.panelPegawaiModul.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPegawaiModul;
        private System.Windows.Forms.Label labelPegawai;
        private System.Windows.Forms.Button Exit;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox idPeg;
        public System.Windows.Forms.TextBox namPeg;
        public System.Windows.Forms.TextBox posPeg;
        public System.Windows.Forms.Button Save;
        public System.Windows.Forms.Button Update;
        public System.Windows.Forms.Button Cancel;
    }
}