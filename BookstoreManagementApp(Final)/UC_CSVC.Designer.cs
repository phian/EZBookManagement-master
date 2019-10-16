namespace BookstoreManagementApp_Final_
{
    partial class UC_CSVC
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
            this.pn_csvc = new System.Windows.Forms.Panel();
            this.tb_csvc_sl = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_csvc = new System.Windows.Forms.DataGridView();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.dtp_csvc = new System.Windows.Forms.DateTimePicker();
            this.tb_csvc_name = new System.Windows.Forms.TextBox();
            this.tb_csvc_id = new System.Windows.Forms.TextBox();
            this.bt_csvc_es = new System.Windows.Forms.Button();
            this.bt_csvc_as = new System.Windows.Forms.Button();
            this.bt_csvc_del = new System.Windows.Forms.Button();
            this.bt_csvc_edit = new System.Windows.Forms.Button();
            this.bt_csvc_add = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pn_csvc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_csvc_sl)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_csvc)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_csvc
            // 
            this.pn_csvc.Controls.Add(this.tb_csvc_sl);
            this.pn_csvc.Controls.Add(this.groupBox1);
            this.pn_csvc.Controls.Add(this.bt_cancel);
            this.pn_csvc.Controls.Add(this.dtp_csvc);
            this.pn_csvc.Controls.Add(this.tb_csvc_name);
            this.pn_csvc.Controls.Add(this.tb_csvc_id);
            this.pn_csvc.Controls.Add(this.bt_csvc_es);
            this.pn_csvc.Controls.Add(this.bt_csvc_as);
            this.pn_csvc.Controls.Add(this.bt_csvc_del);
            this.pn_csvc.Controls.Add(this.bt_csvc_edit);
            this.pn_csvc.Controls.Add(this.bt_csvc_add);
            this.pn_csvc.Controls.Add(this.label14);
            this.pn_csvc.Controls.Add(this.label13);
            this.pn_csvc.Controls.Add(this.label12);
            this.pn_csvc.Controls.Add(this.label11);
            this.pn_csvc.Controls.Add(this.label10);
            this.pn_csvc.Location = new System.Drawing.Point(2, 2);
            this.pn_csvc.Margin = new System.Windows.Forms.Padding(2);
            this.pn_csvc.Name = "pn_csvc";
            this.pn_csvc.Size = new System.Drawing.Size(987, 646);
            this.pn_csvc.TabIndex = 20;
            // 
            // tb_csvc_sl
            // 
            this.tb_csvc_sl.Location = new System.Drawing.Point(638, 175);
            this.tb_csvc_sl.Name = "tb_csvc_sl";
            this.tb_csvc_sl.Size = new System.Drawing.Size(120, 20);
            this.tb_csvc_sl.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_csvc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(27, 308);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(932, 332);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH CƠ SỞ VẬT CHẤT";
            // 
            // dgv_csvc
            // 
            this.dgv_csvc.AllowUserToAddRows = false;
            this.dgv_csvc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_csvc.Location = new System.Drawing.Point(4, 17);
            this.dgv_csvc.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_csvc.Name = "dgv_csvc";
            this.dgv_csvc.ReadOnly = true;
            this.dgv_csvc.RowTemplate.Height = 24;
            this.dgv_csvc.Size = new System.Drawing.Size(923, 300);
            this.dgv_csvc.TabIndex = 1;
            this.dgv_csvc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_csvc_CellClick);
            this.dgv_csvc.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_csvc_RowEnter);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Font = new System.Drawing.Font("UTM Avo", 8F, System.Drawing.FontStyle.Bold);
            this.bt_cancel.Location = new System.Drawing.Point(587, 274);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(70, 27);
            this.bt_cancel.TabIndex = 15;
            this.bt_cancel.Text = "Huỷ";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // dtp_csvc
            // 
            this.dtp_csvc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_csvc.Location = new System.Drawing.Point(638, 121);
            this.dtp_csvc.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_csvc.Name = "dtp_csvc";
            this.dtp_csvc.Size = new System.Drawing.Size(151, 20);
            this.dtp_csvc.TabIndex = 14;
            // 
            // tb_csvc_name
            // 
            this.tb_csvc_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tb_csvc_name.Location = new System.Drawing.Point(263, 175);
            this.tb_csvc_name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_csvc_name.Name = "tb_csvc_name";
            this.tb_csvc_name.Size = new System.Drawing.Size(144, 24);
            this.tb_csvc_name.TabIndex = 12;
            this.tb_csvc_name.Leave += new System.EventHandler(this.tb_csvc_name_Leave);
            // 
            // tb_csvc_id
            // 
            this.tb_csvc_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tb_csvc_id.Location = new System.Drawing.Point(263, 118);
            this.tb_csvc_id.Margin = new System.Windows.Forms.Padding(2);
            this.tb_csvc_id.Name = "tb_csvc_id";
            this.tb_csvc_id.Size = new System.Drawing.Size(144, 24);
            this.tb_csvc_id.TabIndex = 11;
            // 
            // bt_csvc_es
            // 
            this.bt_csvc_es.Font = new System.Drawing.Font("UTM Avo", 8F, System.Drawing.FontStyle.Bold);
            this.bt_csvc_es.Location = new System.Drawing.Point(682, 274);
            this.bt_csvc_es.Margin = new System.Windows.Forms.Padding(2);
            this.bt_csvc_es.Name = "bt_csvc_es";
            this.bt_csvc_es.Size = new System.Drawing.Size(70, 27);
            this.bt_csvc_es.TabIndex = 10;
            this.bt_csvc_es.Text = "Lưu";
            this.bt_csvc_es.UseVisualStyleBackColor = true;
            this.bt_csvc_es.Click += new System.EventHandler(this.bt_csvc_es_Click);
            // 
            // bt_csvc_as
            // 
            this.bt_csvc_as.Font = new System.Drawing.Font("UTM Avo", 8F, System.Drawing.FontStyle.Bold);
            this.bt_csvc_as.Location = new System.Drawing.Point(499, 274);
            this.bt_csvc_as.Margin = new System.Windows.Forms.Padding(2);
            this.bt_csvc_as.Name = "bt_csvc_as";
            this.bt_csvc_as.Size = new System.Drawing.Size(70, 27);
            this.bt_csvc_as.TabIndex = 9;
            this.bt_csvc_as.Text = "Lưu";
            this.bt_csvc_as.UseVisualStyleBackColor = true;
            this.bt_csvc_as.Click += new System.EventHandler(this.bt_csvc_as_Click);
            // 
            // bt_csvc_del
            // 
            this.bt_csvc_del.Font = new System.Drawing.Font("UTM Avo", 8F, System.Drawing.FontStyle.Bold);
            this.bt_csvc_del.Location = new System.Drawing.Point(587, 232);
            this.bt_csvc_del.Margin = new System.Windows.Forms.Padding(2);
            this.bt_csvc_del.Name = "bt_csvc_del";
            this.bt_csvc_del.Size = new System.Drawing.Size(70, 27);
            this.bt_csvc_del.TabIndex = 8;
            this.bt_csvc_del.Text = "Xóa";
            this.bt_csvc_del.UseVisualStyleBackColor = true;
            this.bt_csvc_del.Click += new System.EventHandler(this.bt_csvc_del_Click);
            // 
            // bt_csvc_edit
            // 
            this.bt_csvc_edit.Font = new System.Drawing.Font("UTM Avo", 8F, System.Drawing.FontStyle.Bold);
            this.bt_csvc_edit.Location = new System.Drawing.Point(682, 232);
            this.bt_csvc_edit.Margin = new System.Windows.Forms.Padding(2);
            this.bt_csvc_edit.Name = "bt_csvc_edit";
            this.bt_csvc_edit.Size = new System.Drawing.Size(70, 27);
            this.bt_csvc_edit.TabIndex = 7;
            this.bt_csvc_edit.Text = "Sửa";
            this.bt_csvc_edit.UseVisualStyleBackColor = true;
            this.bt_csvc_edit.Click += new System.EventHandler(this.bt_csvc_edit_Click);
            // 
            // bt_csvc_add
            // 
            this.bt_csvc_add.Font = new System.Drawing.Font("UTM Avo", 8F, System.Drawing.FontStyle.Bold);
            this.bt_csvc_add.Location = new System.Drawing.Point(499, 232);
            this.bt_csvc_add.Margin = new System.Windows.Forms.Padding(2);
            this.bt_csvc_add.Name = "bt_csvc_add";
            this.bt_csvc_add.Size = new System.Drawing.Size(70, 27);
            this.bt_csvc_add.TabIndex = 6;
            this.bt_csvc_add.Text = "Thêm";
            this.bt_csvc_add.UseVisualStyleBackColor = true;
            this.bt_csvc_add.Click += new System.EventHandler(this.bt_csvc_add_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(493, 176);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 21);
            this.label14.TabIndex = 5;
            this.label14.Text = "Số lượng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(493, 116);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 21);
            this.label13.TabIndex = 4;
            this.label13.Text = "Ngày nhập về";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(142, 177);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 21);
            this.label12.TabIndex = 3;
            this.label12.Text = "Tên CSVC";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(142, 116);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 21);
            this.label11.TabIndex = 2;
            this.label11.Text = "Mã CSVC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("UTM Avo", 22F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(284, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(432, 44);
            this.label10.TabIndex = 0;
            this.label10.Text = "QUẢN LÝ CƠ SỞ VẬT CHẤT";
            // 
            // UC_CSVC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_csvc);
            this.Name = "UC_CSVC";
            this.Size = new System.Drawing.Size(991, 647);
            this.Load += new System.EventHandler(this.UC_CSVC_Load);
            this.pn_csvc.ResumeLayout(false);
            this.pn_csvc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_csvc_sl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_csvc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_csvc;
        private System.Windows.Forms.DateTimePicker dtp_csvc;
        private System.Windows.Forms.TextBox tb_csvc_name;
        private System.Windows.Forms.TextBox tb_csvc_id;
        private System.Windows.Forms.Button bt_csvc_es;
        private System.Windows.Forms.Button bt_csvc_as;
        private System.Windows.Forms.Button bt_csvc_del;
        private System.Windows.Forms.Button bt_csvc_edit;
        private System.Windows.Forms.Button bt_csvc_add;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_csvc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown tb_csvc_sl;
    }
}
