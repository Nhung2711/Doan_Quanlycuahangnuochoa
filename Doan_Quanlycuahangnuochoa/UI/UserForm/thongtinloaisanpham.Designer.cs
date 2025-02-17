namespace Doan_Quanlycuahangnuochoa.UI.UserForm
{
    partial class thongtinloaisanpham
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
            this.btn_don = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgv_loaisanpham = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tenloaisanpham = new System.Windows.Forms.TextBox();
            this.txt_maloaisanpham = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_quaylai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaisanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_don
            // 
            this.btn_don.Location = new System.Drawing.Point(801, 332);
            this.btn_don.Name = "btn_don";
            this.btn_don.Size = new System.Drawing.Size(183, 49);
            this.btn_don.TabIndex = 41;
            this.btn_don.Text = "DỌN";
            this.btn_don.UseVisualStyleBackColor = true;
            this.btn_don.Click += new System.EventHandler(this.btn_don_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(312, 125);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(477, 22);
            this.txt_timkiem.TabIndex = 40;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(554, 332);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(183, 49);
            this.btn_xoa.TabIndex = 39;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(312, 332);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(183, 49);
            this.btn_sua.TabIndex = 38;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(80, 332);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(183, 49);
            this.btn_them.TabIndex = 37;
            this.btn_them.Text = "THÊM";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dgv_loaisanpham
            // 
            this.dgv_loaisanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_loaisanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loaisanpham.Location = new System.Drawing.Point(29, 400);
            this.dgv_loaisanpham.Name = "dgv_loaisanpham";
            this.dgv_loaisanpham.RowHeadersWidth = 51;
            this.dgv_loaisanpham.RowTemplate.Height = 24;
            this.dgv_loaisanpham.Size = new System.Drawing.Size(979, 204);
            this.dgv_loaisanpham.TabIndex = 36;
            this.dgv_loaisanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_loaikhachhang_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(337, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(400, 33);
            this.label5.TabIndex = 35;
            this.label5.Text = "THÔNG TIN LOẠI SẢN PHẨM";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_tenloaisanpham
            // 
            this.txt_tenloaisanpham.Location = new System.Drawing.Point(231, 247);
            this.txt_tenloaisanpham.Name = "txt_tenloaisanpham";
            this.txt_tenloaisanpham.Size = new System.Drawing.Size(282, 22);
            this.txt_tenloaisanpham.TabIndex = 34;
            this.txt_tenloaisanpham.TextChanged += new System.EventHandler(this.txt_tenloaikhachhang_TextChanged);
            // 
            // txt_maloaisanpham
            // 
            this.txt_maloaisanpham.Enabled = false;
            this.txt_maloaisanpham.Location = new System.Drawing.Point(231, 197);
            this.txt_maloaisanpham.Name = "txt_maloaisanpham";
            this.txt_maloaisanpham.Size = new System.Drawing.Size(282, 22);
            this.txt_maloaisanpham.TabIndex = 33;
            this.txt_maloaisanpham.TextChanged += new System.EventHandler(this.txt_maloaikhachhang_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 22);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tên loại sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 22);
            this.label1.TabIndex = 43;
            this.label1.Text = "Mã loại sản phẩm:";
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Location = new System.Drawing.Point(14, 27);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(167, 48);
            this.btn_quaylai.TabIndex = 45;
            this.btn_quaylai.Text = "TRỞ LẠI";
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // thongtinloaisanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_quaylai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_don);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_loaisanpham);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tenloaisanpham);
            this.Controls.Add(this.txt_maloaisanpham);
            this.Name = "thongtinloaisanpham";
            this.Size = new System.Drawing.Size(1133, 843);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaisanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_don;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgv_loaisanpham;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tenloaisanpham;
        private System.Windows.Forms.TextBox txt_maloaisanpham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_quaylai;
    }
}
