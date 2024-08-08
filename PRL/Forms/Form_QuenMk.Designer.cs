namespace PRL.Forms
{
    partial class Form_QuenMk
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
            btn_Thoat = new Button();
            btn_laymk = new Button();
            lblNewPassword = new Label();
            txtUsername = new TextBox();
            lb_sdt = new Label();
            txt_newMk = new TextBox();
            SuspendLayout();
            // 
            // btn_Thoat
            // 
            btn_Thoat.BackColor = Color.FromArgb(224, 224, 224);
            btn_Thoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Thoat.ForeColor = Color.Black;
            btn_Thoat.Location = new Point(222, 429);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(359, 74);
            btn_Thoat.TabIndex = 16;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = false;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // btn_laymk
            // 
            btn_laymk.BackColor = Color.FromArgb(224, 224, 224);
            btn_laymk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_laymk.ForeColor = Color.Black;
            btn_laymk.Location = new Point(222, 295);
            btn_laymk.Name = "btn_laymk";
            btn_laymk.Size = new Size(359, 82);
            btn_laymk.TabIndex = 15;
            btn_laymk.Text = "Lấy Lại Mật Khẩu";
            btn_laymk.UseVisualStyleBackColor = false;
            btn_laymk.Click += btn_laymk_Click;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(163, 171);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(168, 32);
            lblNewPassword.TabIndex = 14;
            lblNewPassword.Text = "New password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(163, 102);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(486, 39);
            txtUsername.TabIndex = 13;
            // 
            // lb_sdt
            // 
            lb_sdt.AutoSize = true;
            lb_sdt.Location = new Point(163, 46);
            lb_sdt.Name = "lb_sdt";
            lb_sdt.Size = new Size(186, 32);
            lb_sdt.TabIndex = 12;
            lb_sdt.Text = "Nhập Username";
            // 
            // txt_newMk
            // 
            txt_newMk.Location = new Point(170, 229);
            txt_newMk.Name = "txt_newMk";
            txt_newMk.Size = new Size(479, 39);
            txt_newMk.TabIndex = 17;
            // 
            // Form_QuenMk
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 581);
            Controls.Add(txt_newMk);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_laymk);
            Controls.Add(lblNewPassword);
            Controls.Add(txtUsername);
            Controls.Add(lb_sdt);
            Name = "Form_QuenMk";
            Text = "Form_QuenMk";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Thoat;
        private Button btn_laymk;
        private Label lblNewPassword;
        private TextBox txtUsername;
        private Label lb_sdt;
        private TextBox txt_newMk;
    }
}