namespace STTBillard
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_in = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_next = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 243);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 86);
            this.label2.TabIndex = 4;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số Thứ Tự Của Quý Khách";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 67);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quý khách vui lòng đợi đến số thứ tự này!";
            // 
            // bt_in
            // 
            this.bt_in.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_in.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_in.Location = new System.Drawing.Point(14, 276);
            this.bt_in.Name = "bt_in";
            this.bt_in.Size = new System.Drawing.Size(287, 48);
            this.bt_in.TabIndex = 1;
            this.bt_in.Text = "IN SỐ THỨ TỰ TIẾP THEO";
            this.bt_in.UseVisualStyleBackColor = true;
            this.bt_in.Click += new System.EventHandler(this.bt_in_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_reset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reset.Location = new System.Drawing.Point(12, 330);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(96, 35);
            this.bt_reset.TabIndex = 2;
            this.bt_reset.Text = "RESET";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // bt_next
            // 
            this.bt_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_next.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_next.Location = new System.Drawing.Point(114, 330);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(187, 35);
            this.bt_next.TabIndex = 3;
            this.bt_next.Text = "SỐ TIẾP THEO";
            this.bt_next.UseVisualStyleBackColor = true;
            this.bt_next.Click += new System.EventHandler(this.bt_next_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "a";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "a";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(313, 384);
            this.Controls.Add(this.bt_next);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.bt_in);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_in;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_next;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

