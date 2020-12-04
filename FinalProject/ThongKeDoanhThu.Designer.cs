
namespace FinalProject
{
    partial class ThongKeDoanhThu
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
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgBill = new System.Windows.Forms.DataGridView();
            this.tbTongDoanhThu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTongBill = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDoanhThuDon = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(98, 44);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(200, 22);
            this.dtFrom.TabIndex = 0;
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(433, 44);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(200, 22);
            this.dtTo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // dtgBill
            // 
            this.dtgBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBill.Location = new System.Drawing.Point(98, 87);
            this.dtgBill.Name = "dtgBill";
            this.dtgBill.RowHeadersWidth = 51;
            this.dtgBill.RowTemplate.Height = 24;
            this.dtgBill.Size = new System.Drawing.Size(640, 269);
            this.dtgBill.TabIndex = 4;
            this.dtgBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBill_CellClick);
            // 
            // tbTongDoanhThu
            // 
            this.tbTongDoanhThu.Location = new System.Drawing.Point(370, 457);
            this.tbTongDoanhThu.Name = "tbTongDoanhThu";
            this.tbTongDoanhThu.Size = new System.Drawing.Size(154, 22);
            this.tbTongDoanhThu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tổng doanh thu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tỏng bill";
            // 
            // tbTongBill
            // 
            this.tbTongBill.Location = new System.Drawing.Point(228, 390);
            this.tbTongBill.Name = "tbTongBill";
            this.tbTongBill.Size = new System.Drawing.Size(100, 22);
            this.tbTongBill.TabIndex = 8;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(767, 241);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 9;
            this.btnCheck.Text = "Lọc";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Doanh Thu Từng Đơn Hàng";
            // 
            // tbDoanhThuDon
            // 
            this.tbDoanhThuDon.Location = new System.Drawing.Point(576, 388);
            this.tbDoanhThuDon.Name = "tbDoanhThuDon";
            this.tbDoanhThuDon.Size = new System.Drawing.Size(123, 22);
            this.tbDoanhThuDon.TabIndex = 11;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(767, 166);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 495);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbDoanhThuDon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.tbTongBill);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTongDoanhThu);
            this.Controls.Add(this.dtgBill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Name = "ThongKeDoanhThu";
            this.Text = "ThongKeDoanhThu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgBill;
        private System.Windows.Forms.TextBox tbTongDoanhThu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTongBill;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDoanhThuDon;
        private System.Windows.Forms.Button btnReset;
    }
}