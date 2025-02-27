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
            this.dgv_loaikh = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tenloaikh = new System.Windows.Forms.TextBox();
            this.txt_giamgia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_maloaikh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_trolai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaikh)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_don
            // 
            this.btn_don.Location = new System.Drawing.Point(859, 263);
            this.btn_don.Name = "btn_don";
            this.btn_don.Size = new System.Drawing.Size(183, 49);
            this.btn_don.TabIndex = 46;
            this.btn_don.Text = "DỌN";
            this.btn_don.UseVisualStyleBackColor = true;
            this.btn_don.Click += new System.EventHandler(this.btn_don_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(377, 94);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(477, 22);
            this.txt_timkiem.TabIndex = 45;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(859, 178);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(183, 49);
            this.btn_xoa.TabIndex = 44;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(624, 266);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(183, 49);
            this.btn_sua.TabIndex = 43;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(624, 178);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(183, 49);
            this.btn_them.TabIndex = 42;
            this.btn_them.Text = "THÊM";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dgv_loaikh
            // 
            this.dgv_loaikh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_loaikh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loaikh.Location = new System.Drawing.Point(74, 374);
            this.dgv_loaikh.Name = "dgv_loaikh";
            this.dgv_loaikh.RowHeadersWidth = 51;
            this.dgv_loaikh.RowTemplate.Height = 24;
            this.dgv_loaikh.Size = new System.Drawing.Size(979, 204);
            this.dgv_loaikh.TabIndex = 41;
            this.dgv_loaikh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_loaikh_CellClick);
            this.dgv_loaikh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_loaikh_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(402, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(442, 33);
            this.label5.TabIndex = 40;
            this.label5.Text = "THÔNG TIN LOẠI KHÁCH HÀNG";
            // 
            // txt_tenloaikh
            // 
            this.txt_tenloaikh.Location = new System.Drawing.Point(249, 205);
            this.txt_tenloaikh.Name = "txt_tenloaikh";
            this.txt_tenloaikh.Size = new System.Drawing.Size(282, 22);
            this.txt_tenloaikh.TabIndex = 39;
            // 
            // txt_giamgia
            // 
            this.txt_giamgia.Location = new System.Drawing.Point(249, 249);
            this.txt_giamgia.Name = "txt_giamgia";
            this.txt_giamgia.Size = new System.Drawing.Size(282, 22);
            this.txt_giamgia.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 35;
            this.label3.Text = "Giảm giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 22);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tên loại khách hàng:";
            // 
            // txt_maloaikh
            // 
            this.txt_maloaikh.Enabled = false;
            this.txt_maloaikh.Location = new System.Drawing.Point(249, 164);
            this.txt_maloaikh.Name = "txt_maloaikh";
            this.txt_maloaikh.Size = new System.Drawing.Size(282, 22);
            this.txt_maloaikh.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "Mã loại khách hàng:";
            // 
            // btn_trolai
            // 
            this.btn_trolai.Location = new System.Drawing.Point(56, 54);
            this.btn_trolai.Name = "btn_trolai";
            this.btn_trolai.Size = new System.Drawing.Size(140, 62);
            this.btn_trolai.TabIndex = 31;
            this.btn_trolai.Text = "Tro lai";
            this.btn_trolai.UseVisualStyleBackColor = true;
            this.btn_trolai.Click += new System.EventHandler(this.btn_trolai_Click);
            // 
            // loaikhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_don);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_loaikh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tenloaikh);
            this.Controls.Add(this.txt_giamgia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_maloaikh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_trolai);
            this.Name = "loaikhachhang";
            this.Size = new System.Drawing.Size(1133, 843);
            this.Load += new System.EventHandler(this.loaikhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaikh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_don;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgv_loaikh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tenloaikh;
        private System.Windows.Forms.TextBox txt_giamgia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maloaikh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_trolai;
    }
}
