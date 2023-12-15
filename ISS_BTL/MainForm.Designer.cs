
namespace ISS_BTL
{
    partial class MainForm
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
            this.btn_dsuser = new System.Windows.Forms.Button();
            this.btn_listlop = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_adduser = new System.Windows.Forms.Button();
            this.btn_myinfo = new System.Windows.Forms.Button();
            this.txt_uname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_detail = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_dsmh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_dsuser
            // 
            this.btn_dsuser.Location = new System.Drawing.Point(32, 49);
            this.btn_dsuser.Name = "btn_dsuser";
            this.btn_dsuser.Size = new System.Drawing.Size(123, 23);
            this.btn_dsuser.TabIndex = 0;
            this.btn_dsuser.Text = "Danh sách User";
            this.btn_dsuser.UseVisualStyleBackColor = true;
            this.btn_dsuser.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_listlop
            // 
            this.btn_listlop.Location = new System.Drawing.Point(32, 89);
            this.btn_listlop.Name = "btn_listlop";
            this.btn_listlop.Size = new System.Drawing.Size(123, 23);
            this.btn_listlop.TabIndex = 1;
            this.btn_listlop.Text = "Danh sách Lớp";
            this.btn_listlop.UseVisualStyleBackColor = true;
            this.btn_listlop.Click += new System.EventHandler(this.btn_listlop_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(545, 180);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Trang chủ các tính năng";
            // 
            // btn_adduser
            // 
            this.btn_adduser.Location = new System.Drawing.Point(217, 49);
            this.btn_adduser.Name = "btn_adduser";
            this.btn_adduser.Size = new System.Drawing.Size(119, 23);
            this.btn_adduser.TabIndex = 4;
            this.btn_adduser.Text = "Thêm User";
            this.btn_adduser.UseVisualStyleBackColor = true;
            this.btn_adduser.Click += new System.EventHandler(this.btn_adduser_Click);
            // 
            // btn_myinfo
            // 
            this.btn_myinfo.Location = new System.Drawing.Point(426, 49);
            this.btn_myinfo.Name = "btn_myinfo";
            this.btn_myinfo.Size = new System.Drawing.Size(151, 23);
            this.btn_myinfo.TabIndex = 5;
            this.btn_myinfo.Text = "Thông tin của tôi";
            this.btn_myinfo.UseVisualStyleBackColor = true;
            this.btn_myinfo.Click += new System.EventHandler(this.btn_myinfo_Click);
            // 
            // txt_uname
            // 
            this.txt_uname.Location = new System.Drawing.Point(32, 397);
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.Size = new System.Drawing.Size(100, 23);
            this.txt_uname.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Danh sách user";
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(162, 396);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(123, 23);
            this.btn_del.TabIndex = 8;
            this.btn_del.Text = "Xóa user này";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_detail
            // 
            this.btn_detail.Location = new System.Drawing.Point(304, 396);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(123, 23);
            this.btn_detail.TabIndex = 9;
            this.btn_detail.Text = "Sửa Thông tin";
            this.btn_detail.UseVisualStyleBackColor = true;
            this.btn_detail.Click += new System.EventHandler(this.btn_detail_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "WELCOME: ";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_username.ForeColor = System.Drawing.Color.Red;
            this.lbl_username.Location = new System.Drawing.Point(97, 4);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(81, 21);
            this.lbl_username.TabIndex = 11;
            this.lbl_username.Text = "Username";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Thay đổi ROLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Thông tin Audit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(426, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Danh sách Đăng kí MH";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_dsmh
            // 
            this.btn_dsmh.Location = new System.Drawing.Point(32, 129);
            this.btn_dsmh.Name = "btn_dsmh";
            this.btn_dsmh.Size = new System.Drawing.Size(123, 23);
            this.btn_dsmh.TabIndex = 15;
            this.btn_dsmh.Text = "Danh sách Môn Học";
            this.btn_dsmh.UseVisualStyleBackColor = true;
            this.btn_dsmh.Click += new System.EventHandler(this.btn_dsmh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 449);
            this.Controls.Add(this.btn_dsmh);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_detail);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_uname);
            this.Controls.Add(this.btn_myinfo);
            this.Controls.Add(this.btn_adduser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_listlop);
            this.Controls.Add(this.btn_dsuser);
            this.Name = "MainForm";
            this.Text = "Admin Page";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dsuser;
        private System.Windows.Forms.Button btn_listlop;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_adduser;
        private System.Windows.Forms.Button btn_myinfo;
        private System.Windows.Forms.TextBox txt_uname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_detail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_dsmh;
    }
}