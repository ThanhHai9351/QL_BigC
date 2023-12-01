
namespace BIG_C.UserControls
{
    partial class LichLams
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LichLams));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_ChiNhanh = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lvLichLam = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ca1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvNhanVien = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 71);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(144, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch Làm";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReload);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(934, 71);
            this.panel3.TabIndex = 2;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.Transparent;
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReload.ImageKey = "refresh.png";
            this.btnReload.ImageList = this.imageList1;
            this.btnReload.Location = new System.Drawing.Point(746, 10);
            this.btnReload.Name = "btnReload";
            this.btnReload.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnReload.Size = new System.Drawing.Size(169, 52);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "RELOAD";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "refresh.png");
            this.imageList1.Images.SetKeyName(1, "loupe.png");
            this.imageList1.Images.SetKeyName(2, "add-user.png");
            this.imageList1.Images.SetKeyName(3, "delete.png");
            this.imageList1.Images.SetKeyName(4, "edit.png");
            this.imageList1.Images.SetKeyName(5, "excel.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_ChiNhanh);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(446, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 44);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Nhánh";
            // 
            // cbo_ChiNhanh
            // 
            this.cbo_ChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_ChiNhanh.FormattingEnabled = true;
            this.cbo_ChiNhanh.Location = new System.Drawing.Point(3, 18);
            this.cbo_ChiNhanh.Name = "cbo_ChiNhanh";
            this.cbo_ChiNhanh.Size = new System.Drawing.Size(211, 24);
            this.cbo_ChiNhanh.TabIndex = 0;
            this.cbo_ChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbo_ChiNhanh_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Brown;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.ImageKey = "loupe.png";
            this.btnSearch.ImageList = this.imageList1;
            this.btnSearch.Location = new System.Drawing.Point(236, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnSearch.Size = new System.Drawing.Size(158, 52);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(54, 14);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(176, 44);
            this.txtSearch.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.lvLichLam);
            this.panelBottom.Controls.Add(this.lvNhanVien);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 148);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(934, 511);
            this.panelBottom.TabIndex = 3;
            this.panelBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBottom_Paint);
            // 
            // lvLichLam
            // 
            this.lvLichLam.BackColor = System.Drawing.Color.Salmon;
            this.lvLichLam.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Ca1,
            this.Ca,
            this.columnHeader22,
            this.columnHeader19});
            this.lvLichLam.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvLichLam.FullRowSelect = true;
            this.lvLichLam.GridLines = true;
            this.lvLichLam.HideSelection = false;
            this.lvLichLam.Location = new System.Drawing.Point(0, 200);
            this.lvLichLam.Name = "lvLichLam";
            this.lvLichLam.Size = new System.Drawing.Size(934, 308);
            this.lvLichLam.TabIndex = 1;
            this.lvLichLam.UseCompatibleStateImageBehavior = false;
            this.lvLichLam.View = System.Windows.Forms.View.Details;
            this.lvLichLam.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvLichLam_DrawColumnHeader);
            this.lvLichLam.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lvLichLam_DrawItem);
            // 
            // Date
            // 
            this.Date.Text = "Date";
            // 
            // Ca1
            // 
            this.Ca1.Text = "Ca1";
            this.Ca1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ca1.Width = 186;
            // 
            // Ca
            // 
            this.Ca.Text = "Ca2";
            this.Ca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ca.Width = 243;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Ca3";
            this.columnHeader22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader22.Width = 274;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Ca4";
            this.columnHeader19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader19.Width = 238;
            // 
            // lvNhanVien
            // 
            this.lvNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvNhanVien.FullRowSelect = true;
            this.lvNhanVien.HideSelection = false;
            this.lvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.lvNhanVien.Name = "lvNhanVien";
            this.lvNhanVien.Size = new System.Drawing.Size(934, 200);
            this.lvNhanVien.TabIndex = 0;
            this.lvNhanVien.UseCompatibleStateImageBehavior = false;
            this.lvNhanVien.View = System.Windows.Forms.View.Details;
            this.lvNhanVien.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvNhanVien_DrawColumnHeader);
            this.lvNhanVien.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lvNhanVien_DrawItem);
            this.lvNhanVien.SelectedIndexChanged += new System.EventHandler(this.lvNhanVien_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên";
            this.columnHeader2.Width = 114;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày Sinh";
            this.columnHeader3.Width = 136;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Địa Chỉ";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SDT";
            this.columnHeader5.Width = 124;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "CCCD";
            this.columnHeader6.Width = 123;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ngày Vào Làm";
            this.columnHeader7.Width = 146;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Số Ngày Làm";
            this.columnHeader8.Width = 172;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Chi Nhánh";
            this.columnHeader9.Width = 323;
            // 
            // LichLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "LichLam";
            this.Size = new System.Drawing.Size(934, 659);
            this.Load += new System.EventHandler(this.LichLam_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo_ChiNhanh;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.ListView lvNhanVien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView lvLichLam;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Ca1;
        private System.Windows.Forms.ColumnHeader Ca;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader19;
    }
}
