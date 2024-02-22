namespace Kelompok2Tugas
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelMenuTransaksi = new System.Windows.Forms.Panel();
            this.Category = new System.Windows.Forms.Button();
            this.Transaksi = new System.Windows.Forms.Button();
            this.panelMenuProduct = new System.Windows.Forms.Panel();
            this.categoryProduk = new System.Windows.Forms.Button();
            this.dataProduk = new System.Windows.Forms.Button();
            this.Product = new System.Windows.Forms.Button();
            this.Supplier = new System.Windows.Forms.Button();
            this.Customer = new System.Windows.Forms.Button();
            this.Pegawai = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Kelompok = new System.Windows.Forms.Label();
            this.panelJudul = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Button();
            this.Maximized = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.closeChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelMenuTransaksi.SuspendLayout();
            this.panelMenuProduct.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelJudul.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.panelMenuTransaksi);
            this.panelMenu.Controls.Add(this.Transaksi);
            this.panelMenu.Controls.Add(this.panelMenuProduct);
            this.panelMenu.Controls.Add(this.Product);
            this.panelMenu.Controls.Add(this.Supplier);
            this.panelMenu.Controls.Add(this.Customer);
            this.panelMenu.Controls.Add(this.Pegawai);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(241, 648);
            this.panelMenu.TabIndex = 1;
            // 
            // panelMenuTransaksi
            // 
            this.panelMenuTransaksi.Controls.Add(this.Category);
            this.panelMenuTransaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuTransaksi.Location = new System.Drawing.Point(0, 514);
            this.panelMenuTransaksi.Name = "panelMenuTransaksi";
            this.panelMenuTransaksi.Size = new System.Drawing.Size(241, 97);
            this.panelMenuTransaksi.TabIndex = 7;
            this.panelMenuTransaksi.Visible = false;
            // 
            // Category
            // 
            this.Category.Dock = System.Windows.Forms.DockStyle.Top;
            this.Category.FlatAppearance.BorderSize = 0;
            this.Category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.ForeColor = System.Drawing.Color.Gainsboro;
            this.Category.Image = ((System.Drawing.Image)(resources.GetObject("Category.Image")));
            this.Category.Location = new System.Drawing.Point(0, 0);
            this.Category.Name = "Category";
            this.Category.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Category.Size = new System.Drawing.Size(241, 60);
            this.Category.TabIndex = 6;
            this.Category.Text = "    Penjualan";
            this.Category.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Category.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Category.UseVisualStyleBackColor = true;
            // 
            // Transaksi
            // 
            this.Transaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.Transaksi.FlatAppearance.BorderSize = 0;
            this.Transaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Transaksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transaksi.ForeColor = System.Drawing.Color.Gainsboro;
            this.Transaksi.Image = ((System.Drawing.Image)(resources.GetObject("Transaksi.Image")));
            this.Transaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Transaksi.Location = new System.Drawing.Point(0, 449);
            this.Transaksi.Name = "Transaksi";
            this.Transaksi.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Transaksi.Size = new System.Drawing.Size(241, 65);
            this.Transaksi.TabIndex = 6;
            this.Transaksi.Text = "    Transaksi";
            this.Transaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Transaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Transaksi.UseVisualStyleBackColor = true;
            this.Transaksi.Click += new System.EventHandler(this.Transaksi_Click);
            // 
            // panelMenuProduct
            // 
            this.panelMenuProduct.Controls.Add(this.categoryProduk);
            this.panelMenuProduct.Controls.Add(this.dataProduk);
            this.panelMenuProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuProduct.Location = new System.Drawing.Point(0, 324);
            this.panelMenuProduct.Name = "panelMenuProduct";
            this.panelMenuProduct.Size = new System.Drawing.Size(241, 125);
            this.panelMenuProduct.TabIndex = 5;
            this.panelMenuProduct.Visible = false;
            // 
            // categoryProduk
            // 
            this.categoryProduk.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoryProduk.FlatAppearance.BorderSize = 0;
            this.categoryProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryProduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryProduk.ForeColor = System.Drawing.Color.Gainsboro;
            this.categoryProduk.Image = ((System.Drawing.Image)(resources.GetObject("categoryProduk.Image")));
            this.categoryProduk.Location = new System.Drawing.Point(0, 60);
            this.categoryProduk.Name = "categoryProduk";
            this.categoryProduk.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.categoryProduk.Size = new System.Drawing.Size(241, 60);
            this.categoryProduk.TabIndex = 6;
            this.categoryProduk.Text = "   Category Product";
            this.categoryProduk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryProduk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.categoryProduk.UseVisualStyleBackColor = true;
            this.categoryProduk.Click += new System.EventHandler(this.Category_Click);
            // 
            // dataProduk
            // 
            this.dataProduk.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataProduk.FlatAppearance.BorderSize = 0;
            this.dataProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataProduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataProduk.ForeColor = System.Drawing.Color.Gainsboro;
            this.dataProduk.Image = ((System.Drawing.Image)(resources.GetObject("dataProduk.Image")));
            this.dataProduk.Location = new System.Drawing.Point(0, 0);
            this.dataProduk.Name = "dataProduk";
            this.dataProduk.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.dataProduk.Size = new System.Drawing.Size(241, 60);
            this.dataProduk.TabIndex = 5;
            this.dataProduk.Text = "    Data Product";
            this.dataProduk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dataProduk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dataProduk.UseVisualStyleBackColor = true;
            this.dataProduk.Click += new System.EventHandler(this.dataProduk_Click);
            // 
            // Product
            // 
            this.Product.Dock = System.Windows.Forms.DockStyle.Top;
            this.Product.FlatAppearance.BorderSize = 0;
            this.Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product.ForeColor = System.Drawing.Color.Gainsboro;
            this.Product.Image = ((System.Drawing.Image)(resources.GetObject("Product.Image")));
            this.Product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Product.Location = new System.Drawing.Point(0, 259);
            this.Product.Name = "Product";
            this.Product.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Product.Size = new System.Drawing.Size(241, 65);
            this.Product.TabIndex = 4;
            this.Product.Text = "    Product";
            this.Product.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Product.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Product.UseVisualStyleBackColor = true;
            this.Product.Click += new System.EventHandler(this.Product_Click);
            // 
            // Supplier
            // 
            this.Supplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.Supplier.FlatAppearance.BorderSize = 0;
            this.Supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier.ForeColor = System.Drawing.Color.Gainsboro;
            this.Supplier.Image = ((System.Drawing.Image)(resources.GetObject("Supplier.Image")));
            this.Supplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Supplier.Location = new System.Drawing.Point(0, 194);
            this.Supplier.Name = "Supplier";
            this.Supplier.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Supplier.Size = new System.Drawing.Size(241, 65);
            this.Supplier.TabIndex = 3;
            this.Supplier.Text = "    Supplier";
            this.Supplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Supplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Supplier.UseVisualStyleBackColor = true;
            this.Supplier.Click += new System.EventHandler(this.Supplier_Click);
            // 
            // Customer
            // 
            this.Customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Customer.FlatAppearance.BorderSize = 0;
            this.Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer.ForeColor = System.Drawing.Color.Gainsboro;
            this.Customer.Image = ((System.Drawing.Image)(resources.GetObject("Customer.Image")));
            this.Customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Customer.Location = new System.Drawing.Point(0, 129);
            this.Customer.Name = "Customer";
            this.Customer.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Customer.Size = new System.Drawing.Size(241, 65);
            this.Customer.TabIndex = 2;
            this.Customer.Text = "   Costumer";
            this.Customer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Customer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Customer.UseVisualStyleBackColor = true;
            this.Customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // Pegawai
            // 
            this.Pegawai.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pegawai.FlatAppearance.BorderSize = 0;
            this.Pegawai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pegawai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pegawai.ForeColor = System.Drawing.Color.Gainsboro;
            this.Pegawai.Image = ((System.Drawing.Image)(resources.GetObject("Pegawai.Image")));
            this.Pegawai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Pegawai.Location = new System.Drawing.Point(0, 64);
            this.Pegawai.Name = "Pegawai";
            this.Pegawai.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Pegawai.Size = new System.Drawing.Size(241, 65);
            this.Pegawai.TabIndex = 1;
            this.Pegawai.Text = "    Pegawai";
            this.Pegawai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Pegawai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Pegawai.UseVisualStyleBackColor = true;
            this.Pegawai.Click += new System.EventHandler(this.Pegawai_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.Kelompok);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(241, 64);
            this.panelLogo.TabIndex = 0;
            // 
            // Kelompok
            // 
            this.Kelompok.AutoSize = true;
            this.Kelompok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kelompok.ForeColor = System.Drawing.Color.White;
            this.Kelompok.Location = new System.Drawing.Point(54, 23);
            this.Kelompok.Name = "Kelompok";
            this.Kelompok.Size = new System.Drawing.Size(92, 20);
            this.Kelompok.TabIndex = 0;
            this.Kelompok.Text = "Kelompok 2";
            // 
            // panelJudul
            // 
            this.panelJudul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelJudul.Controls.Add(this.Minimize);
            this.panelJudul.Controls.Add(this.Maximized);
            this.panelJudul.Controls.Add(this.Exit);
            this.panelJudul.Controls.Add(this.closeChildForm);
            this.panelJudul.Controls.Add(this.lblTitle);
            this.panelJudul.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelJudul.Location = new System.Drawing.Point(241, 0);
            this.panelJudul.Name = "panelJudul";
            this.panelJudul.Size = new System.Drawing.Size(717, 64);
            this.panelJudul.TabIndex = 2;
            this.panelJudul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelJudul_MouseDown);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(636, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(30, 40);
            this.Minimize.TabIndex = 4;
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Maximized
            // 
            this.Maximized.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Maximized.FlatAppearance.BorderSize = 0;
            this.Maximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximized.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maximized.ForeColor = System.Drawing.Color.White;
            this.Maximized.Image = ((System.Drawing.Image)(resources.GetObject("Maximized.Image")));
            this.Maximized.Location = new System.Drawing.Point(661, 0);
            this.Maximized.Name = "Maximized";
            this.Maximized.Size = new System.Drawing.Size(30, 40);
            this.Maximized.TabIndex = 3;
            this.Maximized.UseVisualStyleBackColor = true;
            this.Maximized.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(687, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(27, 40);
            this.Exit.TabIndex = 2;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // closeChildForm
            // 
            this.closeChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.closeChildForm.FlatAppearance.BorderSize = 0;
            this.closeChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeChildForm.ForeColor = System.Drawing.Color.White;
            this.closeChildForm.Location = new System.Drawing.Point(0, 0);
            this.closeChildForm.Name = "closeChildForm";
            this.closeChildForm.Size = new System.Drawing.Size(57, 64);
            this.closeChildForm.TabIndex = 1;
            this.closeChildForm.Text = "X";
            this.closeChildForm.UseVisualStyleBackColor = true;
            this.closeChildForm.Click += new System.EventHandler(this.closeChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(319, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(72, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(241, 64);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(717, 584);
            this.panelDesktop.TabIndex = 4;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 648);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelJudul);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.panelMenu.ResumeLayout(false);
            this.panelMenuTransaksi.ResumeLayout(false);
            this.panelMenuProduct.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelJudul.ResumeLayout(false);
            this.panelJudul.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelMenuProduct;
        private System.Windows.Forms.Button categoryProduk;
        private System.Windows.Forms.Button dataProduk;
        private System.Windows.Forms.Button Product;
        private System.Windows.Forms.Button Supplier;
        private System.Windows.Forms.Button Customer;
        private System.Windows.Forms.Button Pegawai;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label Kelompok;
        private System.Windows.Forms.Panel panelJudul;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Maximized;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button closeChildForm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMenuTransaksi;
        private System.Windows.Forms.Button Category;
        private System.Windows.Forms.Button Transaksi;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

