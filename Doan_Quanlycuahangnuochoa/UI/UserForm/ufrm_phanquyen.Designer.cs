namespace Doan_Quanlycuahangnuochoa.UI.UserForm
{
    partial class ufrm_phanquyen
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_maphanquyen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mucluonglamviec = new System.Windows.Forms.TextBox();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.txt_tenphanquyen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_phanquyen = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.btn_don = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phanquyen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phân quyền:";
            // 
            // txt_maphanquyen
            // 
            this.txt_maphanquyen.Enabled = false;
            this.txt_maphanquyen.Location = new System.Drawing.Point(214, 180);
            this.txt_maphanquyen.Name = "txt_maphanquyen";
            this.txt_maphanquyen.Size = new System.Drawing.Size(282, 22);
            this.txt_maphanquyen.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên phân quyền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mô tả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mức lương làm việc:";
            // 
            // txt_mucluonglamviec
            // 
            this.txt_mucluonglamviec.Location = new System.Drawing.Point(214, 311);
            this.txt_mucluonglamviec.Name = "txt_mucluonglamviec";
            this.txt_mucluonglamviec.Size = new System.Drawing.Size(282, 22);
            this.txt_mucluonglamviec.TabIndex = 6;
            // 
            // txt_mota
            // 
            this.txt_mota.Location = new System.Drawing.Point(214, 265);
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(282, 22);
            this.txt_mota.TabIndex = 7;
            // 
            // txt_tenphanquyen
            // 
            this.txt_tenphanquyen.Location = new System.Drawing.Point(214, 221);
            this.txt_tenphanquyen.Name = "txt_tenphanquyen";
            this.txt_tenphanquyen.Size = new System.Drawing.Size(282, 22);
            this.txt_tenphanquyen.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(320, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "THÔNG TIN PHÂN QUYỀN";
            // 
            // dgv_phanquyen
            // 
            this.dgv_phanquyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_phanquyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phanquyen.Location = new System.Drawing.Point(38, 389);
            this.dgv_phanquyen.Name = "dgv_phanquyen";
            this.dgv_phanquyen.RowHeadersWidth = 51;
            this.dgv_phanquyen.RowTemplate.Height = 24;
            this.dgv_phanquyen.Size = new System.Drawing.Size(979, 204);
            this.dgv_phanquyen.TabIndex = 10;
            this.dgv_phanquyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_phanquyen_CellClick);
            this.dgv_phanquyen.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_phanquyen_CellFormatting);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(589, 194);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(183, 49);
            this.btn_them.TabIndex = 11;
            this.btn_them.Text = "THÊM";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(589, 282);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(183, 49);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(824, 194);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(183, 49);
            this.btn_xoa.TabIndex = 13;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(295, 108);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(477, 22);
            this.txt_timkiem.TabIndex = 14;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_don
            // 
            this.btn_don.Location = new System.Drawing.Point(824, 279);
            this.btn_don.Name = "btn_don";
            this.btn_don.Size = new System.Drawing.Size(183, 49);
            this.btn_don.TabIndex = 15;
            this.btn_don.Text = "DỌN";
            this.btn_don.UseVisualStyleBackColor = true;
            // 
            // ufrm_phanquyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_don);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_phanquyen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tenphanquyen);
            this.Controls.Add(this.txt_mota);
            this.Controls.Add(this.txt_mucluonglamviec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_maphanquyen);
            this.Controls.Add(this.label1);
            this.Name = "ufrm_phanquyen";
            this.Size = new System.Drawing.Size(1133, 843);
            this.Load += new System.EventHandler(this.ufrm_phanquyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phanquyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_maphanquyen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mucluonglamviec;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.TextBox txt_tenphanquyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_phanquyen;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_don;
    }
}
