namespace Doan_Quanlycuahangnuochoa.UI.UserForm
{
    partial class Phancongcalam
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
            this.dgv_phancongcalam = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_macalam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_trolai = new System.Windows.Forms.Button();
            this.cb_calam = new System.Windows.Forms.ComboBox();
            this.cb_tennhanvien = new System.Windows.Forms.ComboBox();
            this.qlchnuochoaDataSet1 = new Doan_Quanlycuahangnuochoa.QLCHNUOCHOADataSet();
            this.qlchnuochoaDataSet2 = new Doan_Quanlycuahangnuochoa.QLCHNUOCHOADataSet();
            this.dtngaylam = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phancongcalam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlchnuochoaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlchnuochoaDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_don
            // 
            this.btn_don.Location = new System.Drawing.Point(839, 267);
            this.btn_don.Name = "btn_don";
            this.btn_don.Size = new System.Drawing.Size(183, 49);
            this.btn_don.TabIndex = 46;
            this.btn_don.Text = "DỌN";
            this.btn_don.UseVisualStyleBackColor = true;
            this.btn_don.Click += new System.EventHandler(this.btn_don_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(357, 98);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(477, 22);
            this.txt_timkiem.TabIndex = 45;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(839, 182);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(183, 49);
            this.btn_xoa.TabIndex = 44;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(604, 270);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(183, 49);
            this.btn_sua.TabIndex = 43;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(604, 182);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(183, 49);
            this.btn_them.TabIndex = 42;
            this.btn_them.Text = "THÊM";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dgv_phancongcalam
            // 
            this.dgv_phancongcalam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_phancongcalam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phancongcalam.Location = new System.Drawing.Point(54, 378);
            this.dgv_phancongcalam.Name = "dgv_phancongcalam";
            this.dgv_phancongcalam.RowHeadersWidth = 51;
            this.dgv_phancongcalam.RowTemplate.Height = 24;
            this.dgv_phancongcalam.Size = new System.Drawing.Size(979, 204);
            this.dgv_phancongcalam.TabIndex = 41;
            this.dgv_phancongcalam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_phancongcalam_CellClick);
            this.dgv_phancongcalam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_calam_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(382, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(465, 33);
            this.label5.TabIndex = 40;
            this.label5.Text = "THÔNG TIN PHÂN CÔNG CA LÀM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 38;
            this.label4.Text = "Ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 22);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tên ca làm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tên nhân viên:";
            // 
            // txt_macalam
            // 
            this.txt_macalam.Enabled = false;
            this.txt_macalam.Location = new System.Drawing.Point(229, 168);
            this.txt_macalam.Name = "txt_macalam";
            this.txt_macalam.Size = new System.Drawing.Size(282, 22);
            this.txt_macalam.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 22);
            this.label6.TabIndex = 34;
            this.label6.Text = "Mã phân công:";
            // 
            // btn_trolai
            // 
            this.btn_trolai.Location = new System.Drawing.Point(36, 58);
            this.btn_trolai.Name = "btn_trolai";
            this.btn_trolai.Size = new System.Drawing.Size(140, 62);
            this.btn_trolai.TabIndex = 33;
            this.btn_trolai.Text = "Tro lai";
            this.btn_trolai.UseVisualStyleBackColor = true;
            this.btn_trolai.Click += new System.EventHandler(this.btn_trolai_Click);
            // 
            // cb_calam
            // 
            this.cb_calam.FormattingEnabled = true;
            this.cb_calam.Location = new System.Drawing.Point(229, 253);
            this.cb_calam.Name = "cb_calam";
            this.cb_calam.Size = new System.Drawing.Size(282, 24);
            this.cb_calam.TabIndex = 49;
            // 
            // cb_tennhanvien
            // 
            this.cb_tennhanvien.FormattingEnabled = true;
            this.cb_tennhanvien.Location = new System.Drawing.Point(229, 209);
            this.cb_tennhanvien.Name = "cb_tennhanvien";
            this.cb_tennhanvien.Size = new System.Drawing.Size(282, 24);
            this.cb_tennhanvien.TabIndex = 50;
            // 
            // qlchnuochoaDataSet1
            // 
            this.qlchnuochoaDataSet1.DataSetName = "QLCHNUOCHOADataSet";
            this.qlchnuochoaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qlchnuochoaDataSet2
            // 
            this.qlchnuochoaDataSet2.DataSetName = "QLCHNUOCHOADataSet";
            this.qlchnuochoaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtngaylam
            // 
            this.dtngaylam.Location = new System.Drawing.Point(229, 296);
            this.dtngaylam.Name = "dtngaylam";
            this.dtngaylam.Size = new System.Drawing.Size(282, 22);
            this.dtngaylam.TabIndex = 51;
            // 
            // Phancongcalam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtngaylam);
            this.Controls.Add(this.cb_tennhanvien);
            this.Controls.Add(this.cb_calam);
            this.Controls.Add(this.btn_don);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_phancongcalam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_macalam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_trolai);
            this.Name = "Phancongcalam";
            this.Size = new System.Drawing.Size(1829, 890);
            this.Load += new System.EventHandler(this.Phancongcalam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phancongcalam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlchnuochoaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlchnuochoaDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_don;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgv_phancongcalam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_macalam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_trolai;
        private System.Windows.Forms.ComboBox cb_calam;
        private System.Windows.Forms.ComboBox cb_tennhanvien;
        private QLCHNUOCHOADataSet qlchnuochoaDataSet1;
        private QLCHNUOCHOADataSet qlchnuochoaDataSet2;
        private System.Windows.Forms.DateTimePicker dtngaylam;
    }
}
