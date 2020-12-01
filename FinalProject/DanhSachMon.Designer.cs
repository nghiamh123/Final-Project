namespace FinalProject
{
    partial class DanhSachMon
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbCategoryFood = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbFoodname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgFood = new System.Windows.Forms.DataGridView();
            this.btnThemMonAn = new System.Windows.Forms.Button();
            this.btnXoaMonAn = new System.Windows.Forms.Button();
            this.btnSuaMonAn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFood)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH MÓN ĂN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.tbCategoryFood);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbPrice);
            this.groupBox1.Controls.Add(this.tbFoodname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(465, 186);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin món ăn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(332, 12);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 22);
            this.tbID.TabIndex = 10;
            // 
            // tbCategoryFood
            // 
            this.tbCategoryFood.Location = new System.Drawing.Point(124, 82);
            this.tbCategoryFood.Margin = new System.Windows.Forms.Padding(4);
            this.tbCategoryFood.Name = "tbCategoryFood";
            this.tbCategoryFood.Size = new System.Drawing.Size(308, 22);
            this.tbCategoryFood.TabIndex = 9;
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
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(124, 124);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(308, 22);
            this.tbPrice.TabIndex = 5;
            // 
            // tbFoodname
            // 
            this.tbFoodname.Location = new System.Drawing.Point(124, 41);
            this.tbFoodname.Margin = new System.Windows.Forms.Padding(4);
            this.tbFoodname.Name = "tbFoodname";
            this.tbFoodname.Size = new System.Drawing.Size(308, 22);
            this.tbFoodname.TabIndex = 3;
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
            // dtgFood
            // 
            this.dtgFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFood.Location = new System.Drawing.Point(487, 86);
            this.dtgFood.Margin = new System.Windows.Forms.Padding(4);
            this.dtgFood.Name = "dtgFood";
            this.dtgFood.RowHeadersWidth = 51;
            this.dtgFood.Size = new System.Drawing.Size(561, 257);
            this.dtgFood.TabIndex = 5;
            this.dtgFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFood_CellClick);
            // 
            // btnThemMonAn
            // 
            this.btnThemMonAn.Location = new System.Drawing.Point(16, 279);
            this.btnThemMonAn.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemMonAn.Name = "btnThemMonAn";
            this.btnThemMonAn.Size = new System.Drawing.Size(131, 64);
            this.btnThemMonAn.TabIndex = 8;
            this.btnThemMonAn.Text = "Thêm";
            this.btnThemMonAn.UseVisualStyleBackColor = true;
            this.btnThemMonAn.Click += new System.EventHandler(this.btnThemMonAn_Click);
            // 
            // btnXoaMonAn
            // 
            this.btnXoaMonAn.Location = new System.Drawing.Point(155, 279);
            this.btnXoaMonAn.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaMonAn.Name = "btnXoaMonAn";
            this.btnXoaMonAn.Size = new System.Drawing.Size(129, 64);
            this.btnXoaMonAn.TabIndex = 9;
            this.btnXoaMonAn.Text = "Xóa";
            this.btnXoaMonAn.UseVisualStyleBackColor = true;
            this.btnXoaMonAn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSuaMonAn
            // 
            this.btnSuaMonAn.Location = new System.Drawing.Point(295, 279);
            this.btnSuaMonAn.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaMonAn.Name = "btnSuaMonAn";
            this.btnSuaMonAn.Size = new System.Drawing.Size(152, 64);
            this.btnSuaMonAn.TabIndex = 10;
            this.btnSuaMonAn.Text = "Sửa";
            this.btnSuaMonAn.UseVisualStyleBackColor = true;
            this.btnSuaMonAn.Click += new System.EventHandler(this.btnSuaMonAn_Click);
            // 
            // DanhSachMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 377);
            this.Controls.Add(this.btnSuaMonAn);
            this.Controls.Add(this.btnXoaMonAn);
            this.Controls.Add(this.btnThemMonAn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgFood);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DanhSachMon";
            this.Text = "DanhSachMon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCategoryFood;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbFoodname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgFood;
        private System.Windows.Forms.Button btnThemMonAn;
        private System.Windows.Forms.Button btnXoaMonAn;
        private System.Windows.Forms.Button btnSuaMonAn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbID;
    }
}