namespace FinalProject
{
    partial class Order
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
            this.dtgList = new System.Windows.Forms.DataGridView();
            this.btnTao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbLoaiMon = new System.Windows.Forms.TextBox();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.tbTenMonAn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTong = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemMonAn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTable = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Ngày = new System.Windows.Forms.Label();
            this.dtCheckin = new System.Windows.Forms.DateTimePicker();
            this.tbIDBill = new System.Windows.Forms.TextBox();
            this.tbNameKH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tbNameNV = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(679, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU ORDER";
            // 
            // dtgList
            // 
            this.dtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgList.Location = new System.Drawing.Point(489, 221);
            this.dtgList.Margin = new System.Windows.Forms.Padding(4);
            this.dtgList.Name = "dtgList";
            this.dtgList.RowHeadersWidth = 51;
            this.dtgList.Size = new System.Drawing.Size(561, 270);
            this.dtgList.TabIndex = 1;
            this.dtgList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgList_CellClick);
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(855, 501);
            this.btnTao.Margin = new System.Windows.Forms.Padding(4);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(152, 64);
            this.btnTao.TabIndex = 3;
            this.btnTao.Text = "Tạo hóa đơn";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.tbLoaiMon);
            this.groupBox1.Controls.Add(this.tbSoLuong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbGia);
            this.groupBox1.Controls.Add(this.tbTenMonAn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(465, 236);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin món ăn";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(332, 12);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 22);
            this.tbID.TabIndex = 10;
            // 
            // tbLoaiMon
            // 
            this.tbLoaiMon.Location = new System.Drawing.Point(124, 82);
            this.tbLoaiMon.Margin = new System.Windows.Forms.Padding(4);
            this.tbLoaiMon.Name = "tbLoaiMon";
            this.tbLoaiMon.Size = new System.Drawing.Size(308, 22);
            this.tbLoaiMon.TabIndex = 9;
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Location = new System.Drawing.Point(124, 175);
            this.tbSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(308, 22);
            this.tbSoLuong.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Loại thức ăn";
            // 
            // tbGia
            // 
            this.tbGia.Location = new System.Drawing.Point(124, 124);
            this.tbGia.Margin = new System.Windows.Forms.Padding(4);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(308, 22);
            this.tbGia.TabIndex = 5;
            // 
            // tbTenMonAn
            // 
            this.tbTenMonAn.Location = new System.Drawing.Point(124, 41);
            this.tbTenMonAn.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenMonAn.Name = "tbTenMonAn";
            this.tbTenMonAn.Size = new System.Drawing.Size(308, 22);
            this.tbTenMonAn.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên món ăn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 475);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tổng tiền";
            // 
            // tbTong
            // 
            this.tbTong.Location = new System.Drawing.Point(156, 480);
            this.tbTong.Margin = new System.Windows.Forms.Padding(4);
            this.tbTong.Name = "tbTong";
            this.tbTong.Size = new System.Drawing.Size(292, 22);
            this.tbTong.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(21, 289);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(460, 129);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm món ăn";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(135, 73);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(292, 22);
            this.textBox5.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 34);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(292, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nhập tên món ăn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tìm theo";
            // 
            // btnThemMonAn
            // 
            this.btnThemMonAn.Location = new System.Drawing.Point(489, 501);
            this.btnThemMonAn.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemMonAn.Name = "btnThemMonAn";
            this.btnThemMonAn.Size = new System.Drawing.Size(152, 64);
            this.btnThemMonAn.TabIndex = 7;
            this.btnThemMonAn.Text = "Thêm";
            this.btnThemMonAn.UseVisualStyleBackColor = true;
            this.btnThemMonAn.Click += new System.EventHandler(this.btnThemMonAn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 431);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "Bàn số";
            // 
            // tbTable
            // 
            this.tbTable.Location = new System.Drawing.Point(156, 431);
            this.tbTable.Margin = new System.Windows.Forms.Padding(4);
            this.tbTable.Name = "tbTable";
            this.tbTable.Size = new System.Drawing.Size(292, 22);
            this.tbTable.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Ngày);
            this.groupBox3.Controls.Add(this.dtCheckin);
            this.groupBox3.Controls.Add(this.tbIDBill);
            this.groupBox3.Controls.Add(this.tbNameKH);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(489, 53);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(373, 131);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin khách hàng";
            // 
            // Ngày
            // 
            this.Ngày.AutoSize = true;
            this.Ngày.Location = new System.Drawing.Point(23, 102);
            this.Ngày.Name = "Ngày";
            this.Ngày.Size = new System.Drawing.Size(41, 17);
            this.Ngày.TabIndex = 12;
            this.Ngày.Text = "Ngày";
            // 
            // dtCheckin
            // 
            this.dtCheckin.Location = new System.Drawing.Point(87, 102);
            this.dtCheckin.Name = "dtCheckin";
            this.dtCheckin.Size = new System.Drawing.Size(232, 22);
            this.dtCheckin.TabIndex = 11;
            // 
            // tbIDBill
            // 
            this.tbIDBill.Location = new System.Drawing.Point(87, 58);
            this.tbIDBill.Margin = new System.Windows.Forms.Padding(4);
            this.tbIDBill.Name = "tbIDBill";
            this.tbIDBill.Size = new System.Drawing.Size(232, 22);
            this.tbIDBill.TabIndex = 10;
            // 
            // tbNameKH
            // 
            this.tbNameKH.Location = new System.Drawing.Point(87, 23);
            this.tbNameKH.Margin = new System.Windows.Forms.Padding(4);
            this.tbNameKH.Name = "tbNameKH";
            this.tbNameKH.Size = new System.Drawing.Size(232, 22);
            this.tbNameKH.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 63);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Bill Số";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 23);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Họ tên";
            // 
            // btnFood
            // 
            this.btnFood.Location = new System.Drawing.Point(566, 191);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(75, 23);
            this.btnFood.TabIndex = 11;
            this.btnFood.Text = "Món ăn";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Location = new System.Drawing.Point(855, 191);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(86, 23);
            this.btnHoaDon.TabIndex = 13;
            this.btnHoaDon.Text = "Hóa Đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(869, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Nhân viên";
            // 
            // tbNameNV
            // 
            this.tbNameNV.Location = new System.Drawing.Point(959, 108);
            this.tbNameNV.Name = "tbNameNV";
            this.tbNameNV.Size = new System.Drawing.Size(100, 22);
            this.tbNameNV.TabIndex = 15;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(673, 501);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(147, 64);
            this.btnXacNhan.TabIndex = 16;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnTable
            // 
            this.btnTable.Location = new System.Drawing.Point(715, 191);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(75, 23);
            this.btnTable.TabIndex = 17;
            this.btnTable.Text = "Bàn";
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 599);
            this.Controls.Add(this.btnTable);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.tbNameNV);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.btnFood);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tbTable);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnThemMonAn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbTong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.dtgList);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgList;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbLoaiMon;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.TextBox tbTenMonAn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemMonAn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbIDBill;
        private System.Windows.Forms.TextBox tbNameKH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbNameNV;
        private System.Windows.Forms.Label Ngày;
        private System.Windows.Forms.DateTimePicker dtCheckin;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnTable;
    }
}