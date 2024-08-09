namespace PRL.Forms
{
    partial class Form_QLSPham
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
            btn_Khoa = new Button();
            txt_SoLuongCon = new TextBox();
            txt_XuatXu = new TextBox();
            ptb_Image = new PictureBox();
            btn_Xoa = new Button();
            btn_Sua = new Button();
            bt_Them = new Button();
            dgv_Data = new DataGridView();
            cbb_Status = new ComboBox();
            txt_Price = new TextBox();
            txt_MoTa = new TextBox();
            txt_Ten = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_Id = new TextBox();
            label7 = new Label();
            btn_Clear = new Button();
            cbb_Sale = new ComboBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)ptb_Image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Data).BeginInit();
            SuspendLayout();
            // 
            // btn_Khoa
            // 
            btn_Khoa.Location = new Point(1794, 549);
            btn_Khoa.Name = "btn_Khoa";
            btn_Khoa.Size = new Size(150, 46);
            btn_Khoa.TabIndex = 45;
            btn_Khoa.Text = "Khóa";
            btn_Khoa.UseVisualStyleBackColor = true;
            // 
            // txt_SoLuongCon
            // 
            txt_SoLuongCon.Location = new Point(330, 275);
            txt_SoLuongCon.Name = "txt_SoLuongCon";
            txt_SoLuongCon.Size = new Size(830, 39);
            txt_SoLuongCon.TabIndex = 44;
            // 
            // txt_XuatXu
            // 
            txt_XuatXu.Location = new Point(330, 209);
            txt_XuatXu.Name = "txt_XuatXu";
            txt_XuatXu.Size = new Size(830, 39);
            txt_XuatXu.TabIndex = 43;
            // 
            // ptb_Image
            // 
            ptb_Image.BackColor = SystemColors.ActiveBorder;
            ptb_Image.Location = new Point(1319, 69);
            ptb_Image.Name = "ptb_Image";
            ptb_Image.Size = new Size(314, 320);
            ptb_Image.TabIndex = 42;
            ptb_Image.TabStop = false;
            ptb_Image.Click += ptb_Image_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(1788, 377);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(150, 46);
            btn_Xoa.TabIndex = 41;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(1776, 248);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(150, 46);
            btn_Sua.TabIndex = 40;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // bt_Them
            // 
            bt_Them.Location = new Point(1776, 81);
            bt_Them.Name = "bt_Them";
            bt_Them.Size = new Size(150, 46);
            bt_Them.TabIndex = 39;
            bt_Them.Text = "Thêm";
            bt_Them.UseVisualStyleBackColor = true;
            bt_Them.Click += bt_Them_Click;
            // 
            // dgv_Data
            // 
            dgv_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data.Location = new Point(65, 524);
            dgv_Data.Name = "dgv_Data";
            dgv_Data.RowHeadersWidth = 82;
            dgv_Data.RowTemplate.Height = 41;
            dgv_Data.Size = new Size(1340, 561);
            dgv_Data.TabIndex = 38;
            dgv_Data.CellClick += dgv_Data_CellClick;
            // 
            // cbb_Status
            // 
            cbb_Status.FormattingEnabled = true;
            cbb_Status.Items.AddRange(new object[] { "Hoạt động", "Không hoạt động" });
            cbb_Status.Location = new Point(335, 419);
            cbb_Status.Name = "cbb_Status";
            cbb_Status.Size = new Size(268, 40);
            cbb_Status.TabIndex = 37;
            // 
            // txt_Price
            // 
            txt_Price.Location = new Point(339, 348);
            txt_Price.Name = "txt_Price";
            txt_Price.Size = new Size(264, 39);
            txt_Price.TabIndex = 36;
            // 
            // txt_MoTa
            // 
            txt_MoTa.Location = new Point(330, 136);
            txt_MoTa.Name = "txt_MoTa";
            txt_MoTa.Size = new Size(830, 39);
            txt_MoTa.TabIndex = 35;
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(333, 69);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(827, 39);
            txt_Ten.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 438);
            label6.Name = "label6";
            label6.Size = new Size(120, 32);
            label6.TabIndex = 28;
            label6.Text = "Trạng thái";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 365);
            label5.Name = "label5";
            label5.Size = new Size(95, 32);
            label5.TabIndex = 29;
            label5.Text = "Giá bán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 296);
            label4.Name = "label4";
            label4.Size = new Size(156, 32);
            label4.TabIndex = 30;
            label4.Text = "Số lượng còn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 216);
            label3.Name = "label3";
            label3.Size = new Size(94, 32);
            label3.TabIndex = 31;
            label3.Text = "Xuất xứ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 135);
            label2.Name = "label2";
            label2.Size = new Size(77, 32);
            label2.TabIndex = 32;
            label2.Text = "Mô tả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 67);
            label1.Name = "label1";
            label1.Size = new Size(52, 32);
            label1.TabIndex = 33;
            label1.Text = "Tên";
            // 
            // txt_Id
            // 
            txt_Id.Location = new Point(335, 12);
            txt_Id.Multiline = true;
            txt_Id.Name = "txt_Id";
            txt_Id.ReadOnly = true;
            txt_Id.Size = new Size(496, 39);
            txt_Id.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(85, 19);
            label7.Name = "label7";
            label7.Size = new Size(37, 32);
            label7.TabIndex = 47;
            label7.Text = "ID";
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(1832, 676);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(150, 46);
            btn_Clear.TabIndex = 48;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // cbb_Sale
            // 
            cbb_Sale.FormattingEnabled = true;
            cbb_Sale.Location = new Point(918, 419);
            cbb_Sale.Name = "cbb_Sale";
            cbb_Sale.Size = new Size(242, 40);
            cbb_Sale.TabIndex = 49;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(753, 427);
            label8.Name = "label8";
            label8.Size = new Size(81, 32);
            label8.TabIndex = 50;
            label8.Text = "SaleID";
            // 
            // Form_QLSPham
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2174, 1129);
            Controls.Add(label8);
            Controls.Add(cbb_Sale);
            Controls.Add(btn_Clear);
            Controls.Add(label7);
            Controls.Add(txt_Id);
            Controls.Add(btn_Khoa);
            Controls.Add(txt_SoLuongCon);
            Controls.Add(txt_XuatXu);
            Controls.Add(ptb_Image);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Sua);
            Controls.Add(bt_Them);
            Controls.Add(dgv_Data);
            Controls.Add(cbb_Status);
            Controls.Add(txt_Price);
            Controls.Add(txt_MoTa);
            Controls.Add(txt_Ten);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_QLSPham";
            Text = "Form_QLSPham";
            Load += Form_QLSPham_Load;
            ((System.ComponentModel.ISupportInitialize)ptb_Image).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Khoa;
        private TextBox txt_SoLuongCon;
        private TextBox txt_XuatXu;
        private PictureBox ptb_Image;
        private Button btn_Xoa;
        private Button btn_Sua;
        private Button bt_Them;
        private DataGridView dgv_Data;
        private ComboBox cbb_Status;
        private TextBox txt_Price;
        private TextBox txt_MoTa;
        private TextBox txt_Ten;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_Id;
        private Label label7;
        private Button btn_Clear;
        private ComboBox cbb_Sale;
        private Label label8;
    }
}