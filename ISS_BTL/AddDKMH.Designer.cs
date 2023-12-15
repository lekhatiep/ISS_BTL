
namespace ISS_BTL
{
    partial class AddDKMH
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_maMH = new System.Windows.Forms.TextBox();
            this.btn_dky = new System.Windows.Forms.Button();
            this.txt_tenLop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_malop = new System.Windows.Forms.Label();
            this.txt_tenMH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_soTC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng ký môn học mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm mã hoặc tên MH";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(154, 44);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(216, 23);
            this.txt_search.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(402, 43);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(92, 23);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Tìm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(572, 139);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã MH";
            // 
            // txt_maMH
            // 
            this.txt_maMH.Enabled = false;
            this.txt_maMH.Location = new System.Drawing.Point(100, 22);
            this.txt_maMH.Name = "txt_maMH";
            this.txt_maMH.Size = new System.Drawing.Size(113, 23);
            this.txt_maMH.TabIndex = 6;
            // 
            // btn_dky
            // 
            this.btn_dky.Location = new System.Drawing.Point(267, 51);
            this.btn_dky.Name = "btn_dky";
            this.btn_dky.Size = new System.Drawing.Size(95, 53);
            this.btn_dky.TabIndex = 7;
            this.btn_dky.Text = "Đăng ký ";
            this.btn_dky.UseVisualStyleBackColor = true;
            this.btn_dky.Click += new System.EventHandler(this.btn_dky_Click);
            // 
            // txt_tenLop
            // 
            this.txt_tenLop.Enabled = false;
            this.txt_tenLop.Location = new System.Drawing.Point(100, 80);
            this.txt_tenLop.Name = "txt_tenLop";
            this.txt_tenLop.Size = new System.Drawing.Size(113, 23);
            this.txt_tenLop.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lớp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_malop);
            this.groupBox1.Controls.Add(this.txt_tenMH);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_soTC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_maMH);
            this.groupBox1.Controls.Add(this.btn_dky);
            this.groupBox1.Controls.Add(this.txt_tenLop);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(29, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 160);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // lbl_malop
            // 
            this.lbl_malop.AutoSize = true;
            this.lbl_malop.Location = new System.Drawing.Point(6, 142);
            this.lbl_malop.Name = "lbl_malop";
            this.lbl_malop.Size = new System.Drawing.Size(0, 15);
            this.lbl_malop.TabIndex = 11;
            // 
            // txt_tenMH
            // 
            this.txt_tenMH.Enabled = false;
            this.txt_tenMH.Location = new System.Drawing.Point(100, 51);
            this.txt_tenMH.Name = "txt_tenMH";
            this.txt_tenMH.Size = new System.Drawing.Size(113, 23);
            this.txt_tenMH.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tên Môn Học";
            // 
            // txt_soTC
            // 
            this.txt_soTC.Enabled = false;
            this.txt_soTC.Location = new System.Drawing.Point(100, 109);
            this.txt_soTC.Name = "txt_soTC";
            this.txt_soTC.Size = new System.Drawing.Size(113, 23);
            this.txt_soTC.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số tín chỉ";
            // 
            // AddDKMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddDKMH";
            this.Text = "AddDKMH";
            this.Load += new System.EventHandler(this.AddDKMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_maMH;
        private System.Windows.Forms.Button btn_dky;
        private System.Windows.Forms.TextBox txt_tenLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_tenMH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_soTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_malop;
    }
}