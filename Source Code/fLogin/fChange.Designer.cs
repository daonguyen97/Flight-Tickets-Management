namespace fLogin
{
    partial class fChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChange));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sanbaybtnremove = new System.Windows.Forms.Button();
            this.sanbaybtnadd = new System.Windows.Forms.Button();
            this.textBoxtensanbay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewSanBay = new System.Windows.Forms.DataGridView();
            this.TenSanBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.thoigiandungmax = new System.Windows.Forms.TextBox();
            this.thoigiandungmin = new System.Windows.Forms.TextBox();
            this.sanbaytrunggianmax = new System.Windows.Forms.TextBox();
            this.thoigianbaymin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.savebutton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.day2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.day1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.setdefaultbutton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanBay)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(256, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "THAY ĐỔI QUI ĐỊNH";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.sanbaybtnremove);
            this.groupBox1.Controls.Add(this.sanbaybtnadd);
            this.groupBox1.Controls.Add(this.textBoxtensanbay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridViewSanBay);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 357);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sân bay";
            // 
            // sanbaybtnremove
            // 
            this.sanbaybtnremove.Location = new System.Drawing.Point(125, 328);
            this.sanbaybtnremove.Name = "sanbaybtnremove";
            this.sanbaybtnremove.Size = new System.Drawing.Size(110, 23);
            this.sanbaybtnremove.TabIndex = 6;
            this.sanbaybtnremove.Text = "Xóa";
            this.sanbaybtnremove.UseVisualStyleBackColor = true;
            this.sanbaybtnremove.Click += new System.EventHandler(this.sanbaybtnremove_Click);
            // 
            // sanbaybtnadd
            // 
            this.sanbaybtnadd.Location = new System.Drawing.Point(9, 328);
            this.sanbaybtnadd.Name = "sanbaybtnadd";
            this.sanbaybtnadd.Size = new System.Drawing.Size(110, 23);
            this.sanbaybtnadd.TabIndex = 5;
            this.sanbaybtnadd.Text = "Thêm";
            this.sanbaybtnadd.UseVisualStyleBackColor = true;
            this.sanbaybtnadd.Click += new System.EventHandler(this.sanbaybtnadd_Click);
            // 
            // textBoxtensanbay
            // 
            this.textBoxtensanbay.Location = new System.Drawing.Point(112, 280);
            this.textBoxtensanbay.Name = "textBoxtensanbay";
            this.textBoxtensanbay.Size = new System.Drawing.Size(124, 22);
            this.textBoxtensanbay.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sân bay:";
            // 
            // dataGridViewSanBay
            // 
            this.dataGridViewSanBay.AllowUserToAddRows = false;
            this.dataGridViewSanBay.AllowUserToDeleteRows = false;
            this.dataGridViewSanBay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSanBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSanBay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSanBay});
            this.dataGridViewSanBay.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewSanBay.Name = "dataGridViewSanBay";
            this.dataGridViewSanBay.ReadOnly = true;
            this.dataGridViewSanBay.RowTemplate.Height = 24;
            this.dataGridViewSanBay.Size = new System.Drawing.Size(230, 220);
            this.dataGridViewSanBay.TabIndex = 0;
            this.dataGridViewSanBay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSanBay_CellContentClick);
            this.dataGridViewSanBay.SelectionChanged += new System.EventHandler(this.dataGridViewSanBay_SelectionChanged);
            // 
            // TenSanBay
            // 
            this.TenSanBay.HeaderText = "Tên San Bay";
            this.TenSanBay.Name = "TenSanBay";
            this.TenSanBay.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.thoigiandungmax);
            this.groupBox2.Controls.Add(this.thoigiandungmin);
            this.groupBox2.Controls.Add(this.sanbaytrunggianmax);
            this.groupBox2.Controls.Add(this.thoigianbaymin);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(261, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 357);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thời gian bay/Sân bay trung gian";
            // 
            // thoigiandungmax
            // 
            this.thoigiandungmax.Location = new System.Drawing.Point(201, 165);
            this.thoigiandungmax.Name = "thoigiandungmax";
            this.thoigiandungmax.Size = new System.Drawing.Size(119, 22);
            this.thoigiandungmax.TabIndex = 7;
            // 
            // thoigiandungmin
            // 
            this.thoigiandungmin.Location = new System.Drawing.Point(201, 116);
            this.thoigiandungmin.Name = "thoigiandungmin";
            this.thoigiandungmin.Size = new System.Drawing.Size(119, 22);
            this.thoigiandungmin.TabIndex = 6;
            // 
            // sanbaytrunggianmax
            // 
            this.sanbaytrunggianmax.Location = new System.Drawing.Point(201, 72);
            this.sanbaytrunggianmax.Name = "sanbaytrunggianmax";
            this.sanbaytrunggianmax.Size = new System.Drawing.Size(119, 22);
            this.sanbaytrunggianmax.TabIndex = 5;
            // 
            // thoigianbaymin
            // 
            this.thoigianbaymin.Location = new System.Drawing.Point(201, 30);
            this.thoigianbaymin.Name = "thoigianbaymin";
            this.thoigianbaymin.Size = new System.Drawing.Size(119, 22);
            this.thoigianbaymin.TabIndex = 4;
            this.thoigianbaymin.TextChanged += new System.EventHandler(this.thoigianbaymin_TextChanged);
            this.thoigianbaymin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.thoigianbaymin_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Thời gian dừng tối đa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Thời gian dừng tối thiểu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số sân bay trung gian tối đa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "TG Bay tối thiểu:";
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(153, 433);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(140, 32);
            this.savebutton.TabIndex = 8;
            this.savebutton.Text = "Lưu";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.day2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.day1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(599, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 357);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đặt vé";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(122, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "ngày";
            // 
            // day2
            // 
            this.day2.Location = new System.Drawing.Point(88, 75);
            this.day2.Name = "day2";
            this.day2.Size = new System.Drawing.Size(28, 22);
            this.day2.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Hủy đặt vé";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "ngày";
            // 
            // day1
            // 
            this.day1.Location = new System.Drawing.Point(88, 30);
            this.day1.Name = "day1";
            this.day1.Size = new System.Drawing.Size(28, 22);
            this.day1.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Chậm nhất";
            // 
            // setdefaultbutton
            // 
            this.setdefaultbutton.Location = new System.Drawing.Point(317, 433);
            this.setdefaultbutton.Name = "setdefaultbutton";
            this.setdefaultbutton.Size = new System.Drawing.Size(140, 32);
            this.setdefaultbutton.TabIndex = 10;
            this.setdefaultbutton.Text = "Mặc định";
            this.setdefaultbutton.UseVisualStyleBackColor = true;
            this.setdefaultbutton.Click += new System.EventHandler(this.setdefaultbutton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(485, 433);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 32);
            this.button3.TabIndex = 10;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(779, 477);
            this.Controls.Add(this.setdefaultbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fChange";
            this.Text = "QUI ĐỊNH";
            this.Load += new System.EventHandler(this.fChange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanBay)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewSanBay;
        private System.Windows.Forms.Button sanbaybtnremove;
        private System.Windows.Forms.Button sanbaybtnadd;
        private System.Windows.Forms.TextBox textBoxtensanbay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.TextBox thoigiandungmax;
        private System.Windows.Forms.TextBox thoigiandungmin;
        private System.Windows.Forms.TextBox sanbaytrunggianmax;
        private System.Windows.Forms.TextBox thoigianbaymin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button setdefaultbutton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox day2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox day1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanBay;
    }
}