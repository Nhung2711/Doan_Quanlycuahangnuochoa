namespace Doan_Quanlycuahangnuochoa.UI.UserForm
{
    partial class thongtinnhanvien
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
            this.btn_don = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dtnv = new System.Windows.Forms.TextBox();
            this.txt_diachinv = new System.Windows.Forms.TextBox();
            this.txt_tongngaycong = new System.Windows.Forms.TextBox();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.txt_tongluong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.qlchnuochoaDataSet1 = new Doan_Quanlycuahangnuochoa.QLCHNUOCHOADataSet();
            this.dtnsnhanvien = new System.Windows.Forms.DateTimePicker();
            this.cb_taikhoan = new System.Windows.Forms.ComboBox();
            this.qlchnuochoaDataSet2 = new Doan_Quanlycuahangnuochoa.QLCHNUOCHOADataSet();
            this.dgv_nhanvien = new System.Windows.Forms.DataGridView();
            this.btn_trolai = new System.Windows.Forms.Button();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qlchnuochoaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlchnuochoaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_don
            // 
            this.btn_don.Location = new System.Drawing.Point(712, 366);
            this.btn_don.Name = "btn_don";
            this.btn_don.Size = new System.Drawing.Size(114, 33);
            this.btn_don.TabIndex = 18;
            this.btn_don.Text = "Thoát";
            this.btn_don.UseVisualStyleBackColor = true;
            this.btn_don.Click += new System.EventHandler(this.btn_don_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(504, 366);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(104, 32);
            this.btn_xoa.TabIndex = 17;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(341, 367);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(86, 32);
            this.btn_sua.TabIndex = 16;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(172, 368);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(93, 33);
            this.btn_them.TabIndex = 15;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(303, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(353, 35);
            this.label6.TabIndex = 12;
            this.label6.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(551, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(69, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "Địa chỉ:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(544, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tổng ngày công:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(74, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(67, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tên nhân viên:";
            // 
            // txt_dtnv
            // 
            this.txt_dtnv.Location = new System.Drawing.Point(708, 174);
            this.txt_dtnv.Name = "txt_dtnv";
            this.txt_dtnv.Size = new System.Drawing.Size(237, 22);
            this.txt_dtnv.TabIndex = 31;
            // 
            // txt_diachinv
            // 
            this.txt_diachinv.Location = new System.Drawing.Point(248, 305);
            this.txt_diachinv.Name = "txt_diachinv";
            this.txt_diachinv.Size = new System.Drawing.Size(237, 22);
            this.txt_diachinv.TabIndex = 30;
            // 
            // txt_tongngaycong
            // 
            this.txt_tongngaycong.Location = new System.Drawing.Point(708, 221);
            this.txt_tongngaycong.Name = "txt_tongngaycong";
            this.txt_tongngaycong.Size = new System.Drawing.Size(237, 22);
            this.txt_tongngaycong.TabIndex = 29;
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(248, 220);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(232, 22);
            this.txt_tennv.TabIndex = 27;
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(238, 174);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(232, 22);
            this.txt_manv.TabIndex = 26;
            // 
            // txt_tongluong
            // 
            this.txt_tongluong.Location = new System.Drawing.Point(708, 265);
            this.txt_tongluong.Name = "txt_tongluong";
            this.txt_tongluong.Size = new System.Drawing.Size(237, 22);
            this.txt_tongluong.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(544, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 22);
            this.label8.TabIndex = 32;
            this.label8.Text = "Tính lương:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(544, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 22);
            this.label9.TabIndex = 34;
            this.label9.Text = "Tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(68, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ngày sinh:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // qlchnuochoaDataSet1
            // 
            this.qlchnuochoaDataSet1.DataSetName = "QLCHNUOCHOADataSet";
            this.qlchnuochoaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtnsnhanvien
            // 
            this.dtnsnhanvien.Location = new System.Drawing.Point(248, 260);
            this.dtnsnhanvien.Name = "dtnsnhanvien";
            this.dtnsnhanvien.Size = new System.Drawing.Size(237, 22);
            this.dtnsnhanvien.TabIndex = 36;
            // 
            // cb_taikhoan
            // 
            this.cb_taikhoan.FormattingEnabled = true;
            this.cb_taikhoan.Location = new System.Drawing.Point(708, 302);
            this.cb_taikhoan.Name = "cb_taikhoan";
            this.cb_taikhoan.Size = new System.Drawing.Size(237, 24);
            this.cb_taikhoan.TabIndex = 37;
            // 
            // qlchnuochoaDataSet2
            // 
            this.qlchnuochoaDataSet2.DataSetName = "QLCHNUOCHOADataSet";
            this.qlchnuochoaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgv_nhanvien
            // 
            this.dgv_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhanvien.Location = new System.Drawing.Point(60, 445);
            this.dgv_nhanvien.Name = "dgv_nhanvien";
            this.dgv_nhanvien.RowHeadersWidth = 51;
            this.dgv_nhanvien.RowTemplate.Height = 24;
            this.dgv_nhanvien.Size = new System.Drawing.Size(936, 196);
            this.dgv_nhanvien.TabIndex = 38;
            this.dgv_nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhanvien_CellClick);
            // 
            // btn_trolai
            // 
            this.btn_trolai.Location = new System.Drawing.Point(28, 37);
            this.btn_trolai.Name = "btn_trolai";
            this.btn_trolai.Size = new System.Drawing.Size(113, 49);
            this.btn_trolai.TabIndex = 39;
            this.btn_trolai.Text = "TRỞ LẠI";
            this.btn_trolai.UseVisualStyleBackColor = true;
            this.btn_trolai.Click += new System.EventHandler(this.btn_trolai_Click);
            // 
            // txt_tim
            // 
            this.txt_tim.Location = new System.Drawing.Point(309, 85);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(398, 22);
            this.txt_tim.TabIndex = 40;
            this.txt_tim.TextChanged += new System.EventHandler(this.txt_tim_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // thongtinnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_tim);
            this.Controls.Add(this.btn_trolai);
            this.Controls.Add(this.dgv_nhanvien);
            this.Controls.Add(this.cb_taikhoan);
            this.Controls.Add(this.dtnsnhanvien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_tongluong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_dtnv);
            this.Controls.Add(this.txt_diachinv);
            this.Controls.Add(this.txt_tongngaycong);
            this.Controls.Add(this.txt_tennv);
            this.Controls.Add(this.txt_manv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_don);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label6);
            this.Name = "thongtinnhanvien";
            this.Size = new System.Drawing.Size(1133, 843);
            this.Load += new System.EventHandler(this.thongtinnhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlchnuochoaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlchnuochoaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_don;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dtnv;
        private System.Windows.Forms.TextBox txt_diachinv;
        private System.Windows.Forms.TextBox txt_tongngaycong;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.TextBox txt_tongluong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private QLCHNUOCHOADataSet qlchnuochoaDataSet1;
        private System.Windows.Forms.DateTimePicker dtnsnhanvien;
        private System.Windows.Forms.ComboBox cb_taikhoan;
        private QLCHNUOCHOADataSet qlchnuochoaDataSet2;
        private System.Windows.Forms.DataGridView dgv_nhanvien;
        private System.Windows.Forms.Button btn_trolai;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
