namespace BookstoreManagementApp_Final_
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.lb_mng_id = new System.Windows.Forms.Label();
            this.lb_mng_fn = new System.Windows.Forms.Label();
            this.pn_main = new System.Windows.Forms.Panel();
            this.bt_csvc = new System.Windows.Forms.Button();
            this.bt_luong = new System.Windows.Forms.Button();
            this.bt_nv = new System.Windows.Forms.Button();
            this.bt_logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_tk = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_mng_id
            // 
            this.lb_mng_id.AutoSize = true;
            this.lb_mng_id.BackColor = System.Drawing.Color.SteelBlue;
            this.lb_mng_id.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mng_id.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_mng_id.Location = new System.Drawing.Point(73, 28);
            this.lb_mng_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_mng_id.Name = "lb_mng_id";
            this.lb_mng_id.Size = new System.Drawing.Size(59, 17);
            this.lb_mng_id.TabIndex = 17;
            this.lb_mng_id.Text = "                 ";
            // 
            // lb_mng_fn
            // 
            this.lb_mng_fn.AutoSize = true;
            this.lb_mng_fn.BackColor = System.Drawing.Color.SteelBlue;
            this.lb_mng_fn.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mng_fn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_mng_fn.Location = new System.Drawing.Point(73, 54);
            this.lb_mng_fn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_mng_fn.Name = "lb_mng_fn";
            this.lb_mng_fn.Size = new System.Drawing.Size(59, 17);
            this.lb_mng_fn.TabIndex = 18;
            this.lb_mng_fn.Text = "                 ";
            // 
            // pn_main
            // 
            this.pn_main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pn_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_main.Location = new System.Drawing.Point(185, 124);
            this.pn_main.Margin = new System.Windows.Forms.Padding(2);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(992, 648);
            this.pn_main.TabIndex = 12;
            // 
            // bt_csvc
            // 
            this.bt_csvc.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_csvc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_csvc.FlatAppearance.BorderSize = 0;
            this.bt_csvc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_csvc.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_csvc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_csvc.Location = new System.Drawing.Point(0, 301);
            this.bt_csvc.Margin = new System.Windows.Forms.Padding(2);
            this.bt_csvc.Name = "bt_csvc";
            this.bt_csvc.Size = new System.Drawing.Size(185, 49);
            this.bt_csvc.TabIndex = 3;
            this.bt_csvc.Text = " CƠ SỞ VẬT CHẤT";
            this.bt_csvc.UseVisualStyleBackColor = false;
            this.bt_csvc.Click += new System.EventHandler(this.bt_csvc_Click);
            this.bt_csvc.MouseEnter += new System.EventHandler(this.bt_csvc_MouseEnter);
            this.bt_csvc.MouseLeave += new System.EventHandler(this.bt_csvc_MouseLeave);
            // 
            // bt_luong
            // 
            this.bt_luong.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_luong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_luong.FlatAppearance.BorderSize = 0;
            this.bt_luong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_luong.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.bt_luong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_luong.Location = new System.Drawing.Point(0, 204);
            this.bt_luong.Margin = new System.Windows.Forms.Padding(2);
            this.bt_luong.Name = "bt_luong";
            this.bt_luong.Size = new System.Drawing.Size(185, 49);
            this.bt_luong.TabIndex = 2;
            this.bt_luong.Text = "LƯƠNG                 ";
            this.bt_luong.UseVisualStyleBackColor = false;
            this.bt_luong.Click += new System.EventHandler(this.bt_luong_Click);
            this.bt_luong.MouseEnter += new System.EventHandler(this.bt_luong_MouseEnter);
            this.bt_luong.MouseLeave += new System.EventHandler(this.bt_luong_MouseLeave);
            // 
            // bt_nv
            // 
            this.bt_nv.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_nv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_nv.FlatAppearance.BorderSize = 0;
            this.bt_nv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_nv.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.bt_nv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_nv.Location = new System.Drawing.Point(0, 155);
            this.bt_nv.Margin = new System.Windows.Forms.Padding(2);
            this.bt_nv.Name = "bt_nv";
            this.bt_nv.Size = new System.Drawing.Size(185, 49);
            this.bt_nv.TabIndex = 1;
            this.bt_nv.Text = "NHÂN VIÊN         ";
            this.bt_nv.UseVisualStyleBackColor = false;
            this.bt_nv.Click += new System.EventHandler(this.bt_nv_Click);
            this.bt_nv.MouseEnter += new System.EventHandler(this.bt_nv_MouseEnter);
            this.bt_nv.MouseLeave += new System.EventHandler(this.bt_nv_MouseLeave);
            // 
            // bt_logout
            // 
            this.bt_logout.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_logout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_logout.Location = new System.Drawing.Point(2, 92);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(163, 37);
            this.bt_logout.TabIndex = 19;
            this.bt_logout.Text = "ĐĂNG XUẤT";
            this.bt_logout.UseVisualStyleBackColor = false;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.bt_tk);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bt_csvc);
            this.panel1.Controls.Add(this.bt_luong);
            this.panel1.Controls.Add(this.bt_nv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 773);
            this.panel1.TabIndex = 0;
            // 
            // bt_tk
            // 
            this.bt_tk.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_tk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_tk.FlatAppearance.BorderSize = 0;
            this.bt_tk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_tk.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.bt_tk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_tk.Location = new System.Drawing.Point(0, 253);
            this.bt_tk.Margin = new System.Windows.Forms.Padding(2);
            this.bt_tk.Name = "bt_tk";
            this.bt_tk.Size = new System.Drawing.Size(185, 49);
            this.bt_tk.TabIndex = 5;
            this.bt_tk.Text = "TÀI KHOẢN          ";
            this.bt_tk.UseVisualStyleBackColor = false;
            this.bt_tk.Click += new System.EventHandler(this.bt_tk_Click);
            this.bt_tk.MouseEnter += new System.EventHandler(this.bt_tk_MouseEnter);
            this.bt_tk.MouseLeave += new System.EventHandler(this.bt_tk_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bt_logout);
            this.panel2.Controls.Add(this.lb_mng_fn);
            this.panel2.Controls.Add(this.lb_mng_id);
            this.panel2.Location = new System.Drawing.Point(9, 597);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 132);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Avo", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Avo", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã NV";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.logolastttt;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(29, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 106);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(185, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(994, 120);
            this.panel3.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Avo", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 28);
            this.label3.TabIndex = 0;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 773);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pn_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerForm_FormClosing);
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_nv;
        private System.Windows.Forms.Button bt_luong;
        private System.Windows.Forms.Button bt_csvc;
        private System.Windows.Forms.Button bt_tk;
        private System.Windows.Forms.Label lb_mng_id;
        private System.Windows.Forms.Label lb_mng_fn;
        private System.Windows.Forms.Panel pn_main;
        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}