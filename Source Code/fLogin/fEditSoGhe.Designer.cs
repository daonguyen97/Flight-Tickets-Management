namespace fLogin
{
    partial class fEditSoGhe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dadat2 = new System.Windows.Forms.Label();
            this.dadat1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hang2 = new System.Windows.Forms.TextBox();
            this.hang1 = new System.Windows.Forms.TextBox();
            this.accept = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dadat2);
            this.groupBox1.Controls.Add(this.dadat1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.hang2);
            this.groupBox1.Controls.Add(this.hang1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Số lượng ghế";
            // 
            // dadat2
            // 
            this.dadat2.AutoSize = true;
            this.dadat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dadat2.Location = new System.Drawing.Point(240, 74);
            this.dadat2.Name = "dadat2";
            this.dadat2.Size = new System.Drawing.Size(69, 20);
            this.dadat2.TabIndex = 5;
            this.dadat2.Text = "Hạng 2";
            // 
            // dadat1
            // 
            this.dadat1.AutoSize = true;
            this.dadat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dadat1.Location = new System.Drawing.Point(240, 33);
            this.dadat1.Name = "dadat1";
            this.dadat1.Size = new System.Drawing.Size(69, 20);
            this.dadat1.TabIndex = 4;
            this.dadat1.Text = "Hạng 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hạng 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hạng 1";
            // 
            // hang2
            // 
            this.hang2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hang2.Location = new System.Drawing.Point(100, 71);
            this.hang2.Name = "hang2";
            this.hang2.Size = new System.Drawing.Size(64, 27);
            this.hang2.TabIndex = 1;
            // 
            // hang1
            // 
            this.hang1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hang1.Location = new System.Drawing.Point(100, 30);
            this.hang1.Name = "hang1";
            this.hang1.Size = new System.Drawing.Size(64, 27);
            this.hang1.TabIndex = 0;
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(100, 135);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(86, 27);
            this.accept.TabIndex = 4;
            this.accept.Text = "Lưu";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(208, 135);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(86, 27);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Hủy";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // fEditSoGhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 174);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.groupBox1);
            this.Name = "fEditSoGhe";
            this.Text = "Chuyến bay: ";
            this.Load += new System.EventHandler(this.fEditSoGhe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hang2;
        private System.Windows.Forms.TextBox hang1;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label dadat2;
        private System.Windows.Forms.Label dadat1;
    }
}