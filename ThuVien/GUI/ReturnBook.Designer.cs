namespace ThuVien.GUI
{
    partial class ReturnBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMaSinhVien = new System.Windows.Forms.TextBox();
            this.btNhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbQuantity_Borrow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbQuantity_Return = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btHoanTat = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_returned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(173, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên:";
            // 
            // txbMaSinhVien
            // 
            this.txbMaSinhVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbMaSinhVien.Location = new System.Drawing.Point(345, 32);
            this.txbMaSinhVien.Multiline = true;
            this.txbMaSinhVien.Name = "txbMaSinhVien";
            this.txbMaSinhVien.Size = new System.Drawing.Size(319, 30);
            this.txbMaSinhVien.TabIndex = 1;
            // 
            // btNhap
            // 
            this.btNhap.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNhap.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btNhap.Location = new System.Drawing.Point(679, 23);
            this.btNhap.Name = "btNhap";
            this.btNhap.Size = new System.Drawing.Size(99, 48);
            this.btNhap.TabIndex = 2;
            this.btNhap.Text = "Nhập";
            this.btNhap.UseVisualStyleBackColor = false;
            this.btNhap.Click += new System.EventHandler(this.btNhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn mã sách:";
            // 
            // cbo
            // 
            this.cbo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbo.FormattingEnabled = true;
            this.cbo.Location = new System.Drawing.Point(215, 96);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(220, 31);
            this.cbo.TabIndex = 4;
            this.cbo.SelectedIndexChanged += new System.EventHandler(this.cbo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(45, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng đã mượn:";
            // 
            // txbQuantity_Borrow
            // 
            this.txbQuantity_Borrow.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbQuantity_Borrow.Location = new System.Drawing.Point(215, 146);
            this.txbQuantity_Borrow.Multiline = true;
            this.txbQuantity_Borrow.Name = "txbQuantity_Borrow";
            this.txbQuantity_Borrow.ReadOnly = true;
            this.txbQuantity_Borrow.Size = new System.Drawing.Size(220, 32);
            this.txbQuantity_Borrow.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(45, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số lượng trả:";
            // 
            // txbQuantity_Return
            // 
            this.txbQuantity_Return.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbQuantity_Return.Location = new System.Drawing.Point(215, 196);
            this.txbQuantity_Return.Multiline = true;
            this.txbQuantity_Return.Name = "txbQuantity_Return";
            this.txbQuantity_Return.Size = new System.Drawing.Size(220, 32);
            this.txbQuantity_Return.TabIndex = 8;
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThem.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btThem.Location = new System.Drawing.Point(215, 256);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 35);
            this.btThem.TabIndex = 9;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btHoanTat
            // 
            this.btHoanTat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btHoanTat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHoanTat.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btHoanTat.Location = new System.Drawing.Point(331, 256);
            this.btHoanTat.Name = "btHoanTat";
            this.btHoanTat.Size = new System.Drawing.Size(104, 35);
            this.btHoanTat.TabIndex = 10;
            this.btHoanTat.Text = "Hoàn tất";
            this.btHoanTat.UseVisualStyleBackColor = false;
            this.btHoanTat.Click += new System.EventHandler(this.btHoanTat_Click);
            // 
            // dgv
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_id,
            this.book_name,
            this.quantity_returned});
            this.dgv.Location = new System.Drawing.Point(476, 93);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(484, 198);
            this.dgv.TabIndex = 11;
            // 
            // book_id
            // 
            this.book_id.DataPropertyName = "book_id";
            this.book_id.HeaderText = "Mã sách";
            this.book_id.Name = "book_id";
            this.book_id.ReadOnly = true;
            this.book_id.Width = 130;
            // 
            // book_name
            // 
            this.book_name.DataPropertyName = "book_name";
            this.book_name.HeaderText = "Tên sách";
            this.book_name.Name = "book_name";
            this.book_name.ReadOnly = true;
            this.book_name.Width = 180;
            // 
            // quantity_returned
            // 
            this.quantity_returned.DataPropertyName = "quantity_returned";
            this.quantity_returned.HeaderText = "Số lượng trả";
            this.quantity_returned.Name = "quantity_returned";
            this.quantity_returned.ReadOnly = true;
            this.quantity_returned.Width = 130;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ThuVien.Properties.Resources.icons8_left_501;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(990, 307);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btHoanTat);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txbQuantity_Return);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbQuantity_Borrow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btNhap);
            this.Controls.Add(this.txbMaSinhVien);
            this.Controls.Add(this.label1);
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBook";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txbMaSinhVien;
        private Button btNhap;
        private Label label2;
        private ComboBox cbo;
        private Label label3;
        private TextBox txbQuantity_Borrow;
        private Label label4;
        private TextBox txbQuantity_Return;
        private Button btThem;
        private Button btHoanTat;
        private DataGridView dgv;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn book_id;
        private DataGridViewTextBoxColumn book_name;
        private DataGridViewTextBoxColumn quantity_returned;
    }
}