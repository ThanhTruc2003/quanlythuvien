namespace ThuVien.GUI
{
    partial class UpdateBook
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
            this.txbTenSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNhaXuatBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên sách:";
            // 
            // txbTenSach
            // 
            this.txbTenSach.Location = new System.Drawing.Point(152, 65);
            this.txbTenSach.Name = "txbTenSach";
            this.txbTenSach.Size = new System.Drawing.Size(257, 23);
            this.txbTenSach.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhà xuất bản:";
            // 
            // txbNhaXuatBan
            // 
            this.txbNhaXuatBan.Location = new System.Drawing.Point(152, 103);
            this.txbNhaXuatBan.Name = "txbNhaXuatBan";
            this.txbNhaXuatBan.Size = new System.Drawing.Size(257, 23);
            this.txbNhaXuatBan.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(33, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 23);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = global::ThuVien.Properties.Resources.icons8_available_updates_48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(227, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sửa";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(33, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã sách:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(257, 23);
            this.textBox2.TabIndex = 11;
            // 
            // UpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 233);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNhaXuatBan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbTenSach);
            this.Controls.Add(this.label1);
            this.Name = "UpdateBook";
            this.Text = "UpdateBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txbTenSach;
        private Label label2;
        private TextBox txbNhaXuatBan;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private Label label4;
        private TextBox textBox2;
    }
}