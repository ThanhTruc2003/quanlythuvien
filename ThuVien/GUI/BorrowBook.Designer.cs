namespace ThuVien.GUI
{
    partial class BorrowBook
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMaSinhVien = new System.Windows.Forms.TextBox();
            this.cbo = new System.Windows.Forms.ComboBox();
            this.borrowBookDALBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.borrowBookDALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbBookName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbAvailableQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbQuantity_Borrow = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btHoanTat = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableBookDALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableBookDALBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.borrowBookDALBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowBookDALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBookDALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBookDALBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(251, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên: ";
            // 
            // txbMaSinhVien
            // 
            this.txbMaSinhVien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbMaSinhVien.Location = new System.Drawing.Point(401, 35);
            this.txbMaSinhVien.Multiline = true;
            this.txbMaSinhVien.Name = "txbMaSinhVien";
            this.txbMaSinhVien.Size = new System.Drawing.Size(314, 28);
            this.txbMaSinhVien.TabIndex = 1;
            // 
            // cbo
            // 
            this.cbo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbo.FormattingEnabled = true;
            this.cbo.Location = new System.Drawing.Point(195, 87);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(221, 32);
            this.cbo.TabIndex = 2;
            this.cbo.SelectedIndexChanged += new System.EventHandler(this.cbo_SelectedIndexChanged);
            // 
            // borrowBookDALBindingSource1
            // 
            this.borrowBookDALBindingSource1.DataSource = typeof(DAL.BorrowBookDAL);
            // 
            // borrowBookDALBindingSource
            // 
            this.borrowBookDALBindingSource.DataSource = typeof(DAL.BorrowBookDAL);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn mã sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên sách:";
            // 
            // txbBookName
            // 
            this.txbBookName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbBookName.Location = new System.Drawing.Point(195, 139);
            this.txbBookName.Multiline = true;
            this.txbBookName.Name = "txbBookName";
            this.txbBookName.ReadOnly = true;
            this.txbBookName.Size = new System.Drawing.Size(221, 32);
            this.txbBookName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(37, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số lượng có sẵn:";
            // 
            // txbAvailableQuantity
            // 
            this.txbAvailableQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbAvailableQuantity.Location = new System.Drawing.Point(195, 188);
            this.txbAvailableQuantity.Multiline = true;
            this.txbAvailableQuantity.Name = "txbAvailableQuantity";
            this.txbAvailableQuantity.ReadOnly = true;
            this.txbAvailableQuantity.Size = new System.Drawing.Size(221, 32);
            this.txbAvailableQuantity.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số lượng mượn:";
            // 
            // txbQuantity_Borrow
            // 
            this.txbQuantity_Borrow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbQuantity_Borrow.Location = new System.Drawing.Point(195, 238);
            this.txbQuantity_Borrow.Multiline = true;
            this.txbQuantity_Borrow.Name = "txbQuantity_Borrow";
            this.txbQuantity_Borrow.Size = new System.Drawing.Size(221, 32);
            this.txbQuantity_Borrow.TabIndex = 9;
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThem.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btThem.Location = new System.Drawing.Point(195, 286);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 32);
            this.btThem.TabIndex = 10;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btHoanTat
            // 
            this.btHoanTat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btHoanTat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHoanTat.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btHoanTat.Location = new System.Drawing.Point(310, 327);
            this.btHoanTat.Name = "btHoanTat";
            this.btHoanTat.Size = new System.Drawing.Size(106, 33);
            this.btHoanTat.TabIndex = 11;
            this.btHoanTat.Text = "Hoàn tất";
            this.btHoanTat.UseVisualStyleBackColor = false;
            this.btHoanTat.Click += new System.EventHandler(this.btHoanTat_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(37, 335);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 25);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dgv
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgv.Location = new System.Drawing.Point(451, 87);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(493, 273);
            this.dgv.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "book_id";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Column1.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column1.HeaderText = "Mã sách";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "book_name";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Column2.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column2.HeaderText = "Tên sách";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 190;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "quantity_borrow";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Column3.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ThuVien.Properties.Resources.icons8_left_50;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 52);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tableBookDALBindingSource
            // 
            this.tableBookDALBindingSource.DataSource = typeof(DAL.TableBookDAL);
            // 
            // tableBookDALBindingSource1
            // 
            this.tableBookDALBindingSource1.DataSource = typeof(DAL.TableBookDAL);
            // 
            // BorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(976, 381);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btHoanTat);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txbQuantity_Borrow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbAvailableQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbBookName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo);
            this.Controls.Add(this.txbMaSinhVien);
            this.Controls.Add(this.label1);
            this.Name = "BorrowBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorrowBook";
            this.Load += new System.EventHandler(this.BorrowBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.borrowBookDALBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowBookDALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBookDALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBookDALBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txbMaSinhVien;
        private ComboBox cbo;
        private Label label2;
        private Label label3;
        private TextBox txbBookName;
        private Label label4;
        private TextBox txbAvailableQuantity;
        private Label label5;
        private TextBox txbQuantity_Borrow;
        private Button btThem;
        private Button btHoanTat;
        private DateTimePicker dateTimePicker1;
        private DataGridView dgv;
        private PictureBox pictureBox1;
        private BindingSource tableBookDALBindingSource;
        private BindingSource tableBookDALBindingSource1;
        private BindingSource borrowBookDALBindingSource;
        private BindingSource borrowBookDALBindingSource1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}