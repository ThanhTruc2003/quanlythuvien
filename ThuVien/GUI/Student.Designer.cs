namespace ThuVien.GUI
{
    partial class Student
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Create = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbMaSo = new System.Windows.Forms.TextBox();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.txbSoDienThoai = new System.Windows.Forms.TextBox();
            this.txbNganh = new System.Windows.Forms.TextBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(959, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 307);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student_id,
            this.student_name,
            this.student_phone,
            this.student_major,
            this.student_address});
            this.dgv.Location = new System.Drawing.Point(19, 32);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 25;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv.Size = new System.Drawing.Size(898, 258);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // student_id
            // 
            this.student_id.DataPropertyName = "student_id";
            this.student_id.HeaderText = "Mã số ";
            this.student_id.Name = "student_id";
            this.student_id.Width = 130;
            // 
            // student_name
            // 
            this.student_name.DataPropertyName = "student_name";
            this.student_name.HeaderText = "Họ tên";
            this.student_name.Name = "student_name";
            this.student_name.Width = 180;
            // 
            // student_phone
            // 
            this.student_phone.DataPropertyName = "student_phone";
            this.student_phone.HeaderText = "Số điện thoại";
            this.student_phone.Name = "student_phone";
            this.student_phone.Width = 160;
            // 
            // student_major
            // 
            this.student_major.DataPropertyName = "student_major";
            this.student_major.HeaderText = "Ngành";
            this.student_major.Name = "student_major";
            this.student_major.Width = 180;
            // 
            // student_address
            // 
            this.student_address.DataPropertyName = "student_address";
            this.student_address.HeaderText = "Địa chỉ";
            this.student_address.Name = "student_address";
            this.student_address.Width = 205;
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Create.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Create.Image = global::ThuVien.Properties.Resources.icons8_plus_50;
            this.Create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Create.Location = new System.Drawing.Point(520, 217);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(108, 52);
            this.Create.TabIndex = 2;
            this.Create.Text = "Thêm";
            this.Create.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete.Image = global::ThuVien.Properties.Resources.icons8_remove_50;
            this.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete.Location = new System.Drawing.Point(634, 217);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(99, 52);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Xóa";
            this.Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Update.Image = global::ThuVien.Properties.Resources.icons8_edit_50;
            this.Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Update.Location = new System.Drawing.Point(739, 217);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(99, 52);
            this.Update.TabIndex = 4;
            this.Update.Text = "Sửa";
            this.Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exit.Image = global::ThuVien.Properties.Resources.icons8_close_window_50;
            this.Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit.Location = new System.Drawing.Point(844, 217);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 52);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Thoát";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã số:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Họ tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(31, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(468, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngành: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(468, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Địa chỉ: ";
            // 
            // txbMaSo
            // 
            this.txbMaSo.Location = new System.Drawing.Point(165, 99);
            this.txbMaSo.Multiline = true;
            this.txbMaSo.Name = "txbMaSo";
            this.txbMaSo.Size = new System.Drawing.Size(277, 24);
            this.txbMaSo.TabIndex = 11;
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(165, 144);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(277, 23);
            this.txbHoTen.TabIndex = 12;
            // 
            // txbSoDienThoai
            // 
            this.txbSoDienThoai.Location = new System.Drawing.Point(165, 189);
            this.txbSoDienThoai.Name = "txbSoDienThoai";
            this.txbSoDienThoai.Size = new System.Drawing.Size(277, 23);
            this.txbSoDienThoai.TabIndex = 13;
            // 
            // txbNganh
            // 
            this.txbNganh.Location = new System.Drawing.Point(555, 103);
            this.txbNganh.Multiline = true;
            this.txbNganh.Name = "txbNganh";
            this.txbNganh.Size = new System.Drawing.Size(277, 24);
            this.txbNganh.TabIndex = 14;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Location = new System.Drawing.Point(555, 143);
            this.txbDiaChi.Multiline = true;
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(277, 24);
            this.txbDiaChi.TabIndex = 15;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 594);
            this.Controls.Add(this.txbDiaChi);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.txbNganh);
            this.Controls.Add(this.txbSoDienThoai);
            this.Controls.Add(this.txbHoTen);
            this.Controls.Add(this.txbMaSo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgv;
        private Button Create;
        private Button Delete;
        private Button Update;
        private Button Exit;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txbMaSo;
        private TextBox txbHoTen;
        private TextBox txbSoDienThoai;
        private TextBox txbNganh;
        private TextBox txbDiaChi;
        private DataGridViewTextBoxColumn student_id;
        private DataGridViewTextBoxColumn student_name;
        private DataGridViewTextBoxColumn student_phone;
        private DataGridViewTextBoxColumn student_major;
        private DataGridViewTextBoxColumn student_address;
    }
}