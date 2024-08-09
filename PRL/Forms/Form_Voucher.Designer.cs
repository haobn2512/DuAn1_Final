namespace PRL.Forms
{
    partial class Form_Voucher
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
            label7 = new Label();
            txt_id = new TextBox();
            btn_Clear = new Button();
            cbb_loc = new ComboBox();
            btn_Xoa = new Button();
            btn_Sua = new Button();
            bt_Them = new Button();
            dgv_Data = new DataGridView();
            cbb_Status = new ComboBox();
            txt_Percent = new TextBox();
            dtp_End = new DateTimePicker();
            dtp_Start = new DateTimePicker();
            txt_MoTa = new TextBox();
            txt_Ten = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Data).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(77, 43);
            label7.Name = "label7";
            label7.Size = new Size(37, 32);
            label7.TabIndex = 36;
            label7.Text = "ID";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(322, 40);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(200, 39);
            txt_id.TabIndex = 35;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(1590, 499);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(150, 46);
            btn_Clear.TabIndex = 34;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            // 
            // cbb_loc
            // 
            cbb_loc.FormattingEnabled = true;
            cbb_loc.Items.AddRange(new object[] { "Tất cả", "Hoạt động", "Không hoạt động" });
            cbb_loc.Location = new Point(1155, 480);
            cbb_loc.Name = "cbb_loc";
            cbb_loc.Size = new Size(242, 40);
            cbb_loc.TabIndex = 33;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(1590, 383);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(150, 46);
            btn_Xoa.TabIndex = 32;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(1580, 256);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(150, 46);
            btn_Sua.TabIndex = 31;
            btn_Sua.Text = "Update";
            btn_Sua.UseVisualStyleBackColor = true;
            // 
            // bt_Them
            // 
            bt_Them.Location = new Point(1580, 105);
            bt_Them.Name = "bt_Them";
            bt_Them.Size = new Size(150, 46);
            bt_Them.TabIndex = 30;
            bt_Them.Text = "Add";
            bt_Them.UseVisualStyleBackColor = true;
            // 
            // dgv_Data
            // 
            dgv_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data.Location = new Point(57, 549);
            dgv_Data.Name = "dgv_Data";
            dgv_Data.RowHeadersWidth = 82;
            dgv_Data.RowTemplate.Height = 41;
            dgv_Data.Size = new Size(1340, 561);
            dgv_Data.TabIndex = 29;
            // 
            // cbb_Status
            // 
            cbb_Status.FormattingEnabled = true;
            cbb_Status.Items.AddRange(new object[] { "Hoạt động", "Không hoạt động" });
            cbb_Status.Location = new Point(327, 444);
            cbb_Status.Name = "cbb_Status";
            cbb_Status.Size = new Size(291, 40);
            cbb_Status.TabIndex = 28;
            // 
            // txt_Percent
            // 
            txt_Percent.Location = new Point(331, 373);
            txt_Percent.Name = "txt_Percent";
            txt_Percent.Size = new Size(277, 39);
            txt_Percent.TabIndex = 27;
            // 
            // dtp_End
            // 
            dtp_End.Location = new Point(334, 310);
            dtp_End.Name = "dtp_End";
            dtp_End.Size = new Size(585, 39);
            dtp_End.TabIndex = 26;
            // 
            // dtp_Start
            // 
            dtp_Start.Location = new Point(331, 240);
            dtp_Start.Name = "dtp_Start";
            dtp_Start.Size = new Size(588, 39);
            dtp_Start.TabIndex = 25;
            // 
            // txt_MoTa
            // 
            txt_MoTa.Location = new Point(322, 161);
            txt_MoTa.Name = "txt_MoTa";
            txt_MoTa.Size = new Size(830, 39);
            txt_MoTa.TabIndex = 24;
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(325, 94);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(827, 39);
            txt_Ten.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 463);
            label6.Name = "label6";
            label6.Size = new Size(78, 32);
            label6.TabIndex = 21;
            label6.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 390);
            label5.Name = "label5";
            label5.Size = new Size(72, 32);
            label5.TabIndex = 20;
            label5.Text = "Value";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 321);
            label4.Name = "label4";
            label4.Size = new Size(104, 32);
            label4.TabIndex = 19;
            label4.Text = "EndDate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 241);
            label3.Name = "label3";
            label3.Size = new Size(112, 32);
            label3.TabIndex = 18;
            label3.Text = "StartDate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 160);
            label2.Name = "label2";
            label2.Size = new Size(135, 32);
            label2.TabIndex = 22;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 92);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 17;
            label1.Text = "Name";
            // 
            // Form_Voucher
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2174, 1129);
            Controls.Add(label7);
            Controls.Add(txt_id);
            Controls.Add(btn_Clear);
            Controls.Add(cbb_loc);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Sua);
            Controls.Add(bt_Them);
            Controls.Add(dgv_Data);
            Controls.Add(cbb_Status);
            Controls.Add(txt_Percent);
            Controls.Add(dtp_End);
            Controls.Add(dtp_Start);
            Controls.Add(txt_MoTa);
            Controls.Add(txt_Ten);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Voucher";
            Text = "Form_Voucher";
            ((System.ComponentModel.ISupportInitialize)dgv_Data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox txt_id;
        private Button btn_Clear;
        private ComboBox cbb_loc;
        private Button btn_Xoa;
        private Button btn_Sua;
        private Button bt_Them;
        private DataGridView dgv_Data;
        private ComboBox cbb_Status;
        private TextBox txt_Percent;
        private DateTimePicker dtp_End;
        private DateTimePicker dtp_Start;
        private TextBox txt_MoTa;
        private TextBox txt_Ten;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}