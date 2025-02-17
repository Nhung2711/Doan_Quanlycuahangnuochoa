namespace Doan_Quanlycuahangnuochoa.UI.UserForm
{
    partial class loaikhachhang
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
            this.dgv_loaikhachhang = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tenloaikhachhang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_maloaikhachhang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_giamgia = new System.Windows.Forms.TextBox();
            this.btn_quaylai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaikhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_don
            // 
            this.btn_don.Location = new System.Drawing.Point(853, 255);
            this.btn_don.Name = "btn_don";
            this.btn_don.Size = new System.Drawing.Size(183, 49);
            this.btn_don.TabIndex = 30;
            this.btn_don.Text = "DỌN";
            this.btn_don.UseVisualStyleBackColor = true;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(324, 108);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(477, 22);
            this.txt_timkiem.TabIndex = 29;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(853, 167);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(183, 49);
            this.btn_xoa.TabIndex = 28;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(642, 255);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(183, 49);
            this.btn_sua.TabIndex = 27;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(633, 167);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(183, 49);
            this.btn_them.TabIndex = 26;
            this.btn_them.Text = "THÊM";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dgv_loaikhachhang
            // 
            this.dgv_loaikhachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_loaikhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loaikhachhang.Location = new System.Drawing.Point(67, 389);
            this.dgv_loaikhachhang.Name = "dgv_loaikhachhang";
            this.dgv_loaikhachhang.RowHeadersWidth = 51;
            this.dgv_loaikhachhang.RowTemplate.Height = 24;
            this.dgv_loaikhachhang.Size = new System.Drawing.Size(979, 204);
            this.dgv_loaikhachhang.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(349, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(442, 33);
            this.label5.TabIndex = 24;
            this.label5.Text = "THÔNG TIN LOẠI KHÁCH HÀNG";
            // 
            // txt_tenloaikhachhang
            // 
            this.txt_tenloaikhachhang.Location = new System.Drawing.Point(243, 230);
            this.txt_tenloaikhachhang.Name = "txt_tenloaikhachhang";
            this.txt_tenloaikhachhang.Size = new System.Drawing.Size(282, 22);
            this.txt_tenloaikhachhang.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên loại khách hàng:";
            // 
            // txt_maloaikhachhang
            // 
            this.txt_maloaikhachhang.Enabled = false;
            this.txt_maloaikhachhang.Location = new System.Drawing.Point(243, 180);
            this.txt_maloaikhachhang.Name = "txt_maloaikhachhang";
            this.txt_maloaikhachhang.Size = new System.Drawing.Size(282, 22);
            this.txt_maloaikhachhang.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã loại khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Giảm giá:";
            // 
            // txt_giamgia
            // 
            this.txt_giamgia.Location = new System.Drawing.Point(243, 283);
            this.txt_giamgia.Name = "txt_giamgia";
            this.txt_giamgia.Size = new System.Drawing.Size(282, 22);
            this.txt_giamgia.TabIndex = 32;
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Location = new System.Drawing.Point(19, 37);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(167, 48);
            this.btn_quaylai.TabIndex = 46;
            this.btn_quaylai.Text = "TRỞ LẠI";
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // loaikhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_quaylai);
            this.Controls.Add(this.txt_giamgia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_don);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_loaikhachhang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tenloaikhachhang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_maloaikhachhang);
            this.Controls.Add(this.label1);
            this.Name = "loaikhachhang";
            this.Size = new System.Drawing.Size(1133, 843);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaikhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_don;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgv_loaikhachhang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tenloaikhachhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maloaikhachhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_giamgia;
        private System.Windows.Forms.Button btn_quaylai;
    }
}
