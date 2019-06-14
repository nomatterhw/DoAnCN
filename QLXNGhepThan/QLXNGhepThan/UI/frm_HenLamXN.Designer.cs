namespace QLXNGhepThan.UI
{
    partial class frm_HenLamXN
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lbResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbNgayXN = new System.Windows.Forms.Label();
            this.btHenKham = new System.Windows.Forms.Button();
            this.lbTenXN = new System.Windows.Forms.Label();
            this.lbTenBN = new System.Windows.Forms.Label();
            this.metroPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lbResult);
            this.metroPanel1.Controls.Add(this.groupBox1);
            this.metroPanel1.Controls.Add(this.btHenKham);
            this.metroPanel1.Controls.Add(this.lbTenXN);
            this.metroPanel1.Controls.Add(this.lbTenBN);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(273, 401);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(112, 375);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(35, 13);
            this.lbResult.TabIndex = 8;
            this.lbResult.Text = "label1";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.lbNgayXN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 226);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn ngày xét nghiệm";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 27);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lbNgayXN
            // 
            this.lbNgayXN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNgayXN.AutoSize = true;
            this.lbNgayXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayXN.Location = new System.Drawing.Point(97, 198);
            this.lbNgayXN.Name = "lbNgayXN";
            this.lbNgayXN.Size = new System.Drawing.Size(51, 16);
            this.lbNgayXN.TabIndex = 4;
            this.lbNgayXN.Text = "label2";
            // 
            // btHenKham
            // 
            this.btHenKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHenKham.Location = new System.Drawing.Point(12, 314);
            this.btHenKham.Name = "btHenKham";
            this.btHenKham.Size = new System.Drawing.Size(247, 54);
            this.btHenKham.TabIndex = 6;
            this.btHenKham.Text = "Đặt lịch hẹn";
            this.btHenKham.UseVisualStyleBackColor = true;
            this.btHenKham.Click += new System.EventHandler(this.btHenKham_Click);
            // 
            // lbTenXN
            // 
            this.lbTenXN.AutoSize = true;
            this.lbTenXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenXN.ForeColor = System.Drawing.Color.Red;
            this.lbTenXN.Location = new System.Drawing.Point(12, 42);
            this.lbTenXN.Name = "lbTenXN";
            this.lbTenXN.Size = new System.Drawing.Size(57, 20);
            this.lbTenXN.TabIndex = 5;
            this.lbTenXN.Text = "label3";
            // 
            // lbTenBN
            // 
            this.lbTenBN.AutoSize = true;
            this.lbTenBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenBN.ForeColor = System.Drawing.Color.Blue;
            this.lbTenBN.Location = new System.Drawing.Point(12, 9);
            this.lbTenBN.Name = "lbTenBN";
            this.lbTenBN.Size = new System.Drawing.Size(57, 20);
            this.lbTenBN.TabIndex = 2;
            this.lbTenBN.Text = "label1";
            // 
            // frm_HenLamXN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 401);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frm_HenLamXN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_HenLamXN";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Button btHenKham;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lbTenXN;
        private System.Windows.Forms.Label lbNgayXN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbTenBN;
    }
}