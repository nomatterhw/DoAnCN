namespace QLXNGhepThan
{
    partial class frm_addXN
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
            this.tbGhiChu = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbStt = new System.Windows.Forms.Label();
            this.tbketQua = new System.Windows.Forms.RichTextBox();
            this.cbbLoaiXN = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btHenKham = new System.Windows.Forms.Button();
            this.cbFail = new System.Windows.Forms.CheckBox();
            this.cbPass = new System.Windows.Forms.CheckBox();
            this.tbADD = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGhiChu.Location = new System.Drawing.Point(15, 219);
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(636, 66);
            this.tbGhiChu.TabIndex = 15;
            this.tbGhiChu.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kết quả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ghi chú";
            // 
            // lbStt
            // 
            this.lbStt.AutoSize = true;
            this.lbStt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStt.Location = new System.Drawing.Point(11, 40);
            this.lbStt.Name = "lbStt";
            this.lbStt.Size = new System.Drawing.Size(120, 20);
            this.lbStt.TabIndex = 12;
            this.lbStt.Text = "Loại xét nghiệm";
            // 
            // tbketQua
            // 
            this.tbketQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbketQua.Location = new System.Drawing.Point(15, 119);
            this.tbketQua.Name = "tbketQua";
            this.tbketQua.Size = new System.Drawing.Size(636, 66);
            this.tbketQua.TabIndex = 3;
            this.tbketQua.Text = "";
            // 
            // cbbLoaiXN
            // 
            this.cbbLoaiXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiXN.FormattingEnabled = true;
            this.cbbLoaiXN.Location = new System.Drawing.Point(15, 63);
            this.cbbLoaiXN.Name = "cbbLoaiXN";
            this.cbbLoaiXN.Size = new System.Drawing.Size(253, 28);
            this.cbbLoaiXN.TabIndex = 16;
            this.cbbLoaiXN.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiXN_SelectedIndexChanged_1);
            this.cbbLoaiXN.SelectionChangeCommitted += new System.EventHandler(this.cbbLoaiXN_SelectedIndexChanged_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btHenKham);
            this.panel1.Controls.Add(this.cbFail);
            this.panel1.Controls.Add(this.cbPass);
            this.panel1.Controls.Add(this.tbketQua);
            this.panel1.Controls.Add(this.cbbLoaiXN);
            this.panel1.Controls.Add(this.tbGhiChu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbADD);
            this.panel1.Controls.Add(this.lbStt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 480);
            this.panel1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btImage);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(753, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 372);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hình xét nghiệm";
            // 
            // btImage
            // 
            this.btImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImage.Image = global::QLXNGhepThan.Properties.Resources.iconOpenFile;
            this.btImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btImage.Location = new System.Drawing.Point(6, 320);
            this.btImage.Name = "btImage";
            this.btImage.Size = new System.Drawing.Size(185, 46);
            this.btImage.TabIndex = 21;
            this.btImage.Text = "Chọn hình";
            this.btImage.UseVisualStyleBackColor = true;
            this.btImage.Click += new System.EventHandler(this.btImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLXNGhepThan.Properties.Resources.no_image_icon_23485;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btHenKham
            // 
            this.btHenKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHenKham.Image = global::QLXNGhepThan.Properties.Resources.iconHenKham;
            this.btHenKham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHenKham.Location = new System.Drawing.Point(245, 325);
            this.btHenKham.Name = "btHenKham";
            this.btHenKham.Size = new System.Drawing.Size(185, 46);
            this.btHenKham.TabIndex = 19;
            this.btHenKham.Text = "Hẹn làm xét nghiệm";
            this.btHenKham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btHenKham.UseVisualStyleBackColor = true;
            this.btHenKham.Click += new System.EventHandler(this.btHenKham_Click);
            // 
            // cbFail
            // 
            this.cbFail.AutoSize = true;
            this.cbFail.Location = new System.Drawing.Point(575, 97);
            this.cbFail.Name = "cbFail";
            this.cbFail.Size = new System.Drawing.Size(76, 17);
            this.cbFail.TabIndex = 18;
            this.cbFail.Text = "Không đạt";
            this.cbFail.UseVisualStyleBackColor = true;
            this.cbFail.CheckedChanged += new System.EventHandler(this.cbFail_CheckedChanged);
            // 
            // cbPass
            // 
            this.cbPass.AutoSize = true;
            this.cbPass.Location = new System.Drawing.Point(491, 96);
            this.cbPass.Name = "cbPass";
            this.cbPass.Size = new System.Drawing.Size(78, 17);
            this.cbPass.TabIndex = 17;
            this.cbPass.Text = "Thông qua";
            this.cbPass.UseVisualStyleBackColor = true;
            this.cbPass.CheckedChanged += new System.EventHandler(this.cbPass_CheckedChanged);
            // 
            // tbADD
            // 
            this.tbADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbADD.Image = global::QLXNGhepThan.Properties.Resources.iconSave;
            this.tbADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbADD.Location = new System.Drawing.Point(15, 325);
            this.tbADD.Name = "tbADD";
            this.tbADD.Size = new System.Drawing.Size(185, 46);
            this.tbADD.TabIndex = 8;
            this.tbADD.Text = "Thêm xét nghiệm";
            this.tbADD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tbADD.UseVisualStyleBackColor = true;
            this.tbADD.Click += new System.EventHandler(this.tbADD_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frm_addXN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 560);
            this.Controls.Add(this.panel1);
            this.Name = "frm_addXN";
            this.Text = "frm_addXN";
            this.Load += new System.EventHandler(this.frm_addXN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox tbGhiChu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button tbADD;
        private System.Windows.Forms.Label lbStt;
        private System.Windows.Forms.RichTextBox tbketQua;
        private System.Windows.Forms.ComboBox cbbLoaiXN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btHenKham;
        private System.Windows.Forms.CheckBox cbFail;
        private System.Windows.Forms.CheckBox cbPass;
        private System.Windows.Forms.Button btImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}