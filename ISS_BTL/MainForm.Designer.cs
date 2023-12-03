
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_dsuser
            // 
            this.btn_dsuser.Location = new System.Drawing.Point(32, 49);
            this.btn_dsuser.Name = "btn_dsuser";
            this.btn_dsuser.Size = new System.Drawing.Size(100, 23);
            this.btn_dsuser.TabIndex = 0;
            this.btn_dsuser.Text = "Danh sách User";
            this.btn_dsuser.UseVisualStyleBackColor = true;
            this.btn_dsuser.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_listlop
            // 
            this.btn_listlop.Location = new System.Drawing.Point(153, 49);
            this.btn_listlop.Name = "btn_listlop";
            this.btn_listlop.Size = new System.Drawing.Size(123, 23);
            this.btn_listlop.TabIndex = 1;
            this.btn_listlop.Text = "Danh sách Lớp";
            this.btn_listlop.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(476, 179);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Trang chủ";
            // 
            // btn_adduser
            // 
            this.btn_adduser.Location = new System.Drawing.Point(294, 49);
            this.btn_adduser.Name = "btn_adduser";
            this.btn_adduser.Size = new System.Drawing.Size(87, 23);
            this.btn_adduser.TabIndex = 4;
            this.btn_adduser.Text = "Thêm User";
            this.btn_adduser.UseVisualStyleBackColor = true;
            this.btn_adduser.Click += new System.EventHandler(this.btn_adduser_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 364);
            this.Controls.Add(this.btn_adduser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_listlop);
            this.Controls.Add(this.btn_dsuser);
            this.Name = "MainForm";
            this.Text = "Admin Page";
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
    }
}