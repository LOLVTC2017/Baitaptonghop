﻿namespace Baitap3
{
    partial class TKGD
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGV_gd = new System.Windows.Forms.DataGridView();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_giangvien = new System.Windows.Forms.ComboBox();
            this.lb_tsg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_gd)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGV_gd
            // 
            this.dataGV_gd.AllowUserToAddRows = false;
            this.dataGV_gd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_gd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMH,
            this.TenMH,
            this.TenLop,
            this.SoTiet});
            this.dataGV_gd.Location = new System.Drawing.Point(12, 97);
            this.dataGV_gd.Name = "dataGV_gd";
            this.dataGV_gd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV_gd.Size = new System.Drawing.Size(526, 180);
            this.dataGV_gd.TabIndex = 10;
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMonHoc";
            this.MaMH.HeaderText = "Mã Môn Học";
            this.MaMH.Name = "MaMH";
            // 
            // TenMH
            // 
            this.TenMH.DataPropertyName = "TenMonHoc";
            this.TenMH.HeaderText = "Tên Môn Học";
            this.TenMH.Name = "TenMH";
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Tên Lớp";
            this.TenLop.Name = "TenLop";
            // 
            // SoTiet
            // 
            this.SoTiet.DataPropertyName = "SoTiet";
            this.SoTiet.HeaderText = "Số Tiết";
            this.SoTiet.Name = "SoTiet";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(397, 12);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 9;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "GIẢNG VIÊN";
            // 
            // cb_giangvien
            // 
            this.cb_giangvien.FormattingEnabled = true;
            this.cb_giangvien.Location = new System.Drawing.Point(161, 14);
            this.cb_giangvien.Name = "cb_giangvien";
            this.cb_giangvien.Size = new System.Drawing.Size(176, 21);
            this.cb_giangvien.TabIndex = 7;
            this.cb_giangvien.SelectedIndexChanged += new System.EventHandler(this.cb_giangvien_SelectedIndexChanged);
            // 
            // lb_tsg
            // 
            this.lb_tsg.AutoSize = true;
            this.lb_tsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tsg.Location = new System.Drawing.Point(375, 299);
            this.lb_tsg.Name = "lb_tsg";
            this.lb_tsg.Size = new System.Drawing.Size(15, 16);
            this.lb_tsg.TabIndex = 13;
            this.lb_tsg.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tổng Số Giờ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "THỐNG KÊ GIỜ DẠY";
            // 
            // TKGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 339);
            this.Controls.Add(this.dataGV_gd);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_giangvien);
            this.Controls.Add(this.lb_tsg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "TKGD";
            this.Text = "TKGD";
            this.Load += new System.EventHandler(this.TKGD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_gd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGV_gd;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTiet;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_giangvien;
        private System.Windows.Forms.Label lb_tsg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}