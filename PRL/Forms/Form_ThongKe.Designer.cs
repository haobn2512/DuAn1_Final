namespace PRL.Forms
{
    partial class Form_ThongKe
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
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            btnThongke = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            lstTopSellingProducts = new ListBox();
            textBoxTotalRevenue = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 45);
            label1.Name = "label1";
            label1.Size = new Size(100, 32);
            label1.TabIndex = 0;
            label1.Text = "Từ ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 177);
            label2.Name = "label2";
            label2.Size = new Size(117, 32);
            label2.TabIndex = 1;
            label2.Text = "Đến ngày";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(269, 49);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(400, 39);
            dtpStartDate.TabIndex = 2;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(271, 177);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(400, 39);
            dtpEndDate.TabIndex = 3;
            // 
            // btnThongke
            // 
            btnThongke.Location = new Point(758, 49);
            btnThongke.Name = "btnThongke";
            btnThongke.Size = new Size(150, 46);
            btnThongke.TabIndex = 4;
            btnThongke.Text = "Thống kê";
            btnThongke.UseVisualStyleBackColor = true;
            btnThongke.Click += btnThongke_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lstTopSellingProducts);
            groupBox1.Controls.Add(textBoxTotalRevenue);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(82, 288);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1676, 506);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kết quả thống kê";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 204);
            label4.Name = "label4";
            label4.Size = new Size(229, 32);
            label4.TabIndex = 3;
            label4.Text = "Sản phẩm bán chạy:";
            // 
            // lstTopSellingProducts
            // 
            lstTopSellingProducts.FormattingEnabled = true;
            lstTopSellingProducts.ItemHeight = 32;
            lstTopSellingProducts.Location = new Point(453, 258);
            lstTopSellingProducts.Name = "lstTopSellingProducts";
            lstTopSellingProducts.Size = new Size(1180, 164);
            lstTopSellingProducts.TabIndex = 2;
            // 
            // textBoxTotalRevenue
            // 
            textBoxTotalRevenue.Location = new Point(453, 81);
            textBoxTotalRevenue.Name = "textBoxTotalRevenue";
            textBoxTotalRevenue.ReadOnly = true;
            textBoxTotalRevenue.Size = new Size(1146, 39);
            textBoxTotalRevenue.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 70);
            label3.Name = "label3";
            label3.Size = new Size(192, 32);
            label3.TabIndex = 0;
            label3.Text = "Tổng doanh thu:";
            // 
            // Form_ThongKe
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2021, 858);
            Controls.Add(groupBox1);
            Controls.Add(btnThongke);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_ThongKe";
            Text = "Form_ThongKe";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Button btnThongke;
        private GroupBox groupBox1;
        private Label label4;
        private ListBox lstTopSellingProducts;
        private TextBox textBoxTotalRevenue;
        private Label label3;
    }
}