namespace PRL.Forms
{
    partial class Form_ManHinhCho
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
            menuStrip1 = new MenuStrip();
            btn_DangNhap = new ToolStripMenuItem();
            đăngNhậpToolStripMenuItem = new ToolStripMenuItem();
            btn_DangXuat = new ToolStripMenuItem();
            btn_Thoat = new ToolStripMenuItem();
            hướngDẫnToolStripMenuItem = new ToolStripMenuItem();
            btn_HuongDan = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { btn_DangNhap, hướngDẫnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2390, 40);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.DropDownItems.AddRange(new ToolStripItem[] { đăngNhậpToolStripMenuItem, btn_DangXuat, btn_Thoat });
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.ShortcutKeyDisplayString = "Alt+F4";
            btn_DangNhap.ShortcutKeys = Keys.Alt | Keys.F4;
            btn_DangNhap.Size = new Size(135, 36);
            btn_DangNhap.Text = "Hệ thống";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            đăngNhậpToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            đăngNhậpToolStripMenuItem.Size = new Size(359, 44);
            đăngNhậpToolStripMenuItem.Text = "Đăng Nhập";
            đăngNhậpToolStripMenuItem.Click += đăngNhậpToolStripMenuItem_Click;
            // 
            // btn_DangXuat
            // 
            btn_DangXuat.Name = "btn_DangXuat";
            btn_DangXuat.ShortcutKeys = Keys.Control | Keys.X;
            btn_DangXuat.Size = new Size(359, 44);
            btn_DangXuat.Text = "Đăng Xuất";
            // 
            // btn_Thoat
            // 
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.ShortcutKeyDisplayString = "Alt+F4";
            btn_Thoat.ShortcutKeys = Keys.Alt | Keys.F4;
            btn_Thoat.Size = new Size(359, 44);
            btn_Thoat.Text = "Thoát";
            // 
            // hướngDẫnToolStripMenuItem
            // 
            hướngDẫnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btn_HuongDan });
            hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            hướngDẫnToolStripMenuItem.Size = new Size(154, 36);
            hướngDẫnToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // btn_HuongDan
            // 
            btn_HuongDan.Name = "btn_HuongDan";
            btn_HuongDan.ShortcutKeys = Keys.Alt | Keys.H;
            btn_HuongDan.Size = new Size(552, 44);
            btn_HuongDan.Text = "Giới thiệu và HDSD phần mềm";
            btn_HuongDan.Click += btn_HuongDan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(677, 117);
            label1.Name = "label1";
            label1.Size = new Size(959, 71);
            label1.TabIndex = 3;
            label1.Text = "Phần mềm bán áo Levents® Play Tog";
            // 
            // Form_ManHinhCho
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2390, 1729);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "Form_ManHinhCho";
            Text = "Form_ManHinhCho";
            Load += Form_ManHinhCho_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem btn_DangNhap;
        private ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private ToolStripMenuItem btn_DangXuat;
        private ToolStripMenuItem btn_Thoat;
        private ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private ToolStripMenuItem btn_HuongDan;
        private Label label1;
    }
}