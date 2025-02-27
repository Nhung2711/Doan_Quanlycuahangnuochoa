namespace Doan_Quanlycuahangnuochoa.UI.UserForm
{
    partial class thongtincalam
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
            this.btn_trolai = new System.Windows.Forms.Button();
            this.btn_don = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgv_calam = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tencalam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_macalam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.time_batDau = new System.Windows.Forms.DateTimePicker();
            this.time_KetThuc = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_calam)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_trolai
            // 
            this.btn_trolai.Location = new System.Drawing.Point(36, 56);
            this.btn_trolai.Name = "btn_trolai";
            this.btn_trolai.Size = new System.Drawing.Size(140, 62);
            this.btn_trolai.TabIndex = 2;
            this.btn_trolai.Text = "Tro lai";
            this.btn_trolai.UseVisualStyleBackColor = true;
            this.btn_trolai.Click += new System.EventHandler(this.btn_trolai_Click);
            // 
            // btn_don
            // 
            this.btn_don.Location = new System.Drawing.Point(839, 265);
            this.btn_don.Name = "btn_don";
            this.btn_don.Size = new System.Drawing.Size(183, 49);
            this.btn_don.TabIndex = 30;
            this.btn_don.Text = "DỌN";
            this.btn_don.UseVisualStyleBackColor = true;
            this.btn_don.Click += new System.EventHandler(this.btn_don_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(357, 96);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(477, 22);
            this.txt_timkiem.TabIndex = 29;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(839, 180);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(183, 49);
            this.btn_xoa.TabIndex = 28;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(604, 268);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(183, 49);
            this.btn_sua.TabIndex = 27;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(604, 180);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(183, 49);
            this.btn_them.TabIndex = 26;
            this.btn_them.Text = "THÊM";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dgv_calam
            // 
            this.dgv_calam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_calam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_calam.Location = new System.Drawing.Point(54, 376);
            this.dgv_calam.Name = "dgv_calam";
            this.dgv_calam.RowHeadersWidth = 51;
            this.dgv_calam.RowTemplate.Height = 24;
            this.dgv_calam.Size = new System.Drawing.Size(979, 204);
            this.dgv_calam.TabIndex = 25;
            this.dgv_calam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_calam_CellClick);
            this.dgv_calam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_calam_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(382, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 33);
            this.label5.TabIndex = 24;
            this.label5.Text = "THÔNG TIN CA LÀM";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_tencalam
            // 
            this.txt_tencalam.Location = new System.Drawing.Point(229, 207);
            this.txt_tencalam.Name = "txt_tencalam";
            this.txt_tencalam.Size = new System.Drawing.Size(282, 22);
            this.txt_tencalam.TabIndex = 23;
            this.txt_tencalam.TextChanged += new System.EventHandler(this.txt_tencalam_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Giờ kết thúc:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Giờ bắt đầu:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên ca làm:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_macalam
            // 
            this.txt_macalam.Enabled = false;
            this.txt_macalam.Location = new System.Drawing.Point(229, 166);
            this.txt_macalam.Name = "txt_macalam";
            this.txt_macalam.Size = new System.Drawing.Size(282, 22);
            this.txt_macalam.TabIndex = 17;
            this.txt_macalam.TextChanged += new System.EventHandler(this.txt_macalam_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mã ca làm:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // time_batDau
            // 
            this.time_batDau.Location = new System.Drawing.Point(229, 251);
            this.time_batDau.Name = "time_batDau";
            this.time_batDau.Size = new System.Drawing.Size(282, 22);
            this.time_batDau.TabIndex = 31;
            this.time_batDau.ValueChanged += new System.EventHandler(this.time_batDau_ValueChanged);
            // 
            // time_KetThuc
            // 
            this.time_KetThuc.Location = new System.Drawing.Point(229, 296);
            this.time_KetThuc.Name = "time_KetThuc";
            this.time_KetThuc.Size = new System.Drawing.Size(282, 22);
            this.time_KetThuc.TabIndex = 32;
            this.time_KetThuc.ValueChanged += new System.EventHandler(this.time_KetThuc_ValueChanged);
            // 
            // thongtincalam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.time_KetThuc);
            this.Controls.Add(this.time_batDau);
            this.Controls.Add(this.btn_don);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_calam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tencalam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_macalam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_trolai);
            this.Name = "thongtincalam";
            this.Size = new System.Drawing.Size(1829, 890);
            this.Load += new System.EventHandler(this.thongtincalam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_calam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_trolai;
        private System.Windows.Forms.Button btn_don;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgv_calam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tencalam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_macalam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker time_batDau;
        private System.Windows.Forms.DateTimePicker time_KetThuc;
    }
}
