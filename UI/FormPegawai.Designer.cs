namespace projek
{
    partial class FormPegawai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPegawai));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.update = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.GroupBox();
            this.namPeg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idPeg = new System.Windows.Forms.TextBox();
            this.posPeg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Hapus = new System.Windows.Forms.Button();
            this.DataPegawai = new System.Windows.Forms.DataGridView();
            this.Save = new System.Windows.Forms.Button();
            this.Pegawai = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPegawai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pegawai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Pegawai";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(792, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.input);
            this.panel1.Controls.Add(this.Hapus);
            this.panel1.Controls.Add(this.DataPegawai);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Location = new System.Drawing.Point(-25, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 370);
            this.panel1.TabIndex = 12;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Coral;
            this.update.Enabled = false;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(139, 283);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 26;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Coral;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.Location = new System.Drawing.Point(220, 329);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 24;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.Coral;
            this.Edit.Enabled = false;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.Color.White;
            this.Edit.Location = new System.Drawing.Point(139, 329);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 23;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Coral;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(58, 329);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 22;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // input
            // 
            this.input.Controls.Add(this.namPeg);
            this.input.Controls.Add(this.label2);
            this.input.Controls.Add(this.idPeg);
            this.input.Controls.Add(this.posPeg);
            this.input.Controls.Add(this.label4);
            this.input.Controls.Add(this.label3);
            this.input.Enabled = false;
            this.input.Location = new System.Drawing.Point(58, 20);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(237, 223);
            this.input.TabIndex = 21;
            this.input.TabStop = false;
            // 
            // namPeg
            // 
            this.namPeg.Location = new System.Drawing.Point(11, 113);
            this.namPeg.Name = "namPeg";
            this.namPeg.Size = new System.Drawing.Size(190, 20);
            this.namPeg.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "ID Pegawai";
            // 
            // idPeg
            // 
            this.idPeg.Location = new System.Drawing.Point(11, 49);
            this.idPeg.Name = "idPeg";
            this.idPeg.Size = new System.Drawing.Size(89, 20);
            this.idPeg.TabIndex = 22;
            // 
            // posPeg
            // 
            this.posPeg.Location = new System.Drawing.Point(11, 168);
            this.posPeg.Name = "posPeg";
            this.posPeg.Size = new System.Drawing.Size(190, 20);
            this.posPeg.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(8, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Posisi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(8, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nama Pegawai";
            // 
            // Hapus
            // 
            this.Hapus.BackColor = System.Drawing.Color.Coral;
            this.Hapus.Enabled = false;
            this.Hapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Hapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hapus.ForeColor = System.Drawing.Color.White;
            this.Hapus.Location = new System.Drawing.Point(220, 283);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(75, 23);
            this.Hapus.TabIndex = 21;
            this.Hapus.Text = "Hapus";
            this.Hapus.UseVisualStyleBackColor = false;
            this.Hapus.Click += new System.EventHandler(this.Hapus_Click);
            // 
            // DataPegawai
            // 
            this.DataPegawai.AllowUserToAddRows = false;
            this.DataPegawai.AllowUserToDeleteRows = false;
            this.DataPegawai.BackgroundColor = System.Drawing.Color.White;
            this.DataPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPegawai.GridColor = System.Drawing.Color.White;
            this.DataPegawai.Location = new System.Drawing.Point(375, 27);
            this.DataPegawai.Name = "DataPegawai";
            this.DataPegawai.ReadOnly = true;
            this.DataPegawai.Size = new System.Drawing.Size(418, 297);
            this.DataPegawai.TabIndex = 19;
            this.DataPegawai.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataPegawai_CellMouseClick);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Coral;
            this.Save.Enabled = false;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(58, 283);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 19;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Tambah_Click);
            // 
            // Pegawai
            // 
            this.Pegawai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pegawai.BackColor = System.Drawing.Color.Transparent;
            this.Pegawai.Image = ((System.Drawing.Image)(resources.GetObject("Pegawai.Image")));
            this.Pegawai.Location = new System.Drawing.Point(6, 0);
            this.Pegawai.Name = "Pegawai";
            this.Pegawai.Size = new System.Drawing.Size(38, 38);
            this.Pegawai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pegawai.TabIndex = 22;
            this.Pegawai.TabStop = false;
            // 
            // FormPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(822, 445);
            this.Controls.Add(this.Pegawai);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPegawai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pegawai";
            this.Load += new System.EventHandler(this.FormPegawai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.input.ResumeLayout(false);
            this.input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPegawai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pegawai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Hapus;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.PictureBox Pegawai;
        private System.Windows.Forms.DataGridView DataPegawai;
        private System.Windows.Forms.GroupBox input;
        private System.Windows.Forms.TextBox namPeg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idPeg;
        private System.Windows.Forms.TextBox posPeg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button update;
    }
}