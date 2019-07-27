namespace fLogin
{
    partial class fTimChuyenBay
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
            this.label1 = new System.Windows.Forms.Label();
            this.sanbaydi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sanbayden = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.btnfind = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đi:";
            // 
            // sanbaydi
            // 
            this.sanbaydi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sanbaydi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sanbaydi.FormattingEnabled = true;
            this.sanbaydi.Location = new System.Drawing.Point(71, 24);
            this.sanbaydi.Name = "sanbaydi";
            this.sanbaydi.Size = new System.Drawing.Size(128, 28);
            this.sanbaydi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "- Đến:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày:";
            // 
            // sanbayden
            // 
            this.sanbayden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sanbayden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sanbayden.FormattingEnabled = true;
            this.sanbayden.Location = new System.Drawing.Point(282, 24);
            this.sanbayden.Name = "sanbayden";
            this.sanbayden.Size = new System.Drawing.Size(128, 28);
            this.sanbayden.TabIndex = 5;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(71, 58);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(128, 27);
            this.date.TabIndex = 6;
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(285, 114);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(128, 31);
            this.btnfind.TabIndex = 7;
            this.btnfind.Text = "Tìm";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sanbaydi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.sanbayden);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 105);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // fTimChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 157);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnfind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fTimChuyenBay";
            this.Text = "Tìm chuyến bay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTimChuyenBay_FormClosing);
            this.Load += new System.EventHandler(this.fTimChuyenBay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sanbaydi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sanbayden;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}