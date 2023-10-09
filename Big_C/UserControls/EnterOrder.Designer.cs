namespace Big_C.UserControls
{
    partial class EnterOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.cbo_NhaCC = new System.Windows.Forms.ComboBox();
            this.cbo_TenHH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_NgayGiao = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(520, 70);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(153, 25);
            this.txtSoLuong.TabIndex = 43;
            this.txtSoLuong.Leave += new System.EventHandler(this.txtSoLuong_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(397, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Số Lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(397, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Nhà Cung Cấp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Tên Hàng Hóa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mã Phiếu:";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(226, 29);
            this.txtMaPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(153, 25);
            this.txtMaPhieu.TabIndex = 45;
            // 
            // cbo_NhaCC
            // 
            this.cbo_NhaCC.FormattingEnabled = true;
            this.cbo_NhaCC.Location = new System.Drawing.Point(520, 25);
            this.cbo_NhaCC.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_NhaCC.Name = "cbo_NhaCC";
            this.cbo_NhaCC.Size = new System.Drawing.Size(153, 25);
            this.cbo_NhaCC.TabIndex = 46;
            this.cbo_NhaCC.SelectedIndexChanged += new System.EventHandler(this.cbo_NhaCC_SelectedIndexChanged);
            // 
            // cbo_TenHH
            // 
            this.cbo_TenHH.Enabled = false;
            this.cbo_TenHH.FormattingEnabled = true;
            this.cbo_TenHH.Location = new System.Drawing.Point(226, 70);
            this.cbo_TenHH.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_TenHH.Name = "cbo_TenHH";
            this.cbo_TenHH.Size = new System.Drawing.Size(153, 25);
            this.cbo_TenHH.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Tổng Tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(275, 167);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(239, 25);
            this.txtTongTien.TabIndex = 49;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Firebrick;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.Transparent;
            this.btnThanhToan.Location = new System.Drawing.Point(336, 217);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(168, 67);
            this.btnThanhToan.TabIndex = 51;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Mô Tả:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(226, 113);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(153, 25);
            this.txtMoTa.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "Ngày Giao:";
            // 
            // dt_NgayGiao
            // 
            this.dt_NgayGiao.Location = new System.Drawing.Point(520, 113);
            this.dt_NgayGiao.Name = "dt_NgayGiao";
            this.dt_NgayGiao.Size = new System.Drawing.Size(153, 25);
            this.dt_NgayGiao.TabIndex = 56;
            // 
            // EnterOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dt_NgayGiao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_TenHH);
            this.Controls.Add(this.cbo_NhaCC);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EnterOrder";
            this.Size = new System.Drawing.Size(765, 303);
            this.Load += new System.EventHandler(this.EnterOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.ComboBox cbo_NhaCC;
        private System.Windows.Forms.ComboBox cbo_TenHH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt_NgayGiao;
    }
}
