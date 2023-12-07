
namespace BIG_C.Forms
{
    partial class FormUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLichSuBan = new System.Windows.Forms.Button();
            this.btnLichLam = new System.Windows.Forms.Button();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnLichSuBan);
            this.panel1.Controls.Add(this.btnLichLam);
            this.panel1.Controls.Add(this.btnTinhLuong);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 658);
            this.panel1.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "house.png");
            this.imageList1.Images.SetKeyName(1, "salary.png");
            this.imageList1.Images.SetKeyName(2, "schedule.png");
            this.imageList1.Images.SetKeyName(3, "shop.png");
            this.imageList1.Images.SetKeyName(4, "history.png");
            this.imageList1.Images.SetKeyName(5, "management.png");
            this.imageList1.Images.SetKeyName(6, "log-out.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 100);
            this.panel2.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContainer.Location = new System.Drawing.Point(213, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(928, 658);
            this.panelContainer.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.ImageKey = "log-out.png";
            this.btnExit.ImageList = this.imageList1;
            this.btnExit.Location = new System.Drawing.Point(0, 583);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnExit.Size = new System.Drawing.Size(207, 75);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "EXIT";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLichSuBan
            // 
            this.btnLichSuBan.BackColor = System.Drawing.Color.Red;
            this.btnLichSuBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLichSuBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichSuBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichSuBan.ForeColor = System.Drawing.Color.Transparent;
            this.btnLichSuBan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLichSuBan.ImageKey = "history.png";
            this.btnLichSuBan.ImageList = this.imageList1;
            this.btnLichSuBan.Location = new System.Drawing.Point(0, 325);
            this.btnLichSuBan.Name = "btnLichSuBan";
            this.btnLichSuBan.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLichSuBan.Size = new System.Drawing.Size(207, 75);
            this.btnLichSuBan.TabIndex = 5;
            this.btnLichSuBan.Text = "Phiếu Bán Hàng";
            this.btnLichSuBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichSuBan.UseVisualStyleBackColor = false;
            this.btnLichSuBan.Click += new System.EventHandler(this.btnLichSuBan_Click);
            // 
            // btnLichLam
            // 
            this.btnLichLam.BackColor = System.Drawing.Color.Red;
            this.btnLichLam.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLichLam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichLam.ForeColor = System.Drawing.Color.Transparent;
            this.btnLichLam.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLichLam.ImageKey = "schedule.png";
            this.btnLichLam.ImageList = this.imageList1;
            this.btnLichLam.Location = new System.Drawing.Point(0, 250);
            this.btnLichLam.Name = "btnLichLam";
            this.btnLichLam.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLichLam.Size = new System.Drawing.Size(207, 75);
            this.btnLichLam.TabIndex = 3;
            this.btnLichLam.Text = "Lịch Làm";
            this.btnLichLam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichLam.UseVisualStyleBackColor = false;
            this.btnLichLam.Click += new System.EventHandler(this.btnLichLam_Click);
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.BackColor = System.Drawing.Color.Red;
            this.btnTinhLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTinhLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhLuong.ForeColor = System.Drawing.Color.Transparent;
            this.btnTinhLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTinhLuong.ImageKey = "salary.png";
            this.btnTinhLuong.ImageList = this.imageList1;
            this.btnTinhLuong.Location = new System.Drawing.Point(0, 175);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTinhLuong.Size = new System.Drawing.Size(207, 75);
            this.btnTinhLuong.TabIndex = 2;
            this.btnTinhLuong.Text = "Lương";
            this.btnTinhLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinhLuong.UseVisualStyleBackColor = false;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Red;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Transparent;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.ImageKey = "house.png";
            this.btnHome.ImageList = this.imageList1;
            this.btnHome.Location = new System.Drawing.Point(0, 100);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(207, 75);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Trang Chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContainer);
            this.Name = "FormUser";
            this.Text = "FormUser1";
            this.Load += new System.EventHandler(this.FormUser1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnLichSuBan;
        private System.Windows.Forms.Button btnLichLam;
        private System.Windows.Forms.Button btnTinhLuong;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContainer;
    }
}