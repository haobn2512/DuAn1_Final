namespace PRL.Forms
{
    partial class Form_Customer
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
            button1 = new Button();
            btn_TimKiem = new Button();
            txt_search = new TextBox();
            btn_mokhoa = new Button();
            btn_khoa = new Button();
            btn_sua = new Button();
            btn_Them = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_Name = new TextBox();
            txt_PhoneNumber = new TextBox();
            dtg_Data = new DataGridView();
            txt_Point = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtg_Data).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1051, 435);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 38;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.Location = new Point(1622, 530);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(150, 46);
            btn_TimKiem.TabIndex = 37;
            btn_TimKiem.Text = "Search";
            btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(1148, 534);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(435, 39);
            txt_search.TabIndex = 36;
            // 
            // btn_mokhoa
            // 
            btn_mokhoa.BackgroundImageLayout = ImageLayout.Stretch;
            btn_mokhoa.Location = new Point(783, 408);
            btn_mokhoa.Name = "btn_mokhoa";
            btn_mokhoa.Size = new Size(177, 80);
            btn_mokhoa.TabIndex = 35;
            btn_mokhoa.Text = "UnLock";
            btn_mokhoa.UseVisualStyleBackColor = true;
            // 
            // btn_khoa
            // 
            btn_khoa.BackgroundImageLayout = ImageLayout.Stretch;
            btn_khoa.Location = new Point(593, 408);
            btn_khoa.Name = "btn_khoa";
            btn_khoa.Size = new Size(124, 80);
            btn_khoa.TabIndex = 34;
            btn_khoa.Text = "Lock";
            btn_khoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            btn_sua.BackgroundImageLayout = ImageLayout.Stretch;
            btn_sua.Location = new Point(392, 408);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(113, 80);
            btn_sua.TabIndex = 33;
            btn_sua.Text = "Update";
            btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            btn_Them.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Them.Location = new Point(199, 408);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(121, 80);
            btn_Them.TabIndex = 32;
            btn_Them.Text = "Add";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 262);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 32);
            label3.TabIndex = 31;
            label3.Text = "Point";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 163);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(188, 32);
            label2.TabIndex = 30;
            label2.Text = "Customer Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(173, 32);
            label1.TabIndex = 29;
            label1.Text = "Phone number";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(360, 156);
            txt_Name.Margin = new Padding(4);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(1001, 39);
            txt_Name.TabIndex = 27;
            // 
            // txt_PhoneNumber
            // 
            txt_PhoneNumber.Location = new Point(357, 45);
            txt_PhoneNumber.Margin = new Padding(4);
            txt_PhoneNumber.Name = "txt_PhoneNumber";
            txt_PhoneNumber.Size = new Size(1004, 39);
            txt_PhoneNumber.TabIndex = 26;
            // 
            // dtg_Data
            // 
            dtg_Data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Data.Location = new Point(62, 583);
            dtg_Data.Margin = new Padding(4);
            dtg_Data.Name = "dtg_Data";
            dtg_Data.RowHeadersWidth = 82;
            dtg_Data.RowTemplate.Height = 41;
            dtg_Data.Size = new Size(1999, 531);
            dtg_Data.TabIndex = 25;
            // 
            // txt_Point
            // 
            txt_Point.Location = new Point(359, 259);
            txt_Point.Name = "txt_Point";
            txt_Point.Size = new Size(200, 39);
            txt_Point.TabIndex = 39;
            // 
            // Form_Customer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2174, 1129);
            Controls.Add(txt_Point);
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
            Controls.Add(txt_Name);
            Controls.Add(txt_PhoneNumber);
            Controls.Add(dtg_Data);
            Name = "Form_Customer";
            Text = "Form_Customer";
            Load += Form_Customer_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_Data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btn_TimKiem;
        private TextBox txt_search;
        private Button btn_mokhoa;
        private Button btn_khoa;
        private Button btn_sua;
        private Button btn_Them;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_Name;
        private TextBox txt_PhoneNumber;
        private DataGridView dtg_Data;
        private TextBox txt_Point;
    }
}