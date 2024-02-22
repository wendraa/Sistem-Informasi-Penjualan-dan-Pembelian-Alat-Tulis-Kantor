namespace Kelompok2Tugas
{
    partial class Pegawai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pegawai));
            this.dataPegawai = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelTambah = new System.Windows.Forms.Panel();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataPegawai)).BeginInit();
            this.panelTambah.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataPegawai
            // 
            this.dataPegawai.AllowUserToAddRows = false;
            this.dataPegawai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataPegawai.ColumnHeadersHeight = 30;
            this.dataPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataPegawai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Edit,
            this.Delete});
            this.dataPegawai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPegawai.EnableHeadersVisualStyles = false;
            this.dataPegawai.Location = new System.Drawing.Point(0, 0);
            this.dataPegawai.Name = "dataPegawai";
            this.dataPegawai.RowHeadersVisible = false;
            this.dataPegawai.RowHeadersWidth = 50;
            this.dataPegawai.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataPegawai.Size = new System.Drawing.Size(800, 450);
            this.dataPegawai.TabIndex = 1;
            this.dataPegawai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPegawai_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            this.Column1.Width = 44;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "ID Pegawai";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Nama Pegawai";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Posisi Pegawai";
            this.Column4.Name = "Column4";
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            this.Edit.Width = 5;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.Width = 5;
            // 
            // panelTambah
            // 
            this.panelTambah.Controls.Add(this.Add);
            this.panelTambah.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTambah.Location = new System.Drawing.Point(0, 403);
            this.panelTambah.Name = "panelTambah";
            this.panelTambah.Size = new System.Drawing.Size(800, 47);
            this.panelTambah.TabIndex = 4;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.Control;
            this.Add.Dock = System.Windows.Forms.DockStyle.Left;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.Location = new System.Drawing.Point(0, 0);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(55, 47);
            this.Add.TabIndex = 0;
            this.Add.Text = "&D";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Pegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTambah);
            this.Controls.Add(this.dataPegawai);
            this.Name = "Pegawai";
            this.Text = "Pegawai";
            ((System.ComponentModel.ISupportInitialize)(this.dataPegawai)).EndInit();
            this.panelTambah.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataPegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Panel panelTambah;
        private System.Windows.Forms.Button Add;
    }
}