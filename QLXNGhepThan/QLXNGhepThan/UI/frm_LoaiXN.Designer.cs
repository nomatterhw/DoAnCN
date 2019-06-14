namespace QLXNGhepThan.UI
{
    partial class frm_LoaiXN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbThoihan = new System.Windows.Forms.Label();
            this.tbThoiHan = new System.Windows.Forms.TextBox();
            this.btAddXN = new System.Windows.Forms.Button();
            this.btUpdateXN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLoaiXN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 102);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbThoihan);
            this.groupBox1.Controls.Add(this.tbThoiHan);
            this.groupBox1.Controls.Add(this.btAddXN);
            this.groupBox1.Controls.Add(this.btUpdateXN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbLoaiXN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbNote);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 102);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý xét nghiệm";
            // 
            // lbThoihan
            // 
            this.lbThoihan.AutoSize = true;
            this.lbThoihan.Location = new System.Drawing.Point(0, 52);
            this.lbThoihan.Name = "lbThoihan";
            this.lbThoihan.Size = new System.Drawing.Size(49, 13);
            this.lbThoihan.TabIndex = 9;
            this.lbThoihan.Text = "Thời hạn";
            // 
            // tbThoiHan
            // 
            this.tbThoiHan.Location = new System.Drawing.Point(98, 49);
            this.tbThoiHan.Name = "tbThoiHan";
            this.tbThoiHan.Size = new System.Drawing.Size(154, 20);
            this.tbThoiHan.TabIndex = 8;
            // 
            // btAddXN
            // 
            this.btAddXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddXN.ForeColor = System.Drawing.Color.Red;
            this.btAddXN.Image = global::QLXNGhepThan.Properties.Resources.iconADD;
            this.btAddXN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAddXN.Location = new System.Drawing.Point(258, 23);
            this.btAddXN.Name = "btAddXN";
            this.btAddXN.Size = new System.Drawing.Size(136, 34);
            this.btAddXN.TabIndex = 0;
            this.btAddXN.Text = "Thêm mới";
            this.btAddXN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAddXN.UseVisualStyleBackColor = true;
            this.btAddXN.Click += new System.EventHandler(this.btAddXN_Click);
            // 
            // btUpdateXN
            // 
            this.btUpdateXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateXN.ForeColor = System.Drawing.Color.Blue;
            this.btUpdateXN.Image = global::QLXNGhepThan.Properties.Resources.iconSave;
            this.btUpdateXN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUpdateXN.Location = new System.Drawing.Point(258, 63);
            this.btUpdateXN.Name = "btUpdateXN";
            this.btUpdateXN.Size = new System.Drawing.Size(136, 34);
            this.btUpdateXN.TabIndex = 1;
            this.btUpdateXN.Text = "Cập nhật ";
            this.btUpdateXN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btUpdateXN.UseVisualStyleBackColor = true;
            this.btUpdateXN.Click += new System.EventHandler(this.btUpdateXN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ghi chú";
            // 
            // tbLoaiXN
            // 
            this.tbLoaiXN.Location = new System.Drawing.Point(98, 23);
            this.tbLoaiXN.Name = "tbLoaiXN";
            this.tbLoaiXN.Size = new System.Drawing.Size(154, 20);
            this.tbLoaiXN.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên xét nghiệm";
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(98, 74);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(154, 20);
            this.tbNote.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(20, 60);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(760, 347);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frm_LoaiXN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Name = "frm_LoaiXN";
            this.Text = "frm_LoaiXN";
            this.Load += new System.EventHandler(this.frm_LoaiXN_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btUpdateXN;
        private System.Windows.Forms.Button btAddXN;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.TextBox tbLoaiXN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbThoihan;
        private System.Windows.Forms.TextBox tbThoiHan;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}