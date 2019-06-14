using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLXNGhepThan.BLL;

namespace QLXNGhepThan.UI
{
    public partial class frm_LoaiXN : MetroFramework.Forms.MetroForm
    {
        public frm_LoaiXN()
        {
            InitializeComponent();
            this.Text = "Danh mục loại xét nghiệm";
        }

        public int IDLoaiXN;

        private void frm_LoaiXN_Load(object sender, EventArgs e)
        {
            Reload();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.MediumBlue;
            dataGridView1.EnableHeadersVisualStyles = false;

            this.dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1.Columns[1].Width = 500;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 300;
        }

        public void Reload()
        {
            List<LoaiXetNghiem> loaiXetNghiems = new LoaiXetNghiemBUL().GetDanhMucXN();
            dataGridView1.DataSource = loaiXetNghiems;
            dataGridView1.Columns[1].HeaderText = "Tên xét nghiệm";
            dataGridView1.Columns[2].HeaderText = "Thời hạn (ngày)";
            dataGridView1.Columns[3].HeaderText = "Ghi chú";
            dataGridView1.Columns[0].Visible = false;
        }

        private void btAddXN_Click(object sender, EventArgs e)
        {
            try
            {
                String ten = tbLoaiXN.Text.Trim();
                String note = tbNote.Text.Trim();
                int thoiHan = int.Parse(tbThoiHan.Text.Trim());
                LoaiXetNghiem loaiXetNghiem = new LoaiXetNghiem() {TenXN=ten ,ThoiHan=thoiHan, Note = note };
                bool result = new LoaiXetNghiemBUL().ThemLoaiXN(loaiXetNghiem);
                if (result)
                {
                    Reload();
                }
                else
                    MessageBox.Show("Thêm thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin");
            }
        }

        private void btUpdateXN_Click(object sender, EventArgs e)
        {
            try
            {
                String ten = tbLoaiXN.Text.Trim();
                int thoiHan = int.Parse(tbThoiHan.Text.Trim());
                String note = tbNote.Text.Trim();
                LoaiXetNghiem loaiXetNghiem = new LoaiXetNghiem() { TenXN = ten, ThoiHan = thoiHan, Note = note };
                bool result = new LoaiXetNghiemBUL().UpdateLoaiXN(IDLoaiXN, loaiXetNghiem);
                if (result)
                {
                    Reload();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thất bại");
                }
            }
            catch
            {
                MessageBox.Show("Cập nhật thông tin thất bại");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dataGridView1.CurrentRow.Index;
            IDLoaiXN = Convert.ToInt32(dataGridView1.Rows[n].Cells[0].Value.ToString());
            tbLoaiXN.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
            tbThoiHan.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            tbNote.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
        }

    }
}
