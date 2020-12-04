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
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tbSerachTable = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBill)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBillInfo)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(93, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVOICE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgBill);
            this.groupBox1.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.groupBox1.Location = new System.Drawing.Point(23, 125);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(351, 501);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of invoices";
            // 
            // dtgBill
            // 
            this.dtgBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBill.Location = new System.Drawing.Point(6, 54);
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
            this.groupBox2.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.groupBox2.Location = new System.Drawing.Point(400, 326);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(664, 284);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of food";
            // 
            // dtgBillInfo
            // 
            this.dtgBillInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBillInfo.Location = new System.Drawing.Point(8, 23);
            this.dtgBillInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dtgBillInfo.Name = "dtgBillInfo";
            this.dtgBillInfo.RowHeadersWidth = 51;
            this.dtgBillInfo.Size = new System.Drawing.Size(648, 238);
            this.dtgBillInfo.TabIndex = 0;
            this.dtgBillInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBillInfo_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel6);
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.panel1);
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
            this.groupBox3.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.groupBox3.Location = new System.Drawing.Point(400, 25);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(440, 294);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informations";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel6.Location = new System.Drawing.Point(23, 266);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(393, 1);
            this.panel6.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel5.Location = new System.Drawing.Point(23, 226);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(393, 1);
            this.panel5.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel4.Location = new System.Drawing.Point(23, 182);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(393, 1);
            this.panel4.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel3.Location = new System.Drawing.Point(23, 140);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(393, 1);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(23, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 1);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(23, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 1);
            this.panel1.TabIndex = 12;
            // 
            // tbNameNV
            // 
            this.tbNameNV.BackColor = System.Drawing.Color.White;
            this.tbNameNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNameNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.tbNameNV.Location = new System.Drawing.Point(149, 235);
            this.tbNameNV.Margin = new System.Windows.Forms.Padding(4);
            this.tbNameNV.Name = "tbNameNV";
            this.tbNameNV.Size = new System.Drawing.Size(267, 19);
            this.tbNameNV.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 241);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Staff name";
            // 
            // tbTable
            // 
            this.tbTable.BackColor = System.Drawing.Color.White;
            this.tbTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.tbTable.Location = new System.Drawing.Point(149, 202);
            this.tbTable.Margin = new System.Windows.Forms.Padding(4);
            this.tbTable.Name = "tbTable";
            this.tbTable.Size = new System.Drawing.Size(267, 19);
            this.tbTable.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Table number";
            // 
            // dtCheckOUT
            // 
            this.dtCheckOUT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCheckOUT.Location = new System.Drawing.Point(149, 156);
            this.dtCheckOUT.Margin = new System.Windows.Forms.Padding(4);
            this.dtCheckOUT.Name = "dtCheckOUT";
            this.dtCheckOUT.Size = new System.Drawing.Size(265, 26);
            this.dtCheckOUT.TabIndex = 7;
            // 
            // dtCheckIN
            // 
            this.dtCheckIN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCheckIN.Location = new System.Drawing.Point(149, 114);
            this.dtCheckIN.Margin = new System.Windows.Forms.Padding(4);
            this.dtCheckIN.Name = "dtCheckIN";
            this.dtCheckIN.Size = new System.Drawing.Size(265, 26);
            this.dtCheckIN.TabIndex = 6;
            // 
            // tbNameKH
            // 
            this.tbNameKH.BackColor = System.Drawing.Color.White;
            this.tbNameKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNameKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.tbNameKH.Location = new System.Drawing.Point(149, 74);
            this.tbNameKH.Margin = new System.Windows.Forms.Padding(4);
            this.tbNameKH.Name = "tbNameKH";
            this.tbNameKH.Size = new System.Drawing.Size(267, 19);
            this.tbNameKH.TabIndex = 5;
            // 
            // tbIDBill
            // 
            this.tbIDBill.BackColor = System.Drawing.Color.White;
            this.tbIDBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIDBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.tbIDBill.Location = new System.Drawing.Point(149, 42);
            this.tbIDBill.Margin = new System.Windows.Forms.Padding(4);
            this.tbIDBill.Name = "tbIDBill";
            this.tbIDBill.Size = new System.Drawing.Size(267, 19);
            this.tbIDBill.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Date of issue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Invoice date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Client name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bill ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label8.Location = new System.Drawing.Point(393, 631);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 31);
            this.label8.TabIndex = 4;
            this.label8.Text = "Total prices";
            // 
            // tbSum
            // 
            this.tbSum.BackColor = System.Drawing.Color.White;
            this.tbSum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSum.Font = new System.Drawing.Font("Bell MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.tbSum.Location = new System.Drawing.Point(567, 634);
            this.tbSum.Margin = new System.Windows.Forms.Padding(4);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(193, 16);
            this.tbSum.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(939, 618);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "PRINT";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.textBox6.Location = new System.Drawing.Point(200, 634);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(152, 15);
            this.textBox6.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label9.Location = new System.Drawing.Point(24, 631);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 31);
            this.label9.TabIndex = 9;
            this.label9.Text = "DISCOUNT";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(807, 618);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(125, 52);
            this.btnThanhToan.TabIndex = 11;
            this.btnThanhToan.Text = "PAY";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel7.Location = new System.Drawing.Point(31, 661);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(333, 1);
            this.panel7.TabIndex = 12;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel8.Location = new System.Drawing.Point(400, 661);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(376, 1);
            this.panel8.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.LOGOTDTU;
            this.pictureBox1.Location = new System.Drawing.Point(848, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel9.Location = new System.Drawing.Point(17, 108);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(362, 1);
            this.panel9.TabIndex = 21;
            // 
            // tbSerachTable
            // 
            this.tbSerachTable.BackColor = System.Drawing.Color.White;
            this.tbSerachTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSerachTable.Font = new System.Drawing.Font("Bell MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSerachTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.tbSerachTable.Location = new System.Drawing.Point(118, 76);
            this.tbSerachTable.Margin = new System.Windows.Forms.Padding(4);
            this.tbSerachTable.Name = "tbSerachTable";
            this.tbSerachTable.Size = new System.Drawing.Size(256, 16);
            this.tbSerachTable.TabIndex = 20;
            this.tbSerachTable.TextChanged += new System.EventHandler(this.tbSerachTable_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label10.Location = new System.Drawing.Point(11, 76);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 29);
            this.label10.TabIndex = 19;
            this.label10.Text = "Search";
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1091, 695);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.tbSerachTable);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "ThanhToan";
            this.Text = "ThanhToan";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBill)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBillInfo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox tbSerachTable;
        private System.Windows.Forms.Label label10;
    }
}