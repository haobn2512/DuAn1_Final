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
            components = new System.ComponentModel.Container();
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
            label6 = new Label();
            lb_MaHD = new Label();
            lb_TongTien = new Label();
            cbb_Phone = new ComboBox();
            txt_Phone = new TextBox();
            txtName = new TextBox();
            btn_CreateBill = new Button();
            btn_ThanhToan = new Button();
            lb_Time = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            label7 = new Label();
            txt_khachdua = new TextBox();
            lb_TienThua = new Label();
            lbCreate = new Label();
            lb_Accountid = new Label();
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
            label1.Location = new Point(1117, 284);
            label1.Name = "label1";
            label1.Size = new Size(397, 32);
            label1.TabIndex = 4;
            label1.Text = "Danh sách sản phẩm trong hóa đơn";
            // 
            // dgv_HD
            // 
            dgv_HD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_HD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HD.Location = new Point(1117, 824);
            dgv_HD.Name = "dgv_HD";
            dgv_HD.RowHeadersWidth = 82;
            dgv_HD.RowTemplate.Height = 41;
            dgv_HD.Size = new Size(1193, 335);
            dgv_HD.TabIndex = 5;
            dgv_HD.CellClick += dgv_HD_CellClick;
            // 
            // dgv_HDCT
            // 
            dgv_HDCT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_HDCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HDCT.Location = new Point(1117, 333);
            dgv_HDCT.Name = "dgv_HDCT";
            dgv_HDCT.RowHeadersWidth = 82;
            dgv_HDCT.RowTemplate.Height = 41;
            dgv_HDCT.Size = new Size(1193, 415);
            dgv_HDCT.TabIndex = 6;
            dgv_HDCT.CellClick += dgv_HDCT_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1140, 16);
            label2.Name = "label2";
            label2.Size = new Size(89, 32);
            label2.TabIndex = 7;
            label2.Text = "Ma HĐ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1140, 67);
            label3.Name = "label3";
            label3.Size = new Size(95, 32);
            label3.TabIndex = 8;
            label3.Text = "SĐT KH";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1134, 124);
            label4.Name = "label4";
            label4.Size = new Size(90, 32);
            label4.TabIndex = 9;
            label4.Text = "Ten KH";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1147, 230);
            label6.Name = "label6";
            label6.Size = new Size(120, 32);
            label6.TabIndex = 11;
            label6.Text = "Tong Tien";
            // 
            // lb_MaHD
            // 
            lb_MaHD.AutoSize = true;
            lb_MaHD.Location = new Point(1349, 16);
            lb_MaHD.Name = "lb_MaHD";
            lb_MaHD.Size = new Size(61, 32);
            lb_MaHD.TabIndex = 12;
            lb_MaHD.Text = "HDX";
            // 
            // lb_TongTien
            // 
            lb_TongTien.AutoSize = true;
            lb_TongTien.Location = new Point(1275, 230);
            lb_TongTien.Name = "lb_TongTien";
            lb_TongTien.Size = new Size(47, 32);
            lb_TongTien.TabIndex = 14;
            lb_TongTien.Text = "xxx";
            // 
            // cbb_Phone
            // 
            cbb_Phone.FormattingEnabled = true;
            cbb_Phone.Location = new Point(1895, 64);
            cbb_Phone.Name = "cbb_Phone";
            cbb_Phone.Size = new Size(415, 40);
            cbb_Phone.TabIndex = 15;
            cbb_Phone.SelectedIndexChanged += lb_Next_Click;
            cbb_Phone.TextChanged += cbbsdt_TextChanged;
            // 
            // txt_Phone
            // 
            txt_Phone.Location = new Point(1349, 64);
            txt_Phone.Name = "txt_Phone";
            txt_Phone.Size = new Size(439, 39);
            txt_Phone.TabIndex = 17;
            txt_Phone.TextChanged += txt_Phone_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(1349, 117);
            txtName.Name = "txtName";
            txtName.Size = new Size(439, 39);
            txtName.TabIndex = 18;
            // 
            // btn_CreateBill
            // 
            btn_CreateBill.BackColor = Color.FromArgb(224, 224, 224);
            btn_CreateBill.Location = new Point(1867, 772);
            btn_CreateBill.Name = "btn_CreateBill";
            btn_CreateBill.Size = new Size(443, 46);
            btn_CreateBill.TabIndex = 19;
            btn_CreateBill.Text = "Thêm mới 1 hóa đơn";
            btn_CreateBill.UseVisualStyleBackColor = false;
            btn_CreateBill.Click += btn_CreateBill_Click;
            // 
            // btn_ThanhToan
            // 
            btn_ThanhToan.BackColor = Color.FromArgb(224, 224, 224);
            btn_ThanhToan.Location = new Point(1891, 277);
            btn_ThanhToan.Name = "btn_ThanhToan";
            btn_ThanhToan.Size = new Size(400, 46);
            btn_ThanhToan.TabIndex = 20;
            btn_ThanhToan.Text = "Thanh toán";
            btn_ThanhToan.UseVisualStyleBackColor = false;
            btn_ThanhToan.Click += btn_ThanhToan_Click;
            // 
            // lb_Time
            // 
            lb_Time.AutoSize = true;
            lb_Time.Location = new Point(850, 1127);
            lb_Time.Name = "lb_Time";
            lb_Time.Size = new Size(71, 32);
            lb_Time.TabIndex = 21;
            lb_Time.Text = "00:00";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1140, 179);
            label5.Name = "label5";
            label5.Size = new Size(182, 32);
            label5.TabIndex = 22;
            label5.Text = "Tien Khach Dua";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1430, 230);
            label7.Name = "label7";
            label7.Size = new Size(115, 32);
            label7.TabIndex = 23;
            label7.Text = "Tien thua";
            // 
            // txt_khachdua
            // 
            txt_khachdua.Location = new Point(1349, 172);
            txt_khachdua.Name = "txt_khachdua";
            txt_khachdua.Size = new Size(439, 39);
            txt_khachdua.TabIndex = 24;
            // 
            // lb_TienThua
            // 
            lb_TienThua.AutoSize = true;
            lb_TienThua.Location = new Point(1580, 227);
            lb_TienThua.Name = "lb_TienThua";
            lb_TienThua.Size = new Size(50, 32);
            lb_TienThua.TabIndex = 25;
            lb_TienThua.Text = "yyy";
            // 
            // lbCreate
            // 
            lbCreate.AutoSize = true;
            lbCreate.Location = new Point(1895, 124);
            lbCreate.Name = "lbCreate";
            lbCreate.Size = new Size(140, 32);
            lbCreate.TabIndex = 27;
            lbCreate.Text = "Create Date";
            // 
            // lb_Accountid
            // 
            lb_Accountid.AutoSize = true;
            lb_Accountid.Location = new Point(1895, 179);
            lb_Accountid.Name = "lb_Accountid";
            lb_Accountid.Size = new Size(131, 32);
            lb_Accountid.TabIndex = 28;
            lb_Accountid.Text = "Account ID";
            // 
            // Form_BanHang
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2318, 1253);
            Controls.Add(lb_Accountid);
            Controls.Add(lbCreate);
            Controls.Add(dgv_HD);
            Controls.Add(lb_TienThua);
            Controls.Add(txt_khachdua);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(lb_Time);
            Controls.Add(btn_ThanhToan);
            Controls.Add(btn_CreateBill);
            Controls.Add(txtName);
            Controls.Add(txt_Phone);
            Controls.Add(cbb_Phone);
            Controls.Add(lb_TongTien);
            Controls.Add(lb_MaHD);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgv_HDCT);
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
        private Label label6;
        private Label lb_MaHD;
        private Label lb_TongTien;
        private ComboBox cbb_Phone;
        private TextBox txt_Phone;
        private TextBox txtName;
        private Button btn_CreateBill;
        private Button btn_ThanhToan;
        private Label lb_Time;
        private System.Windows.Forms.Timer timer1;
        private Label label5;
        private Label label7;
        private TextBox txt_khachdua;
        private Label lb_TienThua;
        private Label lbCreate;
        private Label lb_Accountid;
    }
}