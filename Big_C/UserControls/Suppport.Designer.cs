namespace Big_C.UserControls
{
    partial class Suppport
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
            this.txtHoTro = new System.Windows.Forms.TextBox();
            this.btnPhanHoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHoTro
            // 
            this.txtHoTro.Location = new System.Drawing.Point(182, 173);
            this.txtHoTro.Multiline = true;
            this.txtHoTro.Name = "txtHoTro";
            this.txtHoTro.Size = new System.Drawing.Size(463, 239);
            this.txtHoTro.TabIndex = 2;
            this.txtHoTro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPhanHoi
            // 
            this.btnPhanHoi.BackColor = System.Drawing.Color.Firebrick;
            this.btnPhanHoi.ForeColor = System.Drawing.Color.White;
            this.btnPhanHoi.Location = new System.Drawing.Point(532, 418);
            this.btnPhanHoi.Name = "btnPhanHoi";
            this.btnPhanHoi.Size = new System.Drawing.Size(113, 67);
            this.btnPhanHoi.TabIndex = 3;
            this.btnPhanHoi.Text = "Gửi Phản Hồi ";
            this.btnPhanHoi.UseVisualStyleBackColor = false;
            this.btnPhanHoi.Click += new System.EventHandler(this.btnPhanHoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(393, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mọi thắc mắc liên hệ: 0384631254";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(178, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mô tả lỗi bạn đang gặp";
            // 
            // Suppport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPhanHoi);
            this.Controls.Add(this.txtHoTro);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Suppport";
            this.Size = new System.Drawing.Size(814, 632);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtHoTro;
        private System.Windows.Forms.Button btnPhanHoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
