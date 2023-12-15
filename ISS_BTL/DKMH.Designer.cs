
namespace ISS_BTL
{
    partial class DKMH
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
            this.txt_lopID = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(436, 56);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(125, 23);
            this.btn_add.TabIndex = 22;
            this.btn_add.Text = "Đăng ký Mới";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_detail
            // 
            this.btn_detail.Location = new System.Drawing.Point(312, 283);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(123, 23);
            this.btn_detail.TabIndex = 21;
            this.btn_detail.Text = "Sửa Thông tin";
            this.btn_detail.UseVisualStyleBackColor = true;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(170, 283);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(123, 23);
            this.btn_del.TabIndex = 20;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Danh sách môn học đã đăng ký";
            // 
            // txt_lopID
            // 
            this.txt_lopID.Location = new System.Drawing.Point(40, 284);
            this.txt_lopID.Name = "txt_lopID";
            this.txt_lopID.Size = new System.Drawing.Size(100, 23);
            this.txt_lopID.TabIndex = 18;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(40, 85);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(521, 179);
            this.dataGridView2.TabIndex = 17;
            // 
            // DKMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 364);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_detail);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_lopID);
            this.Controls.Add(this.dataGridView2);
            this.Name = "DKMH";
            this.Text = "l";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_detail;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_lopID;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}