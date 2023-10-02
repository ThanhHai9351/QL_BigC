namespace Big_C.UserControls
{
    partial class QLHangKho
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
            this.btnSeeOrder = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnSeeOrder
            // 
            this.btnSeeOrder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSeeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeOrder.Location = new System.Drawing.Point(405, 0);
            this.btnSeeOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeeOrder.Name = "btnSeeOrder";
            this.btnSeeOrder.Size = new System.Drawing.Size(382, 50);
            this.btnSeeOrder.TabIndex = 6;
            this.btnSeeOrder.Text = "See Order";
            this.btnSeeOrder.UseVisualStyleBackColor = false;
            this.btnSeeOrder.Click += new System.EventHandler(this.btnSeeOrder_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(3, 0);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(404, 50);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Enter Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContainer.Location = new System.Drawing.Point(0, 57);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(787, 374);
            this.panelContainer.TabIndex = 7;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // QLHangKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.btnSeeOrder);
            this.Controls.Add(this.btnOrder);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QLHangKho";
            this.Size = new System.Drawing.Size(787, 431);
            this.Load += new System.EventHandler(this.QLHangKho_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeeOrder;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel panelContainer;

    }
}
