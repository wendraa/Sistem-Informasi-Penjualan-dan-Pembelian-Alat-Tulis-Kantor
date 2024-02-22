namespace Kelompok2Tugas
{
    partial class Qty
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
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtJumlah
            // 
            this.txtJumlah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJumlah.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlah.Location = new System.Drawing.Point(0, 0);
            this.txtJumlah.Multiline = true;
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(140, 67);
            this.txtJumlah.TabIndex = 0;
            this.txtJumlah.Text = "1";
            this.txtJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Qty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(140, 67);
            this.Controls.Add(this.txtJumlah);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Qty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qty";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Qty_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJumlah;
    }
}