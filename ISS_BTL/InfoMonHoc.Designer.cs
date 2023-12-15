
namespace ISS_BTL
{
    partial class InfoMonHoc
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
            this.button2 = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.cbx_pban = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_soTC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tenmh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(28, 213);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 42;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cbx_pban
            // 
            this.cbx_pban.FormattingEnabled = true;
            this.cbx_pban.Items.AddRange(new object[] {
            "LÝ",
            "TOÁN",
            "CNTT"});
            this.cbx_pban.Location = new System.Drawing.Point(102, 166);
            this.cbx_pban.Name = "cbx_pban";
            this.cbx_pban.Size = new System.Drawing.Size(144, 23);
            this.cbx_pban.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "Phòng Ban";
            // 
            // txt_soTC
            // 
            this.txt_soTC.Location = new System.Drawing.Point(104, 120);
            this.txt_soTC.Name = "txt_soTC";
            this.txt_soTC.Size = new System.Drawing.Size(144, 23);
            this.txt_soTC.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Số tín chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(70, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "Thông tin MON HOC";
            // 
            // txt_tenmh
            // 
            this.txt_tenmh.Location = new System.Drawing.Point(104, 70);
            this.txt_tenmh.Name = "txt_tenmh";
            this.txt_tenmh.Size = new System.Drawing.Size(144, 23);
            this.txt_tenmh.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tên Mon Hoc";
            // 
            // InfoMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 260);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cbx_pban);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_soTC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_tenmh);
            this.Controls.Add(this.label1);
            this.Name = "InfoMonHoc";
            this.Text = "InfoMonHoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox cbx_pban;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_soTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tenmh;
        private System.Windows.Forms.Label label1;
    }
}