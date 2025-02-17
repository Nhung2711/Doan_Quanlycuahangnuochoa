namespace Doan_Quanlycuahangnuochoa.UI.UserForm
{
    partial class ufrmquanlysanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ufrmquanlysanpham));
            this.tt_thongtinloaisp = new System.Windows.Forms.ToolStrip();
            this.tt_ttloaisp = new System.Windows.Forms.ToolStripButton();
            this.tt_thongtinsp = new System.Windows.Forms.ToolStripButton();
            this.tt_thongtinloaisp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tt_thongtinloaisp
            // 
            this.tt_thongtinloaisp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tt_thongtinloaisp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tt_ttloaisp,
            this.tt_thongtinsp});
            this.tt_thongtinloaisp.Location = new System.Drawing.Point(0, 0);
            this.tt_thongtinloaisp.Name = "tt_thongtinloaisp";
            this.tt_thongtinloaisp.Size = new System.Drawing.Size(1133, 27);
            this.tt_thongtinloaisp.TabIndex = 0;
            this.tt_thongtinloaisp.Text = "toolStrip1";
            // 
            // tt_ttloaisp
            // 
            this.tt_ttloaisp.Image = ((System.Drawing.Image)(resources.GetObject("tt_ttloaisp.Image")));
            this.tt_ttloaisp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tt_ttloaisp.Name = "tt_ttloaisp";
            this.tt_ttloaisp.Size = new System.Drawing.Size(193, 24);
            this.tt_ttloaisp.Text = "Thông tin loại sản phẩm";
            this.tt_ttloaisp.Click += new System.EventHandler(this.tt_ttloaisp_Click_1);
            // 
            // tt_thongtinsp
            // 
            this.tt_thongtinsp.Image = ((System.Drawing.Image)(resources.GetObject("tt_thongtinsp.Image")));
            this.tt_thongtinsp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tt_thongtinsp.Name = "tt_thongtinsp";
            this.tt_thongtinsp.Size = new System.Drawing.Size(164, 24);
            this.tt_thongtinsp.Text = "Thông tin sản phẩm";
            this.tt_thongtinsp.Click += new System.EventHandler(this.tt_thongtinsp_Click);
            // 
            // ufrmquanlysanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tt_thongtinloaisp);
            this.Name = "ufrmquanlysanpham";
            this.Size = new System.Drawing.Size(1133, 843);
            this.tt_thongtinloaisp.ResumeLayout(false);
            this.tt_thongtinloaisp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tt_thongtinloaisp;
        private System.Windows.Forms.ToolStripButton tt_ttloaisp;
        private System.Windows.Forms.ToolStripButton tt_thongtinsp;
    }
}
