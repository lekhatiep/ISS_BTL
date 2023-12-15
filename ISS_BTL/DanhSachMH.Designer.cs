
namespace ISS_BTL
{
    partial class DanhSachMH
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_detail = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_monhocID = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_loadPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(428, 34);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(125, 23);
            this.btn_add.TabIndex = 22;
            this.btn_add.Text = "Thêm môn học mới";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_detail
            // 
            this.btn_detail.Location = new System.Drawing.Point(304, 273);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(123, 23);
            this.btn_detail.TabIndex = 21;
            this.btn_detail.Text = "Sửa Thông tin";
            this.btn_detail.UseVisualStyleBackColor = true;
            this.btn_detail.Click += new System.EventHandler(this.btn_detail_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(162, 273);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(123, 23);
            this.btn_del.TabIndex = 20;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Danh sách môn học";
            // 
            // txt_monhocID
            // 
            this.txt_monhocID.Location = new System.Drawing.Point(32, 274);
            this.txt_monhocID.Name = "txt_monhocID";
            this.txt_monhocID.Size = new System.Drawing.Size(100, 23);
            this.txt_monhocID.TabIndex = 18;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(32, 75);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(521, 179);
            this.dataGridView2.TabIndex = 17;
            this.dataGridView2.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDown);
            // 
            // btn_loadPage
            // 
            this.btn_loadPage.Location = new System.Drawing.Point(32, 34);
            this.btn_loadPage.Name = "btn_loadPage";
            this.btn_loadPage.Size = new System.Drawing.Size(125, 23);
            this.btn_loadPage.TabIndex = 23;
            this.btn_loadPage.Text = "Refesh";
            this.btn_loadPage.UseVisualStyleBackColor = true;
            this.btn_loadPage.Click += new System.EventHandler(this.btn_loadPage_Click);
            // 
            // DanhSachMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 322);
            this.Controls.Add(this.btn_loadPage);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_detail);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_monhocID);
            this.Controls.Add(this.dataGridView2);
            this.Name = "DanhSachMH";
            this.Text = "DanhSachMH";
            this.Load += new System.EventHandler(this.DanhSachMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_detail;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_monhocID;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_loadPage;
    }
}