namespace Doan_Quanlycuahangnuochoa.UI.UserForm
{
    partial class ufrm_quanlykhachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ufrm_quanlykhachhang));
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tt_loaikh = new System.Windows.Forms.ToolStripButton();
            this.tt_ttkhachhang = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(514, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 22);
            this.label4.TabIndex = 6;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tt_loaikh,
            this.tt_ttkhachhang});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1829, 27);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tt_loaikh
            // 
            this.tt_loaikh.Image = ((System.Drawing.Image)(resources.GetObject("tt_loaikh.Image")));
            this.tt_loaikh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tt_loaikh.Name = "tt_loaikh";
            this.tt_loaikh.Size = new System.Drawing.Size(140, 24);
            this.tt_loaikh.Text = "Loại khách hàng";
            this.tt_loaikh.Click += new System.EventHandler(this.tt_loaikh_Click);
            // 
            // tt_ttkhachhang
            // 
            this.tt_ttkhachhang.Image = ((System.Drawing.Image)(resources.GetObject("tt_ttkhachhang.Image")));
            this.tt_ttkhachhang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tt_ttkhachhang.Name = "tt_ttkhachhang";
            this.tt_ttkhachhang.Size = new System.Drawing.Size(175, 24);
            this.tt_ttkhachhang.Text = "Thông tin khách hàng";
            this.tt_ttkhachhang.Click += new System.EventHandler(this.tt_ttkhachhang_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Location = new System.Drawing.Point(0, 27);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1829, 25);
            this.toolStrip2.TabIndex = 8;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // ufrm_quanlykhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.Name = "ufrm_quanlykhachhang";
            this.Size = new System.Drawing.Size(1829, 890);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tt_loaikh;
        private System.Windows.Forms.ToolStripButton tt_ttkhachhang;
        private System.Windows.Forms.ToolStrip toolStrip2;
    }
}
