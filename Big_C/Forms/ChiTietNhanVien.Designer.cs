
namespace Big_C
{
    partial class ChiTietNhanVien
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
            this.dtGrView_NhanVien = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrView_NhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrView_NhanVien
            // 
            this.dtGrView_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrView_NhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrView_NhanVien.Location = new System.Drawing.Point(0, 0);
            this.dtGrView_NhanVien.Name = "dtGrView_NhanVien";
            this.dtGrView_NhanVien.RowHeadersWidth = 51;
            this.dtGrView_NhanVien.RowTemplate.Height = 24;
            this.dtGrView_NhanVien.Size = new System.Drawing.Size(1264, 450);
            this.dtGrView_NhanVien.TabIndex = 0;
            this.dtGrView_NhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrView_NhanVien_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(172, 141);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(25, 9);
            this.dataGridView2.TabIndex = 1;
            // 
            // ChiTietNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dtGrView_NhanVien);
            this.Name = "ChiTietNhanVien";
            this.Text = "ChiTietNhanVien";
            this.Load += new System.EventHandler(this.ChiTietNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrView_NhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrView_NhanVien;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}