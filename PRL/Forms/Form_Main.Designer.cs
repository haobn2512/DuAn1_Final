namespace PRL.Forms
{
    partial class Form_Main
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
            pn_MainProgram = new Panel();
            lb_Account = new Label();
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            btn_DangNhap = new ToolStripMenuItem();
            btn_DangXuat = new ToolStripMenuItem();
            btn_HoSoNv = new ToolStripMenuItem();
            btn_Thoat = new ToolStripMenuItem();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            btn_qlsp = new ToolStripMenuItem();
            btn_qlnv = new ToolStripMenuItem();
            btn_Sale = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            voucherToolStripMenuItem = new ToolStripMenuItem();
            btn_ThongKe = new ToolStripMenuItem();
            btn_ThongKeSp = new ToolStripMenuItem();
            btn_ThongKeDt = new ToolStripMenuItem();
            hướngDẫnToolStripMenuItem = new ToolStripMenuItem();
            btn_Hdsd = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pn_MainProgram
            // 
            pn_MainProgram.BackColor = SystemColors.Control;
            pn_MainProgram.Location = new Point(76, 79);
            pn_MainProgram.Name = "pn_MainProgram";
            pn_MainProgram.Size = new Size(2415, 1200);
            pn_MainProgram.TabIndex = 14;
            // 
            // lb_Account
            // 
            lb_Account.AutoSize = true;
            lb_Account.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Account.Location = new Point(2089, 39);
            lb_Account.Name = "lb_Account";
            lb_Account.Size = new Size(35, 37);
            lb_Account.TabIndex = 15;
            lb_Account.Text = "...";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, danhMụcToolStripMenuItem, btn_ThongKe, hướngDẫnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2640, 40);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btn_DangNhap, btn_DangXuat, btn_HoSoNv, btn_Thoat });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(140, 36);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.ShortcutKeys = Keys.Control | Keys.D;
            btn_DangNhap.Size = new Size(416, 44);
            btn_DangNhap.Text = "Đăng Nhập";
            // 
            // btn_DangXuat
            // 
            btn_DangXuat.Name = "btn_DangXuat";
            btn_DangXuat.ShortcutKeys = Keys.Control | Keys.X;
            btn_DangXuat.Size = new Size(416, 44);
            btn_DangXuat.Text = "Đăng Xuất";
            btn_DangXuat.Click += btn_DangXuat_Click;
            // 
            // btn_HoSoNv
            // 
            btn_HoSoNv.Name = "btn_HoSoNv";
            btn_HoSoNv.ShortcutKeys = Keys.Control | Keys.H;
            btn_HoSoNv.Size = new Size(416, 44);
            btn_HoSoNv.Text = "Hồ Sơ Nhân Viên";
            btn_HoSoNv.Click += btn_HoSoNv_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.ShortcutKeys = Keys.Alt | Keys.F4;
            btn_Thoat.Size = new Size(416, 44);
            btn_Thoat.Text = "Thoát";
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btn_qlsp, btn_qlnv, btn_Sale, toolStripMenuItem1, kháchHàngToolStripMenuItem, voucherToolStripMenuItem });
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.B;
            danhMụcToolStripMenuItem.Size = new Size(145, 36);
            danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // btn_qlsp
            // 
            btn_qlsp.Name = "btn_qlsp";
            btn_qlsp.ShortcutKeys = Keys.Alt | Keys.S;
            btn_qlsp.Size = new Size(346, 44);
            btn_qlsp.Text = "Sản Phẩm";
            btn_qlsp.Click += btn_qlsp_Click;
            // 
            // btn_qlnv
            // 
            btn_qlnv.Name = "btn_qlnv";
            btn_qlnv.ShortcutKeys = Keys.Alt | Keys.N;
            btn_qlnv.Size = new Size(346, 44);
            btn_qlnv.Text = "Nhân Viên";
            btn_qlnv.Click += btn_qlnv_Click;
            // 
            // btn_Sale
            // 
            btn_Sale.Name = "btn_Sale";
            btn_Sale.ShortcutKeys = Keys.Alt | Keys.V;
            btn_Sale.Size = new Size(346, 44);
            btn_Sale.Text = "Sale";
            btn_Sale.Click += btn_Sale_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.B;
            toolStripMenuItem1.Size = new Size(346, 44);
            toolStripMenuItem1.Text = "Bán Hàng";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.K;
            kháchHàngToolStripMenuItem.Size = new Size(346, 44);
            kháchHàngToolStripMenuItem.Text = "Khách hàng";
            kháchHàngToolStripMenuItem.Click += kháchHàngToolStripMenuItem_Click;
            // 
            // voucherToolStripMenuItem
            // 
            voucherToolStripMenuItem.Name = "voucherToolStripMenuItem";
            voucherToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.C;
            voucherToolStripMenuItem.Size = new Size(346, 44);
            voucherToolStripMenuItem.Text = "Voucher";
            // 
            // btn_ThongKe
            // 
            btn_ThongKe.DropDownItems.AddRange(new ToolStripItem[] { btn_ThongKeSp, btn_ThongKeDt });
            btn_ThongKe.Name = "btn_ThongKe";
            btn_ThongKe.ShortcutKeys = Keys.Alt | Keys.P;
            btn_ThongKe.Size = new Size(137, 36);
            btn_ThongKe.Text = "Thống Kê";
            // 
            // btn_ThongKeSp
            // 
            btn_ThongKeSp.Name = "btn_ThongKeSp";
            btn_ThongKeSp.ShortcutKeys = Keys.Alt | Keys.P;
            btn_ThongKeSp.Size = new Size(448, 44);
            btn_ThongKeSp.Text = "Thống Kê Sản Phẩm";
            // 
            // btn_ThongKeDt
            // 
            btn_ThongKeDt.Name = "btn_ThongKeDt";
            btn_ThongKeDt.ShortcutKeys = Keys.Alt | Keys.T;
            btn_ThongKeDt.Size = new Size(448, 44);
            btn_ThongKeDt.Text = "Thống Kê Doanh Thu";
            // 
            // hướngDẫnToolStripMenuItem
            // 
            hướngDẫnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btn_Hdsd });
            hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            hướngDẫnToolStripMenuItem.Size = new Size(157, 36);
            hướngDẫnToolStripMenuItem.Text = "Hướng Dẫn";
            // 
            // btn_Hdsd
            // 
            btn_Hdsd.Name = "btn_Hdsd";
            btn_Hdsd.ShortcutKeys = Keys.Alt | Keys.H;
            btn_Hdsd.Size = new Size(552, 44);
            btn_Hdsd.Text = "Giới thiệu và HDSD phần mềm";
            btn_Hdsd.Click += btn_Hdsd_Click;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2640, 1729);
            Controls.Add(menuStrip1);
            Controls.Add(lb_Account);
            Controls.Add(pn_MainProgram);
            Name = "Form_Main";
            Text = "Form_Main";
            Load += Form_Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pn_MainProgram;
        private Label lb_Account;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem btn_DangNhap;
        private ToolStripMenuItem btn_DangXuat;
        private ToolStripMenuItem btn_HoSoNv;
        private ToolStripMenuItem btn_Thoat;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem btn_qlsp;
        private ToolStripMenuItem btn_qlnv;
        private ToolStripMenuItem btn_Sale;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem btn_ThongKe;
        private ToolStripMenuItem btn_ThongKeSp;
        private ToolStripMenuItem btn_ThongKeDt;
        private ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private ToolStripMenuItem btn_Hdsd;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private ToolStripMenuItem voucherToolStripMenuItem;
    }
}