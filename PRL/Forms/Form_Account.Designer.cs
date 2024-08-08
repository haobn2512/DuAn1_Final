namespace PRL.Forms
{
    partial class Form_Account
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
            btn_mokhoa = new Button();
            btn_khoa = new Button();
            btn_sua = new Button();
            btn_Them = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbb_role = new ComboBox();
            txt_password = new TextBox();
            txt_username = new TextBox();
            dgv_Account = new DataGridView();
            txt_search = new TextBox();
            btn_TimKiem = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Account).BeginInit();
            SuspendLayout();
            // 
            // btn_mokhoa
            // 
            btn_mokhoa.BackgroundImageLayout = ImageLayout.Stretch;
            btn_mokhoa.Location = new Point(807, 394);
            btn_mokhoa.Name = "btn_mokhoa";
            btn_mokhoa.Size = new Size(177, 80);
            btn_mokhoa.TabIndex = 21;
            btn_mokhoa.Text = "UnLock";
            btn_mokhoa.UseVisualStyleBackColor = true;
            btn_mokhoa.Click += btn_mokhoa_Click;
            // 
            // btn_khoa
            // 
            btn_khoa.BackgroundImageLayout = ImageLayout.Stretch;
            btn_khoa.Location = new Point(617, 394);
            btn_khoa.Name = "btn_khoa";
            btn_khoa.Size = new Size(124, 80);
            btn_khoa.TabIndex = 20;
            btn_khoa.Text = "Lock";
            btn_khoa.UseVisualStyleBackColor = true;
            btn_khoa.Click += btn_khoa_Click;
            // 
            // btn_sua
            // 
            btn_sua.BackgroundImageLayout = ImageLayout.Stretch;
            btn_sua.Location = new Point(416, 394);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(113, 80);
            btn_sua.TabIndex = 19;
            btn_sua.Text = "Update";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_Them
            // 
            btn_Them.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Them.Location = new Point(223, 394);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(121, 80);
            btn_Them.TabIndex = 18;
            btn_Them.Text = "Add";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 248);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 32);
            label3.TabIndex = 17;
            label3.Text = "Role";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 149);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 16;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 15;
            label1.Text = "Username";
            // 
            // cbb_role
            // 
            cbb_role.FormattingEnabled = true;
            cbb_role.Items.AddRange(new object[] { "Tài khoản bị khóa", "Admin", "Nhân viên" });
            cbb_role.Location = new Point(381, 248);
            cbb_role.Margin = new Padding(4);
            cbb_role.Name = "cbb_role";
            cbb_role.Size = new Size(782, 40);
            cbb_role.TabIndex = 14;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(384, 142);
            txt_password.Margin = new Padding(4);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(1001, 39);
            txt_password.TabIndex = 13;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(381, 31);
            txt_username.Margin = new Padding(4);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(1004, 39);
            txt_username.TabIndex = 12;
            // 
            // dgv_Account
            // 
            dgv_Account.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Account.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Account.Location = new Point(86, 569);
            dgv_Account.Margin = new Padding(4);
            dgv_Account.Name = "dgv_Account";
            dgv_Account.RowHeadersWidth = 82;
            dgv_Account.RowTemplate.Height = 41;
            dgv_Account.Size = new Size(1999, 531);
            dgv_Account.TabIndex = 11;
            dgv_Account.CellClick += dgv_Account_CellClick;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(1172, 520);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(435, 39);
            txt_search.TabIndex = 22;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.Location = new Point(1646, 516);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(150, 46);
            btn_TimKiem.TabIndex = 23;
            btn_TimKiem.Text = "Search";
            btn_TimKiem.UseVisualStyleBackColor = true;
            btn_TimKiem.Click += btn_TimKiem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1075, 421);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 24;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form_Account
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2174, 1129);
            Controls.Add(button1);
            Controls.Add(btn_TimKiem);
            Controls.Add(txt_search);
            Controls.Add(btn_mokhoa);
            Controls.Add(btn_khoa);
            Controls.Add(btn_sua);
            Controls.Add(btn_Them);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbb_role);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(dgv_Account);
            Name = "Form_Account";
            Text = "Form_Account";
            Load += Form_Account_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Account).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_mokhoa;
        private Button btn_khoa;
        private Button btn_sua;
        private Button btn_Them;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbb_role;
        private TextBox txt_password;
        private TextBox txt_username;
        private DataGridView dgv_Account;
        private TextBox txt_search;
        private Button btn_TimKiem;
        private Button button1;
    }
}