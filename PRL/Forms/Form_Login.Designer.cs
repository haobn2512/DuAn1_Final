namespace PRL.Forms
{
    partial class Form_Login
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
            linklable_QuenMk = new LinkLabel();
            btn_Login = new Button();
            cb_ShowPass = new CheckBox();
            txt_Pass = new TextBox();
            txt_UserName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // linklable_QuenMk
            // 
            linklable_QuenMk.AutoSize = true;
            linklable_QuenMk.Location = new Point(677, 301);
            linklable_QuenMk.Name = "linklable_QuenMk";
            linklable_QuenMk.Size = new Size(194, 32);
            linklable_QuenMk.TabIndex = 15;
            linklable_QuenMk.TabStop = true;
            linklable_QuenMk.Text = "Quên Mật Khẩu?";
            linklable_QuenMk.LinkClicked += linklable_QuenMk_LinkClicked;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(303, 413);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(319, 46);
            btn_Login.TabIndex = 14;
            btn_Login.Text = "Đăng nhập";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // cb_ShowPass
            // 
            cb_ShowPass.AutoSize = true;
            cb_ShowPass.Location = new Point(303, 300);
            cb_ShowPass.Name = "cb_ShowPass";
            cb_ShowPass.Size = new Size(203, 36);
            cb_ShowPass.TabIndex = 13;
            cb_ShowPass.Text = "Hiện mật khẩu";
            cb_ShowPass.UseVisualStyleBackColor = true;
            cb_ShowPass.CheckedChanged += cb_ShowPass_CheckedChanged;
            // 
            // txt_Pass
            // 
            txt_Pass.Location = new Point(277, 156);
            txt_Pass.Name = "txt_Pass";
            txt_Pass.PasswordChar = '*';
            txt_Pass.Size = new Size(672, 39);
            txt_Pass.TabIndex = 12;
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(277, 69);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(672, 39);
            txt_UserName.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 159);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 9;
            label2.Text = "PassWord";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 76);
            label1.Name = "label1";
            label1.Size = new Size(125, 32);
            label1.TabIndex = 10;
            label1.Text = "UserName";
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 542);
            Controls.Add(linklable_QuenMk);
            Controls.Add(btn_Login);
            Controls.Add(cb_ShowPass);
            Controls.Add(txt_Pass);
            Controls.Add(txt_UserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Login";
            Text = "Form_Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linklable_QuenMk;
        private Button btn_Login;
        private CheckBox cb_ShowPass;
        private TextBox txt_Pass;
        private TextBox txt_UserName;
        private Label label2;
        private Label label1;
    }
}