namespace PRL.Forms
{
    partial class Form_DoiMk
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
            txtUsername = new TextBox();
            txtOldPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btn_Thoat = new Button();
            btn_DoiMk = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cb_newmk = new CheckBox();
            cb_newmkagain = new CheckBox();
            cb_mkcu = new CheckBox();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(298, 63);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(444, 39);
            txtUsername.TabIndex = 29;
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(298, 164);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '*';
            txtOldPassword.Size = new Size(444, 39);
            txtOldPassword.TabIndex = 28;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(298, 248);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(440, 39);
            txtNewPassword.TabIndex = 27;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(298, 351);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(440, 39);
            txtConfirmPassword.TabIndex = 26;
            // 
            // btn_Thoat
            // 
            btn_Thoat.BackColor = Color.FromArgb(224, 224, 224);
            btn_Thoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Thoat.ForeColor = Color.Black;
            btn_Thoat.Location = new Point(176, 545);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(464, 67);
            btn_Thoat.TabIndex = 25;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = false;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // btn_DoiMk
            // 
            btn_DoiMk.BackColor = Color.FromArgb(224, 224, 224);
            btn_DoiMk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DoiMk.ForeColor = Color.Black;
            btn_DoiMk.Location = new Point(176, 455);
            btn_DoiMk.Name = "btn_DoiMk";
            btn_DoiMk.Size = new Size(464, 69);
            btn_DoiMk.TabIndex = 24;
            btn_DoiMk.Text = "Đổi Mật Khẩu";
            btn_DoiMk.UseVisualStyleBackColor = false;
            btn_DoiMk.Click += btn_DoiMk_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 354);
            label5.Name = "label5";
            label5.Size = new Size(191, 32);
            label5.TabIndex = 20;
            label5.Text = "Nhập lại mk mới";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 251);
            label4.Name = "label4";
            label4.Size = new Size(163, 32);
            label4.TabIndex = 21;
            label4.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 160);
            label3.Name = "label3";
            label3.Size = new Size(147, 32);
            label3.TabIndex = 22;
            label3.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 59);
            label2.Name = "label2";
            label2.Size = new Size(121, 32);
            label2.TabIndex = 23;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(195, -111);
            label1.Name = "label1";
            label1.Size = new Size(429, 42);
            label1.TabIndex = 19;
            label1.Text = "Đổi Mật Khẩu Nhân Viên";
            // 
            // cb_newmk
            // 
            cb_newmk.AutoSize = true;
            cb_newmk.Location = new Point(296, 302);
            cb_newmk.Name = "cb_newmk";
            cb_newmk.Size = new Size(28, 27);
            cb_newmk.TabIndex = 30;
            cb_newmk.UseVisualStyleBackColor = true;
            cb_newmk.CheckedChanged += cb_newmk_CheckedChanged;
            // 
            // cb_newmkagain
            // 
            cb_newmkagain.AutoSize = true;
            cb_newmkagain.Location = new Point(296, 408);
            cb_newmkagain.Name = "cb_newmkagain";
            cb_newmkagain.Size = new Size(28, 27);
            cb_newmkagain.TabIndex = 31;
            cb_newmkagain.UseVisualStyleBackColor = true;
            cb_newmkagain.CheckedChanged += cb_newmkagain_CheckedChanged;
            // 
            // cb_mkcu
            // 
            cb_mkcu.AutoSize = true;
            cb_mkcu.Location = new Point(298, 203);
            cb_mkcu.Name = "cb_mkcu";
            cb_mkcu.Size = new Size(28, 27);
            cb_mkcu.TabIndex = 32;
            cb_mkcu.UseVisualStyleBackColor = true;
            cb_mkcu.CheckedChanged += cb_mkcu_CheckedChanged;
            // 
            // Form_DoiMk
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 659);
            Controls.Add(cb_mkcu);
            Controls.Add(cb_newmkagain);
            Controls.Add(cb_newmk);
            Controls.Add(txtUsername);
            Controls.Add(txtOldPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_DoiMk);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_DoiMk";
            Text = "Form_DoiMk";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtOldPassword;
        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;
        private Button btn_Thoat;
        private Button btn_DoiMk;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox cb_newmk;
        private CheckBox cb_newmkagain;
        private CheckBox cb_mkcu;
    }
}