namespace QLXNGhepThan.UI
{
    partial class frm_UpdateXN
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
            this.tbketQua = new System.Windows.Forms.RichTextBox();
            this.lbLoaiXN = new System.Windows.Forms.Label();
            this.lbNgayXN = new System.Windows.Forms.Label();
            this.tbUpdateXN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGhiChu = new System.Windows.Forms.RichTextBox();
            this.cbFail = new System.Windows.Forms.CheckBox();
            this.cbPass = new System.Windows.Forms.CheckBox();
            this.btImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbCheckStatus = new System.Windows.Forms.Label();
            this.lbDoiTenXN = new System.Windows.Forms.Label();
            this.lbSoLanXN = new System.Windows.Forms.Label();
            this.cbXnLai = new System.Windows.Forms.CheckBox();
            this.lbHanXN = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbketQua
            // 
            this.tbketQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbketQua.Location = new System.Drawing.Point(10, 149);
            this.tbketQua.Name = "tbketQua";
            this.tbketQua.Size = new System.Drawing.Size(636, 66);
            this.tbketQua.TabIndex = 17;
            this.tbketQua.Text = "";
            // 
            // lbLoaiXN
            // 
            this.lbLoaiXN.AutoSize = true;
            this.lbLoaiXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiXN.Location = new System.Drawing.Point(5, 22);
            this.lbLoaiXN.Name = "lbLoaiXN";
            this.lbLoaiXN.Size = new System.Drawing.Size(120, 20);
            this.lbLoaiXN.TabIndex = 22;
            this.lbLoaiXN.Text = "Loại xét nghiệm";
            // 
            // lbNgayXN
            // 
            this.lbNgayXN.AutoSize = true;
            this.lbNgayXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayXN.Location = new System.Drawing.Point(5, 53);
            this.lbNgayXN.Name = "lbNgayXN";
            this.lbNgayXN.Size = new System.Drawing.Size(69, 20);
            this.lbNgayXN.TabIndex = 21;
            this.lbNgayXN.Text = "ngay XN";
            // 
            // tbUpdateXN
            // 
            this.tbUpdateXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUpdateXN.Image = global::QLXNGhepThan.Properties.Resources.iconSave;
            this.tbUpdateXN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbUpdateXN.Location = new System.Drawing.Point(9, 349);
            this.tbUpdateXN.Name = "tbUpdateXN";
            this.tbUpdateXN.Size = new System.Drawing.Size(197, 52);
            this.tbUpdateXN.TabIndex = 20;
            this.tbUpdateXN.Text = "Cập nhật xét nghiệm";
            this.tbUpdateXN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tbUpdateXN.UseVisualStyleBackColor = true;
            this.tbUpdateXN.Click += new System.EventHandler(this.tbUpdateXN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ghi chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kết quả";
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGhiChu.Location = new System.Drawing.Point(9, 241);
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(636, 66);
            this.tbGhiChu.TabIndex = 25;
            this.tbGhiChu.Text = "";
            // 
            // cbFail
            // 
            this.cbFail.AutoSize = true;
            this.cbFail.Location = new System.Drawing.Point(570, 126);
            this.cbFail.Name = "cbFail";
            this.cbFail.Size = new System.Drawing.Size(76, 17);
            this.cbFail.TabIndex = 27;
            this.cbFail.Text = "Không đạt";
            this.cbFail.UseVisualStyleBackColor = true;
            this.cbFail.CheckedChanged += new System.EventHandler(this.cbFail_CheckedChanged);
            // 
            // cbPass
            // 
            this.cbPass.AutoSize = true;
            this.cbPass.Location = new System.Drawing.Point(486, 126);
            this.cbPass.Name = "cbPass";
            this.cbPass.Size = new System.Drawing.Size(78, 17);
            this.cbPass.TabIndex = 26;
            this.cbPass.Text = "Thông qua";
            this.cbPass.UseVisualStyleBackColor = true;
            this.cbPass.CheckedChanged += new System.EventHandler(this.cbPass_CheckedChanged);
            // 
            // btImage
            // 
            this.btImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btImage.Image = global::QLXNGhepThan.Properties.Resources.iconOpenFile;
            this.btImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btImage.Location = new System.Drawing.Point(6, 315);
            this.btImage.Name = "btImage";
            this.btImage.Size = new System.Drawing.Size(123, 46);
            this.btImage.TabIndex = 29;
            this.btImage.Text = "Chọn hình";
            this.btImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btImage.UseVisualStyleBackColor = true;
            this.btImage.Click += new System.EventHandler(this.btImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btImage);
            this.groupBox1.Location = new System.Drawing.Point(753, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 372);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hình xét nghiệm";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbStatus);
            this.panel1.Controls.Add(this.lbCheckStatus);
            this.panel1.Controls.Add(this.lbDoiTenXN);
            this.panel1.Controls.Add(this.lbSoLanXN);
            this.panel1.Controls.Add(this.cbXnLai);
            this.panel1.Controls.Add(this.lbHanXN);
            this.panel1.Controls.Add(this.tbGhiChu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbUpdateXN);
            this.panel1.Controls.Add(this.lbNgayXN);
            this.panel1.Controls.Add(this.lbLoaiXN);
            this.panel1.Controls.Add(this.tbketQua);
            this.panel1.Controls.Add(this.cbPass);
            this.panel1.Controls.Add(this.cbFail);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 479);
            this.panel1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Thời hạn: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Trạng thái: ";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(356, 59);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(51, 20);
            this.lbStatus.TabIndex = 36;
            this.lbStatus.Text = "label1";
            // 
            // lbCheckStatus
            // 
            this.lbCheckStatus.AutoSize = true;
            this.lbCheckStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckStatus.ForeColor = System.Drawing.Color.Red;
            this.lbCheckStatus.Location = new System.Drawing.Point(90, 131);
            this.lbCheckStatus.Name = "lbCheckStatus";
            this.lbCheckStatus.Size = new System.Drawing.Size(0, 13);
            this.lbCheckStatus.TabIndex = 35;
            // 
            // lbDoiTenXN
            // 
            this.lbDoiTenXN.AutoSize = true;
            this.lbDoiTenXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoiTenXN.ForeColor = System.Drawing.Color.Red;
            this.lbDoiTenXN.Location = new System.Drawing.Point(11, 414);
            this.lbDoiTenXN.Name = "lbDoiTenXN";
            this.lbDoiTenXN.Size = new System.Drawing.Size(0, 16);
            this.lbDoiTenXN.TabIndex = 34;
            // 
            // lbSoLanXN
            // 
            this.lbSoLanXN.AutoSize = true;
            this.lbSoLanXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLanXN.Location = new System.Drawing.Point(393, 94);
            this.lbSoLanXN.Name = "lbSoLanXN";
            this.lbSoLanXN.Size = new System.Drawing.Size(56, 20);
            this.lbSoLanXN.TabIndex = 33;
            this.lbSoLanXN.Text = "lần xn";
            // 
            // cbXnLai
            // 
            this.cbXnLai.AutoSize = true;
            this.cbXnLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbXnLai.Location = new System.Drawing.Point(9, 314);
            this.cbXnLai.Name = "cbXnLai";
            this.cbXnLai.Size = new System.Drawing.Size(142, 24);
            this.cbXnLai.TabIndex = 32;
            this.cbXnLai.Text = "Xét nghiệm lại";
            this.cbXnLai.UseVisualStyleBackColor = true;
            // 
            // lbHanXN
            // 
            this.lbHanXN.AutoSize = true;
            this.lbHanXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHanXN.Location = new System.Drawing.Point(89, 88);
            this.lbHanXN.Name = "lbHanXN";
            this.lbHanXN.Size = new System.Drawing.Size(39, 20);
            this.lbHanXN.TabIndex = 31;
            this.lbHanXN.Text = "Hạn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Lần xét nghiệm:";
            // 
            // frm_UpdateXN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 559);
            this.Controls.Add(this.panel1);
            this.Name = "frm_UpdateXN";
            this.Text = "frm_UpdateXN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox tbketQua;
        private System.Windows.Forms.Label lbLoaiXN;
        private System.Windows.Forms.Label lbNgayXN;
        private System.Windows.Forms.Button tbUpdateXN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tbGhiChu;
        private System.Windows.Forms.CheckBox cbFail;
        private System.Windows.Forms.CheckBox cbPass;
        private System.Windows.Forms.Button btImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbHanXN;
        private System.Windows.Forms.CheckBox cbXnLai;
        private System.Windows.Forms.Label lbSoLanXN;
        private System.Windows.Forms.Label lbDoiTenXN;
        private System.Windows.Forms.Label lbCheckStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}