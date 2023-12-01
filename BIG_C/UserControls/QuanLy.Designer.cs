
namespace BIG_C.UserControls
{
    partial class QuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSaveExcel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboChiNhanh = new System.Windows.Forms.ComboBox();
            this.dtNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoNgayLam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_ChiNhanh = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(934, 77);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 10);
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
            this.label1.Size = new System.Drawing.Size(101, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelBottom);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 581);
            this.panel2.TabIndex = 1;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnCreate);
            this.panelBottom.Controls.Add(this.btnSaveExcel);
            this.panelBottom.Controls.Add(this.btnDelete);
            this.panelBottom.Controls.Add(this.btnEdit);
            this.panelBottom.Controls.Add(this.groupBox3);
            this.panelBottom.Controls.Add(this.lvNhanVien);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 68);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(934, 513);
            this.panelBottom.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.ImageIndex = 2;
            this.btnCreate.ImageList = this.imageList1;
            this.btnCreate.Location = new System.Drawing.Point(793, 205);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(122, 57);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
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
            // btnSaveExcel
            // 
            this.btnSaveExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveExcel.BackColor = System.Drawing.Color.MistyRose;
            this.btnSaveExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveExcel.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSaveExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveExcel.ImageKey = "excel.png";
            this.btnSaveExcel.ImageList = this.imageList1;
            this.btnSaveExcel.Location = new System.Drawing.Point(793, 432);
            this.btnSaveExcel.Name = "btnSaveExcel";
            this.btnSaveExcel.Size = new System.Drawing.Size(122, 57);
            this.btnSaveExcel.TabIndex = 7;
            this.btnSaveExcel.Text = "Excel";
            this.btnSaveExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveExcel.UseVisualStyleBackColor = false;
            this.btnSaveExcel.Click += new System.EventHandler(this.btnSaveExcel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.MistyRose;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageIndex = 3;
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(793, 354);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 57);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.Gold;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.ImageIndex = 4;
            this.btnEdit.ImageList = this.imageList1;
            this.btnEdit.Location = new System.Drawing.Point(793, 281);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(122, 57);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboChiNhanh);
            this.groupBox3.Controls.Add(this.dtNgayVaoLam);
            this.groupBox3.Controls.Add(this.dtNgaySinh);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtSoNgayLam);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtCCCD);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtSDT);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtDiaChi);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtTen);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtMa);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(21, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(742, 284);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhân Viên";
            // 
            // cboChiNhanh
            // 
            this.cboChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChiNhanh.FormattingEnabled = true;
            this.cboChiNhanh.Location = new System.Drawing.Point(499, 188);
            this.cboChiNhanh.Name = "cboChiNhanh";
            this.cboChiNhanh.Size = new System.Drawing.Size(190, 28);
            this.cboChiNhanh.TabIndex = 1;
            // 
            // dtNgayVaoLam
            // 
            this.dtNgayVaoLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayVaoLam.Location = new System.Drawing.Point(500, 93);
            this.dtNgayVaoLam.Name = "dtNgayVaoLam";
            this.dtNgayVaoLam.Size = new System.Drawing.Size(189, 26);
            this.dtNgayVaoLam.TabIndex = 19;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaySinh.Location = new System.Drawing.Point(119, 138);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(189, 26);
            this.dtNgaySinh.TabIndex = 18;
            this.dtNgaySinh.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Chi Nhánh:";
            // 
            // txtSoNgayLam
            // 
            this.txtSoNgayLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNgayLam.Location = new System.Drawing.Point(499, 137);
            this.txtSoNgayLam.Name = "txtSoNgayLam";
            this.txtSoNgayLam.Size = new System.Drawing.Size(190, 26);
            this.txtSoNgayLam.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Số ngày làm:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(367, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ngày vào làm";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Location = new System.Drawing.Point(499, 44);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(190, 26);
            this.txtCCCD.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(367, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "CCCD:";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(118, 241);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(190, 26);
            this.txtSDT.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "SDT:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(119, 189);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(190, 26);
            this.txtDiaChi.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(119, 90);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(190, 26);
            this.txtTen.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên:";
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(118, 41);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(190, 26);
            this.txtMa.TabIndex = 1;
            this.txtMa.Leave += new System.EventHandler(this.txtMa_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã:";
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
            this.lvNhanVien.Size = new System.Drawing.Size(934, 199);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReload);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(934, 71);
            this.panel3.TabIndex = 0;
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
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLy";
            this.Size = new System.Drawing.Size(934, 658);
            this.Load += new System.EventHandler(this.QuanLy_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnSaveExcel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox3;
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo_ChiNhanh;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoNgayLam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtNgayVaoLam;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.ComboBox cboChiNhanh;
    }
}
