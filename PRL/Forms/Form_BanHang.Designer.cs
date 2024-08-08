namespace PRL.Forms
{
    partial class Form_BanHang
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
            tlp_Product = new TableLayoutPanel();
            lb_Back = new Label();
            lb_page = new Label();
            lb_Next = new Label();
            label1 = new Label();
            dgv_HoaDon = new DataGridView();
            dgv_HoaDonChiTiet = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lb_MaHd = new Label();
            lb_TongTien = new Label();
            cbbvoucher = new ComboBox();
            cbbsdt = new ComboBox();
            lb_TenKh = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_HoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_HoaDonChiTiet).BeginInit();
            SuspendLayout();
            // 
            // tlp_Product
            // 
            tlp_Product.ColumnCount = 2;
            tlp_Product.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_Product.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_Product.Location = new Point(58, 39);
            tlp_Product.Name = "tlp_Product";
            tlp_Product.RowCount = 2;
            tlp_Product.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_Product.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_Product.Size = new Size(1000, 1000);
            tlp_Product.TabIndex = 0;
            // 
            // lb_Back
            // 
            lb_Back.AutoSize = true;
            lb_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Back.Location = new Point(244, 1071);
            lb_Back.Name = "lb_Back";
            lb_Back.Size = new Size(65, 32);
            lb_Back.TabIndex = 1;
            lb_Back.Text = "<<<";
            lb_Back.Click += lb_Back_Click;
            // 
            // lb_page
            // 
            lb_page.AutoSize = true;
            lb_page.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_page.Location = new Point(540, 1071);
            lb_page.Name = "lb_page";
            lb_page.Size = new Size(28, 32);
            lb_page.TabIndex = 2;
            lb_page.Text = "1";
            // 
            // lb_Next
            // 
            lb_Next.AutoSize = true;
            lb_Next.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Next.Location = new Point(816, 1071);
            lb_Next.Name = "lb_Next";
            lb_Next.Size = new Size(65, 32);
            lb_Next.TabIndex = 3;
            lb_Next.Text = ">>>";
            lb_Next.Click += lb_Next_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1112, 575);
            label1.Name = "label1";
            label1.Size = new Size(397, 32);
            label1.TabIndex = 4;
            label1.Text = "Danh sách sản phẩm trong hóa đơn";
            // 
            // dgv_HoaDon
            // 
            dgv_HoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HoaDon.Location = new Point(1112, 275);
            dgv_HoaDon.Name = "dgv_HoaDon";
            dgv_HoaDon.RowHeadersWidth = 82;
            dgv_HoaDon.RowTemplate.Height = 41;
            dgv_HoaDon.Size = new Size(1010, 261);
            dgv_HoaDon.TabIndex = 5;
            // 
            // dgv_HoaDonChiTiet
            // 
            dgv_HoaDonChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HoaDonChiTiet.Location = new Point(1121, 624);
            dgv_HoaDonChiTiet.Name = "dgv_HoaDonChiTiet";
            dgv_HoaDonChiTiet.RowHeadersWidth = 82;
            dgv_HoaDonChiTiet.RowTemplate.Height = 41;
            dgv_HoaDonChiTiet.Size = new Size(1020, 415);
            dgv_HoaDonChiTiet.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1131, 17);
            label2.Name = "label2";
            label2.Size = new Size(89, 32);
            label2.TabIndex = 7;
            label2.Text = "Mã HĐ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1134, 71);
            label3.Name = "label3";
            label3.Size = new Size(188, 32);
            label3.TabIndex = 8;
            label3.Text = "SĐT khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1134, 124);
            label4.Name = "label4";
            label4.Size = new Size(183, 32);
            label4.TabIndex = 9;
            label4.Text = "Tên khách hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1134, 173);
            label5.Name = "label5";
            label5.Size = new Size(101, 32);
            label5.TabIndex = 10;
            label5.Text = "Voucher";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1134, 229);
            label6.Name = "label6";
            label6.Size = new Size(117, 32);
            label6.TabIndex = 11;
            label6.Text = "Tổng tiền";
            // 
            // lb_MaHd
            // 
            lb_MaHd.AutoSize = true;
            lb_MaHd.Location = new Point(1430, 16);
            lb_MaHd.Name = "lb_MaHd";
            lb_MaHd.Size = new Size(61, 32);
            lb_MaHd.TabIndex = 12;
            lb_MaHd.Text = "HDX";
            // 
            // lb_TongTien
            // 
            lb_TongTien.AutoSize = true;
            lb_TongTien.Location = new Point(1430, 216);
            lb_TongTien.Name = "lb_TongTien";
            lb_TongTien.Size = new Size(47, 32);
            lb_TongTien.TabIndex = 14;
            lb_TongTien.Text = "xxx";
            // 
            // cbbvoucher
            // 
            cbbvoucher.FormattingEnabled = true;
            cbbvoucher.Location = new Point(1424, 160);
            cbbvoucher.Name = "cbbvoucher";
            cbbvoucher.Size = new Size(453, 40);
            cbbvoucher.TabIndex = 16;
            // 
            // cbbsdt
            // 
            cbbsdt.FormattingEnabled = true;
            cbbsdt.Location = new Point(1427, 67);
            cbbsdt.Name = "cbbsdt";
            cbbsdt.Size = new Size(450, 40);
            cbbsdt.TabIndex = 15;
            // 
            // lb_TenKh
            // 
            lb_TenKh.AutoSize = true;
            lb_TenKh.Location = new Point(1418, 122);
            lb_TenKh.Name = "lb_TenKh";
            lb_TenKh.Size = new Size(156, 32);
            lb_TenKh.TabIndex = 13;
            lb_TenKh.Text = "Lê Văn Khách";
            // 
            // Form_BanHang
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2174, 1129);
            Controls.Add(cbbvoucher);
            Controls.Add(cbbsdt);
            Controls.Add(lb_TongTien);
            Controls.Add(lb_TenKh);
            Controls.Add(lb_MaHd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgv_HoaDonChiTiet);
            Controls.Add(dgv_HoaDon);
            Controls.Add(label1);
            Controls.Add(lb_Next);
            Controls.Add(lb_page);
            Controls.Add(lb_Back);
            Controls.Add(tlp_Product);
            Name = "Form_BanHang";
            Text = "Form_BanHang";
            Load += Form_BanHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_HoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_HoaDonChiTiet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tlp_Product;
        private Label lb_Back;
        private Label lb_page;
        private Label lb_Next;
        private Label label1;
        private DataGridView dgv_HoaDon;
        private DataGridView dgv_HoaDonChiTiet;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lb_MaHd;
        private Label lb_TongTien;
        private ComboBox cbbvoucher;
        private ComboBox cbbsdt;
        private Label lb_TenKh;
    }
}