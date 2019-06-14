namespace QLXNGhepThan
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btEditXN = new MetroFramework.Controls.MetroButton();
            this.cbLocXNPass = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbChoketQua = new System.Windows.Forms.CheckBox();
            this.cbLocXNfail = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btExportExcel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbTimXN = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(760, 227);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.dataGridView1_CellToolTipTextNeeded);
            this.dataGridView1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValidated);
            // 
            // btEditXN
            // 
            this.btEditXN.Location = new System.Drawing.Point(14, 27);
            this.btEditXN.Name = "btEditXN";
            this.btEditXN.Size = new System.Drawing.Size(251, 43);
            this.btEditXN.TabIndex = 1;
            this.btEditXN.Text = "Thêm xét nghiệm";
            this.btEditXN.Click += new System.EventHandler(this.btEditXN_Click);
            // 
            // cbLocXNPass
            // 
            this.cbLocXNPass.AutoSize = true;
            this.cbLocXNPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocXNPass.Location = new System.Drawing.Point(6, 20);
            this.cbLocXNPass.Name = "cbLocXNPass";
            this.cbLocXNPass.Size = new System.Drawing.Size(197, 20);
            this.cbLocXNPass.TabIndex = 3;
            this.cbLocXNPass.Text = "Xét nghiệm đã thông qua";
            this.cbLocXNPass.UseVisualStyleBackColor = true;
            this.cbLocXNPass.CheckedChanged += new System.EventHandler(this.cbLocXNPass_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbChoketQua);
            this.groupBox1.Controls.Add(this.cbLocXNfail);
            this.groupBox1.Controls.Add(this.cbLocXNPass);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(302, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc thông tin xét nghiệm";
            // 
            // cbChoketQua
            // 
            this.cbChoketQua.AutoSize = true;
            this.cbChoketQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChoketQua.Location = new System.Drawing.Point(6, 72);
            this.cbChoketQua.Name = "cbChoketQua";
            this.cbChoketQua.Size = new System.Drawing.Size(214, 20);
            this.cbChoketQua.TabIndex = 5;
            this.cbChoketQua.Text = "xét nghiệm chưa có kết quả";
            this.cbChoketQua.UseVisualStyleBackColor = true;
            this.cbChoketQua.CheckedChanged += new System.EventHandler(this.cbChoketQua_CheckedChanged);
            // 
            // cbLocXNfail
            // 
            this.cbLocXNfail.AutoSize = true;
            this.cbLocXNfail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocXNfail.Location = new System.Drawing.Point(6, 46);
            this.cbLocXNfail.Name = "cbLocXNfail";
            this.cbLocXNfail.Size = new System.Drawing.Size(175, 20);
            this.cbLocXNfail.TabIndex = 4;
            this.cbLocXNfail.Text = "Xét nghiệm không đạt";
            this.cbLocXNfail.UseVisualStyleBackColor = true;
            this.cbLocXNfail.CheckedChanged += new System.EventHandler(this.cbLocXNfail_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 227);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbStatus);
            this.panel2.Controls.Add(this.btEditXN);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 316);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 104);
            this.panel2.TabIndex = 6;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(112, 83);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 13);
            this.lbStatus.TabIndex = 7;
            // 
            // btExportExcel
            // 
            this.btExportExcel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btExportExcel.Image = global::QLXNGhepThan.Properties.Resources.iconExcel;
            this.btExportExcel.Location = new System.Drawing.Point(724, 0);
            this.btExportExcel.Name = "btExportExcel";
            this.btExportExcel.Size = new System.Drawing.Size(36, 29);
            this.btExportExcel.TabIndex = 5;
            this.btExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExportExcel.UseVisualStyleBackColor = true;
            this.btExportExcel.Click += new System.EventHandler(this.btExportExcel_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btExportExcel);
            this.panel3.Controls.Add(this.tbTimXN);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 29);
            this.panel3.TabIndex = 7;
            // 
            // tbTimXN
            // 
            this.tbTimXN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTimXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimXN.Location = new System.Drawing.Point(39, 0);
            this.tbTimXN.Name = "tbTimXN";
            this.tbTimXN.Size = new System.Drawing.Size(721, 29);
            this.tbTimXN.TabIndex = 2;
            this.tbTimXN.Text = "";
            this.tbTimXN.TextChanged += new System.EventHandler(this.tbTimXN_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::QLXNGhepThan.Properties.Resources.iconSearch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 29);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btEditXN;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox cbLocXNPass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbLocXNfail;
        private System.Windows.Forms.CheckBox cbChoketQua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox tbTimXN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btExportExcel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbStatus;
    }
}