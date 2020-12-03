namespace FinalProject
{
    partial class ThanhToan
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
            this.dtgBill = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgBillInfo = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbNameNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTable = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtCheckOUT = new System.Windows.Forms.DateTimePicker();
            this.dtCheckIN = new System.Windows.Forms.DateTimePicker();
            this.tbNameKH = new System.Windows.Forms.TextBox();
            this.tbIDBill = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBill)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBillInfo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgBill);
            this.groupBox1.Location = new System.Drawing.Point(23, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(351, 540);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn";
            // 
            // dtgBill
            // 
            this.dtgBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBill.Location = new System.Drawing.Point(8, 23);
            this.dtgBill.Margin = new System.Windows.Forms.Padding(4);
            this.dtgBill.Name = "dtgBill";
            this.dtgBill.RowHeadersWidth = 51;
            this.dtgBill.Size = new System.Drawing.Size(335, 494);
            this.dtgBill.TabIndex = 0;
            this.dtgBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBill_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgBillInfo);
            this.groupBox2.Location = new System.Drawing.Point(400, 326);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(653, 284);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách món";
            // 
            // dtgBillInfo
            // 
            this.dtgBillInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBillInfo.Location = new System.Drawing.Point(8, 23);
            this.dtgBillInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dtgBillInfo.Name = "dtgBillInfo";
            this.dtgBillInfo.RowHeadersWidth = 51;
            this.dtgBillInfo.Size = new System.Drawing.Size(637, 238);
            this.dtgBillInfo.TabIndex = 0;
            this.dtgBillInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBillInfo_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbNameNV);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbTable);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dtCheckOUT);
            this.groupBox3.Controls.Add(this.dtCheckIN);
            this.groupBox3.Controls.Add(this.tbNameKH);
            this.groupBox3.Controls.Add(this.tbIDBill);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(400, 25);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(467, 294);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin hóa đơn";
            // 
            // tbNameNV
            // 
            this.tbNameNV.Location = new System.Drawing.Point(149, 235);
            this.tbNameNV.Margin = new System.Windows.Forms.Padding(4);
            this.tbNameNV.Name = "tbNameNV";
            this.tbNameNV.Size = new System.Drawing.Size(265, 22);
            this.tbNameNV.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 244);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tên nhân viên";
            // 
            // tbTable
            // 
            this.tbTable.Location = new System.Drawing.Point(149, 198);
            this.tbTable.Margin = new System.Windows.Forms.Padding(4);
            this.tbTable.Name = "tbTable";
            this.tbTable.Size = new System.Drawing.Size(265, 22);
            this.tbTable.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Bàn số";
            // 
            // dtCheckOUT
            // 
            this.dtCheckOUT.Location = new System.Drawing.Point(149, 156);
            this.dtCheckOUT.Margin = new System.Windows.Forms.Padding(4);
            this.dtCheckOUT.Name = "dtCheckOUT";
            this.dtCheckOUT.Size = new System.Drawing.Size(265, 22);
            this.dtCheckOUT.TabIndex = 7;
            // 
            // dtCheckIN
            // 
            this.dtCheckIN.Location = new System.Drawing.Point(149, 114);
            this.dtCheckIN.Margin = new System.Windows.Forms.Padding(4);
            this.dtCheckIN.Name = "dtCheckIN";
            this.dtCheckIN.Size = new System.Drawing.Size(265, 22);
            this.dtCheckIN.TabIndex = 6;
            // 
            // tbNameKH
            // 
            this.tbNameKH.Location = new System.Drawing.Point(149, 74);
            this.tbNameKH.Margin = new System.Windows.Forms.Padding(4);
            this.tbNameKH.Name = "tbNameKH";
            this.tbNameKH.Size = new System.Drawing.Size(265, 22);
            this.tbNameKH.TabIndex = 5;
            // 
            // tbIDBill
            // 
            this.tbIDBill.Location = new System.Drawing.Point(149, 42);
            this.tbIDBill.Margin = new System.Windows.Forms.Padding(4);
            this.tbIDBill.Name = "tbIDBill";
            this.tbIDBill.Size = new System.Drawing.Size(265, 22);
            this.tbIDBill.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày xuất hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày lập hóa đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(393, 631);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 31);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tổng tiền";
            // 
            // tbSum
            // 
            this.tbSum.Location = new System.Drawing.Point(549, 638);
            this.tbSum.Margin = new System.Windows.Forms.Padding(4);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(192, 22);
            this.tbSum.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(904, 610);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Xuất hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(172, 636);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(151, 22);
            this.textBox6.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 631);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 31);
            this.label9.TabIndex = 9;
            this.label9.Text = "Giảm giá";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(771, 610);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(126, 52);
            this.btnThanhToan.TabIndex = 11;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 690);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbSum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThanhToan";
            this.Text = "ThanhToan";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBill)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBillInfo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgBill;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgBillInfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtCheckOUT;
        private System.Windows.Forms.DateTimePicker dtCheckIN;
        private System.Windows.Forms.TextBox tbIDBill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNameNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.TextBox tbNameKH;
    }
}