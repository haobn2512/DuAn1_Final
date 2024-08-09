namespace PRL.Forms
{
    partial class Form_CpnSP
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
            ptb_Img = new PictureBox();
            lbName = new Label();
            lbGia = new Label();
            lbSoluong = new Label();
            lb_Mota = new Label();
            lb_Xuatxu = new Label();
            lbGiaValues = new Label();
            lbSoluongValues = new Label();
            btn_Mua = new Button();
            ttx_Soluongban = new TextBox();
            lb_giacu = new Label();
            ((System.ComponentModel.ISupportInitialize)ptb_Img).BeginInit();
            SuspendLayout();
            // 
            // ptb_Img
            // 
            ptb_Img.Location = new Point(18, 25);
            ptb_Img.Name = "ptb_Img";
            ptb_Img.Size = new Size(239, 234);
            ptb_Img.TabIndex = 0;
            ptb_Img.TabStop = false;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(285, 25);
            lbName.Name = "lbName";
            lbName.Size = new Size(149, 32);
            lbName.TabIndex = 1;
            lbName.Text = "Oversize Tee";
            // 
            // lbGia
            // 
            lbGia.AutoSize = true;
            lbGia.Location = new Point(285, 74);
            lbGia.Name = "lbGia";
            lbGia.Size = new Size(95, 32);
            lbGia.TabIndex = 2;
            lbGia.Text = "Gía bán";
            // 
            // lbSoluong
            // 
            lbSoluong.AutoSize = true;
            lbSoluong.Location = new Point(278, 198);
            lbSoluong.Name = "lbSoluong";
            lbSoluong.Size = new Size(156, 32);
            lbSoluong.TabIndex = 3;
            lbSoluong.Text = "Số lượng còn";
            // 
            // lb_Mota
            // 
            lb_Mota.AutoSize = true;
            lb_Mota.Location = new Point(18, 307);
            lb_Mota.Name = "lb_Mota";
            lb_Mota.Size = new Size(105, 32);
            lb_Mota.TabIndex = 3;
            lb_Mota.Text = "Oversize";
            // 
            // lb_Xuatxu
            // 
            lb_Xuatxu.AutoSize = true;
            lb_Xuatxu.Location = new Point(18, 369);
            lb_Xuatxu.Name = "lb_Xuatxu";
            lb_Xuatxu.Size = new Size(95, 32);
            lb_Xuatxu.TabIndex = 3;
            lb_Xuatxu.Text = "Levents";
            // 
            // lbGiaValues
            // 
            lbGiaValues.AutoSize = true;
            lbGiaValues.Location = new Point(306, 166);
            lbGiaValues.Name = "lbGiaValues";
            lbGiaValues.Size = new Size(92, 32);
            lbGiaValues.TabIndex = 2;
            lbGiaValues.Text = "300000";
            // 
            // lbSoluongValues
            // 
            lbSoluongValues.AutoSize = true;
            lbSoluongValues.Location = new Point(306, 240);
            lbSoluongValues.Name = "lbSoluongValues";
            lbSoluongValues.Size = new Size(92, 32);
            lbSoluongValues.TabIndex = 2;
            lbSoluongValues.Text = "300000";
            // 
            // btn_Mua
            // 
            btn_Mua.Location = new Point(237, 362);
            btn_Mua.Name = "btn_Mua";
            btn_Mua.Size = new Size(204, 46);
            btn_Mua.TabIndex = 4;
            btn_Mua.Text = "Mua hàng";
            btn_Mua.UseVisualStyleBackColor = true;
            btn_Mua.Click += btn_Mua_Click;
            // 
            // ttx_Soluongban
            // 
            ttx_Soluongban.Location = new Point(241, 304);
            ttx_Soluongban.Name = "ttx_Soluongban";
            ttx_Soluongban.PlaceholderText = "Nhập SL";
            ttx_Soluongban.Size = new Size(200, 39);
            ttx_Soluongban.TabIndex = 5;
            // 
            // lb_giacu
            // 
            lb_giacu.AutoSize = true;
            lb_giacu.Location = new Point(306, 121);
            lb_giacu.Name = "lb_giacu";
            lb_giacu.Size = new Size(92, 32);
            lb_giacu.TabIndex = 2;
            lb_giacu.Text = "300000";
            // 
            // Form_CpnSP
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 429);
            Controls.Add(ttx_Soluongban);
            Controls.Add(btn_Mua);
            Controls.Add(lb_Xuatxu);
            Controls.Add(lb_Mota);
            Controls.Add(lbSoluong);
            Controls.Add(lbSoluongValues);
            Controls.Add(lb_giacu);
            Controls.Add(lbGiaValues);
            Controls.Add(lbGia);
            Controls.Add(lbName);
            Controls.Add(ptb_Img);
            Name = "Form_CpnSP";
            Text = "Form_CpnSP";
            ((System.ComponentModel.ISupportInitialize)ptb_Img).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptb_Img;
        private Label lbName;
        private Label lbGia;
        private Label lbSoluong;
        private Label lb_Mota;
        private Label lb_Xuatxu;
        private Label lbGiaValues;
        private Label lbSoluongValues;
        private Button btn_Mua;
        private TextBox ttx_Soluongban;
        private Label lb_giacu;
    }
}