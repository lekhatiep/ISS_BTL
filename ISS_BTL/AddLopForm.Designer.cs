
namespace ISS_BTL
{
    partial class AddLopForm
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
            this.cbx_maGV = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tienlop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenlop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_maMH = new System.Windows.Forms.ComboBox();
            this.ngayhocDT = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cbx_maGV
            // 
            this.cbx_maGV.FormattingEnabled = true;
            this.cbx_maGV.Location = new System.Drawing.Point(113, 213);
            this.cbx_maGV.Name = "cbx_maGV";
            this.cbx_maGV.Size = new System.Drawing.Size(144, 23);
            this.cbx_maGV.TabIndex = 26;
            this.cbx_maGV.SelectedIndexChanged += new System.EventHandler(this.cbx_maGV_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(98, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Thêm lớp";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mã Giáo Viên";
            // 
            // txt_tienlop
            // 
            this.txt_tienlop.Location = new System.Drawing.Point(113, 171);
            this.txt_tienlop.Name = "txt_tienlop";
            this.txt_tienlop.Size = new System.Drawing.Size(144, 23);
            this.txt_tienlop.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tiền Thuê Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mã Môn Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ngày Học";
            // 
            // txt_tenlop
            // 
            this.txt_tenlop.Location = new System.Drawing.Point(113, 53);
            this.txt_tenlop.Name = "txt_tenlop";
            this.txt_tenlop.Size = new System.Drawing.Size(144, 23);
            this.txt_tenlop.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên Lớp";
            // 
            // cbx_maMH
            // 
            this.cbx_maMH.FormattingEnabled = true;
            this.cbx_maMH.Items.AddRange(new object[] {
            "LÝ",
            "TOÁN",
            "CNTT"});
            this.cbx_maMH.Location = new System.Drawing.Point(113, 130);
            this.cbx_maMH.Name = "cbx_maMH";
            this.cbx_maMH.Size = new System.Drawing.Size(144, 23);
            this.cbx_maMH.TabIndex = 27;
            // 
            // ngayhocDT
            // 
            this.ngayhocDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayhocDT.Location = new System.Drawing.Point(113, 93);
            this.ngayhocDT.Name = "ngayhocDT";
            this.ngayhocDT.Size = new System.Drawing.Size(178, 23);
            this.ngayhocDT.TabIndex = 28;
            // 
            // AddLopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 314);
            this.Controls.Add(this.ngayhocDT);
            this.Controls.Add(this.cbx_maMH);
            this.Controls.Add(this.cbx_maGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tienlop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tenlop);
            this.Controls.Add(this.label1);
            this.Name = "AddLopForm";
            this.Text = "AddLopForm";
            this.Load += new System.EventHandler(this.AddLopForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_maGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tienlop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenlop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_maMH;
        private System.Windows.Forms.DateTimePicker ngayhocDT;
    }
}