namespace Big_C.UserControls
{
    partial class ViewOrder
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
            this.lichLam1 = new Big_C.UserControls.LichLam();
            this.SuspendLayout();
            // 
            // lichLam1
            // 
            this.lichLam1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lichLam1.Location = new System.Drawing.Point(463, 306);
            this.lichLam1.Margin = new System.Windows.Forms.Padding(4);
            this.lichLam1.Name = "lichLam1";
            this.lichLam1.Size = new System.Drawing.Size(7, 8);
            this.lichLam1.TabIndex = 32;
            // 
            // ViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lichLam1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewOrder";
            this.Size = new System.Drawing.Size(765, 303);
            this.Load += new System.EventHandler(this.ViewOrder_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private LichLam lichLam1;
    }
}
