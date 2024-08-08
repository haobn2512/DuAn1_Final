namespace PRL.Forms
{
    partial class Form_Sale
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_Ten = new TextBox();
            txt_MoTa = new TextBox();
            dtp_Start = new DateTimePicker();
            dtp_End = new DateTimePicker();
            txt_Percent = new TextBox();
            cbb_Status = new ComboBox();
            dgv_Data = new DataGridView();
            bt_Them = new Button();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            cbb_loc = new ComboBox();
            btn_Clear = new Button();
            txt_id = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Data).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 60);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 128);
            label2.Name = "label2";
            label2.Size = new Size(135, 32);
            label2.TabIndex = 0;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 209);
            label3.Name = "label3";
            label3.Size = new Size(112, 32);
            label3.TabIndex = 0;
            label3.Text = "StartDate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 289);
            label4.Name = "label4";
            label4.Size = new Size(104, 32);
            label4.TabIndex = 0;
            label4.Text = "EndDate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 358);
            label5.Name = "label5";
            label5.Size = new Size(93, 32);
            label5.TabIndex = 0;
            label5.Text = "Percent";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(86, 431);
            label6.Name = "label6";
            label6.Size = new Size(78, 32);
            label6.TabIndex = 0;
            label6.Text = "Status";
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(343, 62);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(827, 39);
            txt_Ten.TabIndex = 1;
            // 
            // txt_MoTa
            // 
            txt_MoTa.Location = new Point(340, 129);
            txt_MoTa.Name = "txt_MoTa";
            txt_MoTa.Size = new Size(830, 39);
            txt_MoTa.TabIndex = 2;
            // 
            // dtp_Start
            // 
            dtp_Start.Location = new Point(349, 208);
            dtp_Start.Name = "dtp_Start";
            dtp_Start.Size = new Size(588, 39);
            dtp_Start.TabIndex = 3;
            // 
            // dtp_End
            // 
            dtp_End.Location = new Point(352, 278);
            dtp_End.Name = "dtp_End";
            dtp_End.Size = new Size(585, 39);
            dtp_End.TabIndex = 4;
            // 
            // txt_Percent
            // 
            txt_Percent.Location = new Point(349, 341);
            txt_Percent.Name = "txt_Percent";
            txt_Percent.Size = new Size(277, 39);
            txt_Percent.TabIndex = 5;
            // 
            // cbb_Status
            // 
            cbb_Status.FormattingEnabled = true;
            cbb_Status.Items.AddRange(new object[] { "Hoạt động", "Không hoạt động" });
            cbb_Status.Location = new Point(345, 412);
            cbb_Status.Name = "cbb_Status";
            cbb_Status.Size = new Size(291, 40);
            cbb_Status.TabIndex = 6;
            // 
            // dgv_Data
            // 
            dgv_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data.Location = new Point(75, 517);
            dgv_Data.Name = "dgv_Data";
            dgv_Data.RowHeadersWidth = 82;
            dgv_Data.RowTemplate.Height = 41;
            dgv_Data.Size = new Size(1340, 561);
            dgv_Data.TabIndex = 7;
            dgv_Data.CellClick += dgv_Data_CellClick;
            // 
            // bt_Them
            // 
            bt_Them.Location = new Point(1598, 73);
            bt_Them.Name = "bt_Them";
            bt_Them.Size = new Size(150, 46);
            bt_Them.TabIndex = 8;
            bt_Them.Text = "Add";
            bt_Them.UseVisualStyleBackColor = true;
            bt_Them.Click += bt_Them_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(1598, 224);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(150, 46);
            btn_Sua.TabIndex = 9;
            btn_Sua.Text = "Update";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(1608, 351);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(150, 46);
            btn_Xoa.TabIndex = 10;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // cbb_loc
            // 
            cbb_loc.FormattingEnabled = true;
            cbb_loc.Items.AddRange(new object[] { "Tất cả", "Hoạt động", "Không hoạt động" });
            cbb_loc.Location = new Point(1173, 448);
            cbb_loc.Name = "cbb_loc";
            cbb_loc.Size = new Size(242, 40);
            cbb_loc.TabIndex = 11;
            cbb_loc.SelectedIndexChanged += cbb_loc_SelectedIndexChanged;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(1608, 467);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(150, 46);
            btn_Clear.TabIndex = 14;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(340, 8);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(200, 39);
            txt_id.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(95, 11);
            label7.Name = "label7";
            label7.Size = new Size(37, 32);
            label7.TabIndex = 16;
            label7.Text = "ID";
            // 
            // Form_Sale
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
            Name = "Form_Sale";
            Text = "Form_Sale";
            Load += Form_Sale_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_Ten;
        private TextBox txt_MoTa;
        private DateTimePicker dtp_Start;
        private DateTimePicker dtp_End;
        private TextBox txt_Percent;
        private ComboBox cbb_Status;
        private DataGridView dgv_Data;
        private Button bt_Them;
        private Button btn_Sua;
        private Button btn_Xoa;
        private ComboBox cbb_loc;
        private Button btn_Clear;
        private TextBox txt_id;
        private Label label7;
    }
}