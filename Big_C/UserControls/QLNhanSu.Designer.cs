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
            ((System.ComponentModel.ISupportInitialize)(this.dtGrView_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrView_NhanVien
            // 
            this.dtGrView_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrView_NhanVien.Location = new System.Drawing.Point(0, 131);
            this.dtGrView_NhanVien.Name = "dtGrView_NhanVien";
            this.dtGrView_NhanVien.RowHeadersWidth = 51;
            this.dtGrView_NhanVien.RowTemplate.Height = 24;
            this.dtGrView_NhanVien.Size = new System.Drawing.Size(790, 314);
            this.dtGrView_NhanVien.TabIndex = 0;
            this.dtGrView_NhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrView_NhanVien_CellContentClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(66, 28);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(169, 50);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load danh sách nhân viên";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // QLNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dtGrView_NhanVien);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLNhanSu";
            this.Size = new System.Drawing.Size(790, 445);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrView_NhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrView_NhanVien;
        private System.Windows.Forms.Button btnLoad;
    }
}
