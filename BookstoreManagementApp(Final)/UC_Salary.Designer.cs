namespace BookstoreManagementApp_Final_
{
    partial class UC_Salary
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
            this.pn_slr = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_slr = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.bt_slr_xem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbb_slr_y = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_slr_m = new System.Windows.Forms.ComboBox();
            this.tb_slr_tl = new System.Windows.Forms.TextBox();
            this.tb_slr_allowence = new System.Windows.Forms.TextBox();
            this.tb_slr_basicrate = new System.Windows.Forms.TextBox();
            this.tb_slr_payrate = new System.Windows.Forms.TextBox();
            this.tb_slr_id = new System.Windows.Forms.TextBox();
            this.tb_slr_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pn_slr.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_slr)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_slr
            // 
            this.pn_slr.Controls.Add(this.textBox1);
            this.pn_slr.Controls.Add(this.groupBox1);
            this.pn_slr.Controls.Add(this.label4);
            this.pn_slr.Controls.Add(this.label3);
            this.pn_slr.Controls.Add(this.label18);
            this.pn_slr.Controls.Add(this.label16);
            this.pn_slr.Controls.Add(this.bt_slr_xem);
            this.pn_slr.Controls.Add(this.label9);
            this.pn_slr.Controls.Add(this.cbb_slr_y);
            this.pn_slr.Controls.Add(this.label8);
            this.pn_slr.Controls.Add(this.cbb_slr_m);
            this.pn_slr.Controls.Add(this.tb_slr_tl);
            this.pn_slr.Controls.Add(this.tb_slr_allowence);
            this.pn_slr.Controls.Add(this.tb_slr_basicrate);
            this.pn_slr.Controls.Add(this.tb_slr_payrate);
            this.pn_slr.Controls.Add(this.tb_slr_id);
            this.pn_slr.Controls.Add(this.tb_slr_name);
            this.pn_slr.Controls.Add(this.label7);
            this.pn_slr.Controls.Add(this.label2);
            this.pn_slr.Controls.Add(this.label1);
            this.pn_slr.Location = new System.Drawing.Point(2, 2);
            this.pn_slr.Margin = new System.Windows.Forms.Padding(2);
            this.pn_slr.Name = "pn_slr";
            this.pn_slr.Size = new System.Drawing.Size(987, 646);
            this.pn_slr.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_slr);
            this.groupBox1.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(2, 334);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(982, 308);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BẢNG LƯƠNG NHÂN VIÊN";
            // 
            // dgv_slr
            // 
            this.dgv_slr.AllowUserToAddRows = false;
            this.dgv_slr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_slr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_slr.Location = new System.Drawing.Point(2, 26);
            this.dgv_slr.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_slr.Name = "dgv_slr";
            this.dgv_slr.ReadOnly = true;
            this.dgv_slr.RowTemplate.Height = 24;
            this.dgv_slr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_slr.Size = new System.Drawing.Size(983, 300);
            this.dgv_slr.TabIndex = 21;
            this.dgv_slr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_slr_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(540, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 43;
            this.label4.Text = "Phụ cấp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(540, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "Lương cơ bản:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(95, 195);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 21);
            this.label18.TabIndex = 35;
            this.label18.Text = "Bậc lương:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(95, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 21);
            this.label16.TabIndex = 33;
            this.label16.Text = "Mã nhân viên:";
            // 
            // bt_slr_xem
            // 
            this.bt_slr_xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.bt_slr_xem.Location = new System.Drawing.Point(446, 266);
            this.bt_slr_xem.Margin = new System.Windows.Forms.Padding(2);
            this.bt_slr_xem.Name = "bt_slr_xem";
            this.bt_slr_xem.Size = new System.Drawing.Size(53, 26);
            this.bt_slr_xem.TabIndex = 22;
            this.bt_slr_xem.Text = "Xem";
            this.bt_slr_xem.UseVisualStyleBackColor = true;
            this.bt_slr_xem.Click += new System.EventHandler(this.bt_slr_xem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(279, 266);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "Năm";
            // 
            // cbb_slr_y
            // 
            this.cbb_slr_y.FormattingEnabled = true;
            this.cbb_slr_y.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021"});
            this.cbb_slr_y.Location = new System.Drawing.Point(328, 267);
            this.cbb_slr_y.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_slr_y.Name = "cbb_slr_y";
            this.cbb_slr_y.Size = new System.Drawing.Size(92, 21);
            this.cbb_slr_y.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(95, 266);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tháng";
            // 
            // cbb_slr_m
            // 
            this.cbb_slr_m.FormattingEnabled = true;
            this.cbb_slr_m.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbb_slr_m.Location = new System.Drawing.Point(153, 267);
            this.cbb_slr_m.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_slr_m.Name = "cbb_slr_m";
            this.cbb_slr_m.Size = new System.Drawing.Size(92, 21);
            this.cbb_slr_m.TabIndex = 18;
            // 
            // tb_slr_tl
            // 
            this.tb_slr_tl.Location = new System.Drawing.Point(684, 195);
            this.tb_slr_tl.Margin = new System.Windows.Forms.Padding(2);
            this.tb_slr_tl.Name = "tb_slr_tl";
            this.tb_slr_tl.ReadOnly = true;
            this.tb_slr_tl.Size = new System.Drawing.Size(150, 20);
            this.tb_slr_tl.TabIndex = 13;
            // 
            // tb_slr_allowence
            // 
            this.tb_slr_allowence.Location = new System.Drawing.Point(684, 149);
            this.tb_slr_allowence.Margin = new System.Windows.Forms.Padding(2);
            this.tb_slr_allowence.Name = "tb_slr_allowence";
            this.tb_slr_allowence.ReadOnly = true;
            this.tb_slr_allowence.Size = new System.Drawing.Size(150, 20);
            this.tb_slr_allowence.TabIndex = 12;
            // 
            // tb_slr_basicrate
            // 
            this.tb_slr_basicrate.Location = new System.Drawing.Point(684, 100);
            this.tb_slr_basicrate.Margin = new System.Windows.Forms.Padding(2);
            this.tb_slr_basicrate.Name = "tb_slr_basicrate";
            this.tb_slr_basicrate.ReadOnly = true;
            this.tb_slr_basicrate.Size = new System.Drawing.Size(150, 20);
            this.tb_slr_basicrate.TabIndex = 11;
            // 
            // tb_slr_payrate
            // 
            this.tb_slr_payrate.Location = new System.Drawing.Point(270, 195);
            this.tb_slr_payrate.Margin = new System.Windows.Forms.Padding(2);
            this.tb_slr_payrate.Name = "tb_slr_payrate";
            this.tb_slr_payrate.ReadOnly = true;
            this.tb_slr_payrate.Size = new System.Drawing.Size(150, 20);
            this.tb_slr_payrate.TabIndex = 10;
            // 
            // tb_slr_id
            // 
            this.tb_slr_id.Location = new System.Drawing.Point(270, 101);
            this.tb_slr_id.Margin = new System.Windows.Forms.Padding(2);
            this.tb_slr_id.Name = "tb_slr_id";
            this.tb_slr_id.ReadOnly = true;
            this.tb_slr_id.Size = new System.Drawing.Size(150, 20);
            this.tb_slr_id.TabIndex = 9;
            // 
            // tb_slr_name
            // 
            this.tb_slr_name.Location = new System.Drawing.Point(270, 147);
            this.tb_slr_name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_slr_name.Name = "tb_slr_name";
            this.tb_slr_name.ReadOnly = true;
            this.tb_slr_name.Size = new System.Drawing.Size(150, 20);
            this.tb_slr_name.TabIndex = 8;
            //this.tb_slr_name.Leave += new System.EventHandler(this.tb_slr_name_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(540, 195);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tổng lương:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Avo", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(95, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Avo", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(335, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ LƯƠNG";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(586, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 20);
            this.textBox1.TabIndex = 45;
            // 
            // UC_Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_slr);
            this.Name = "UC_Salary";
            this.Size = new System.Drawing.Size(991, 647);
            this.Load += new System.EventHandler(this.UC_Salary_Load);
            this.pn_slr.ResumeLayout(false);
            this.pn_slr.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_slr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_slr;
        private System.Windows.Forms.Button bt_slr_xem;
        private System.Windows.Forms.DataGridView dgv_slr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbb_slr_y;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbb_slr_m;
        private System.Windows.Forms.TextBox tb_slr_tl;
        private System.Windows.Forms.TextBox tb_slr_allowence;
        private System.Windows.Forms.TextBox tb_slr_basicrate;
        private System.Windows.Forms.TextBox tb_slr_payrate;
        private System.Windows.Forms.TextBox tb_slr_id;
        private System.Windows.Forms.TextBox tb_slr_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
