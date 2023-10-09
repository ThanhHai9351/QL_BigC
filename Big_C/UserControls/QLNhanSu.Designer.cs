namespace Big_C.UserControls
{
    partial class QLNhanSu
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
            this.dtGrView_NhanVien = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCreateNV = new System.Windows.Forms.Button();
            this.btnEditDeleteNV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrView_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrView_NhanVien
            // 
            this.dtGrView_NhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dtGrView_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrView_NhanVien.Location = new System.Drawing.Point(0, 175);
            this.dtGrView_NhanVien.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtGrView_NhanVien.Name = "dtGrView_NhanVien";
            this.dtGrView_NhanVien.RowHeadersWidth = 51;
            this.dtGrView_NhanVien.RowTemplate.Height = 24;
            this.dtGrView_NhanVien.Size = new System.Drawing.Size(809, 383);
            this.dtGrView_NhanVien.TabIndex = 0;
            this.dtGrView_NhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrView_NhanVien_CellContentClick);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Firebrick;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(39, 37);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(238, 93);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load danh sách nhân viên";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCreateNV
            // 
            this.btnCreateNV.BackColor = System.Drawing.Color.Firebrick;
            this.btnCreateNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNV.ForeColor = System.Drawing.Color.White;
            this.btnCreateNV.Location = new System.Drawing.Point(523, 37);
            this.btnCreateNV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCreateNV.Name = "btnCreateNV";
            this.btnCreateNV.Size = new System.Drawing.Size(240, 93);
            this.btnCreateNV.TabIndex = 2;
            this.btnCreateNV.Text = "Thêm nhân viên mới";
            this.btnCreateNV.UseVisualStyleBackColor = false;
            this.btnCreateNV.Click += new System.EventHandler(this.btnCreateNV_Click);
            // 
            // btnEditDeleteNV
            // 
            this.btnEditDeleteNV.BackColor = System.Drawing.Color.Firebrick;
            this.btnEditDeleteNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDeleteNV.ForeColor = System.Drawing.Color.White;
            this.btnEditDeleteNV.Location = new System.Drawing.Point(281, 37);
            this.btnEditDeleteNV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEditDeleteNV.Name = "btnEditDeleteNV";
            this.btnEditDeleteNV.Size = new System.Drawing.Size(238, 93);
            this.btnEditDeleteNV.TabIndex = 3;
            this.btnEditDeleteNV.Text = "Sửa, xóa nhân viên";
            this.btnEditDeleteNV.UseVisualStyleBackColor = false;
            this.btnEditDeleteNV.Click += new System.EventHandler(this.btnEditDeleteNV_Click);
            // 
            // QLNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnEditDeleteNV);
            this.Controls.Add(this.btnCreateNV);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dtGrView_NhanVien);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QLNhanSu";
            this.Size = new System.Drawing.Size(811, 558);
            this.Load += new System.EventHandler(this.QLNhanSu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrView_NhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrView_NhanVien;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCreateNV;
        private System.Windows.Forms.Button btnEditDeleteNV;
    }
}
