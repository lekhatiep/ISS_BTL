
namespace ISS_BTL
{
    partial class DanhSachLop
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
            this.btn_detail = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_lopID = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_detail
            // 
            this.btn_detail.Location = new System.Drawing.Point(297, 269);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(123, 23);
            this.btn_detail.TabIndex = 14;
            this.btn_detail.Text = "Sửa Thông tin";
            this.btn_detail.UseVisualStyleBackColor = true;
            this.btn_detail.Click += new System.EventHandler(this.btn_detail_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(155, 269);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(123, 23);
            this.btn_del.TabIndex = 13;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Danh sách lớp";
            // 
            // txt_lopID
            // 
            this.txt_lopID.Location = new System.Drawing.Point(25, 270);
            this.txt_lopID.Name = "txt_lopID";
            this.txt_lopID.Size = new System.Drawing.Size(100, 23);
            this.txt_lopID.TabIndex = 11;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(25, 71);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(521, 179);
            this.dataGridView2.TabIndex = 10;
            this.dataGridView2.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDown);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(281, 32);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(125, 23);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Thêm Lớp Mới";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Lớp của tôi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DanhSachLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 317);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_detail);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_lopID);
            this.Controls.Add(this.dataGridView2);
            this.Name = "DanhSachLop";
            this.Text = "DanhSachLop";
            this.Load += new System.EventHandler(this.DanhSachLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_detail;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_lopID;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}