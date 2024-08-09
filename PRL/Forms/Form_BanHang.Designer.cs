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
            dgv_HD = new DataGridView();
            dgv_HDCT = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lb_MaHD = new Label();
            lb_TongTien = new Label();
            cbbvoucher = new ComboBox();
            cbb_Phone = new ComboBox();
            txt_Phone = new TextBox();
            txtName = new TextBox();
            btn_CreateBill = new Button();
            btn_ThanhToan = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_HD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_HDCT).BeginInit();
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
            lb_page.Location = new Point(544, 1071);
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
            // dgv_HD
            // 
            dgv_HD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HD.Location = new Point(1112, 275);
            dgv_HD.Name = "dgv_HD";
            dgv_HD.RowHeadersWidth = 82;
            dgv_HD.RowTemplate.Height = 41;
            dgv_HD.Size = new Size(1010, 261);
            dgv_HD.TabIndex = 5;
            dgv_HD.CellClick += dgv_HD_CellClick;
            // 
            // dgv_HDCT
            // 
            dgv_HDCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HDCT.Location = new Point(1121, 624);
            dgv_HDCT.Name = "dgv_HDCT";
            dgv_HDCT.RowHeadersWidth = 82;
            dgv_HDCT.RowTemplate.Height = 41;
            dgv_HDCT.Size = new Size(1020, 415);
            dgv_HDCT.TabIndex = 6;
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
            // lb_MaHD
            // 
            lb_MaHD.AutoSize = true;
            lb_MaHD.Location = new Point(1430, 16);
            lb_MaHD.Name = "lb_MaHD";
            lb_MaHD.Size = new Size(61, 32);
            lb_MaHD.TabIndex = 12;
            lb_MaHD.Text = "HDX";
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
            cbbvoucher.Location = new Point(1412, 165);
            cbbvoucher.Name = "cbbvoucher";
            cbbvoucher.Size = new Size(453, 40);
            cbbvoucher.TabIndex = 16;
            // 
            // cbb_Phone
            // 
            cbb_Phone.FormattingEnabled = true;
            cbb_Phone.Location = new Point(1784, 64);
            cbb_Phone.Name = "cbb_Phone";
            cbb_Phone.Size = new Size(324, 40);
            cbb_Phone.TabIndex = 15;
            cbb_Phone.SelectedIndexChanged += lb_Next_Click;
            cbb_Phone.TextChanged += cbbsdt_TextChanged;
            // 
            // txt_Phone
            // 
            txt_Phone.Location = new Point(1412, 64);
            txt_Phone.Name = "txt_Phone";
            txt_Phone.Size = new Size(335, 39);
            txt_Phone.TabIndex = 17;
            txt_Phone.TextChanged += txt_Phone_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(1412, 109);
            txtName.Name = "txtName";
            txtName.Size = new Size(335, 39);
            txtName.TabIndex = 18;
            // 
            // btn_CreateBill
            // 
            btn_CreateBill.BackColor = Color.FromArgb(224, 224, 224);
            btn_CreateBill.Location = new Point(1837, 12);
            btn_CreateBill.Name = "btn_CreateBill";
            btn_CreateBill.Size = new Size(271, 46);
            btn_CreateBill.TabIndex = 19;
            btn_CreateBill.Text = "Thêm mới 1 hóa đơn";
            btn_CreateBill.UseVisualStyleBackColor = false;
            btn_CreateBill.Click += btn_CreateBill_Click;
            // 
            // btn_ThanhToan
            // 
            btn_ThanhToan.Location = new Point(1789, 568);
            btn_ThanhToan.Name = "btn_ThanhToan";
            btn_ThanhToan.Size = new Size(333, 46);
            btn_ThanhToan.TabIndex = 20;
            btn_ThanhToan.Text = "Thanh toán";
            btn_ThanhToan.UseVisualStyleBackColor = true;
            btn_ThanhToan.Click += btn_ThanhToan_Click;
            // 
            // Form_BanHang
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2174, 1129);
            Controls.Add(btn_ThanhToan);
            Controls.Add(btn_CreateBill);
            Controls.Add(txtName);
            Controls.Add(txt_Phone);
            Controls.Add(cbbvoucher);
            Controls.Add(cbb_Phone);
            Controls.Add(lb_TongTien);
            Controls.Add(lb_MaHD);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgv_HDCT);
            Controls.Add(dgv_HD);
            Controls.Add(label1);
            Controls.Add(lb_Next);
            Controls.Add(lb_page);
            Controls.Add(lb_Back);
            Controls.Add(tlp_Product);
            Name = "Form_BanHang";
            Text = "Form_BanHang";
            Load += Form_BanHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_HD).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_HDCT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tlp_Product;
        private Label lb_Back;
        private Label lb_page;
        private Label lb_Next;
        private Label label1;
        private DataGridView dgv_HD;
        private DataGridView dgv_HDCT;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lb_MaHD;
        private Label lb_TongTien;
        private ComboBox cbbvoucher;
        private ComboBox cbb_Phone;
        private TextBox txt_Phone;
        private TextBox txtName;
        private Button btn_CreateBill;
        private Button btn_ThanhToan;
    }
}