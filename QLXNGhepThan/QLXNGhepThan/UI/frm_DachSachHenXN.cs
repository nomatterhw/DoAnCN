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
    public partial class frm_DachSachHenXN : MetroFramework.Forms.MetroForm
    {
        public String key = DateTime.Now.ToString("dd/MM/yyyy");
        public frm_DachSachHenXN()
        {
            InitializeComponent();

            ToolTip tip = new ToolTip();
            tip.SetToolTip(tbTim, "tìm thông tin bệnh nhân theo tên");

            this.Text = "Danh sách hẹn xét nghiệm theo ngày";
            String key = DateTime.Now.ToString("dd/MM/yyyy");
            List<HenXN> henXNs = new HenXetNghiemBUL().LayDanhSachHenTheoNgay(key);
            dataGridView1.DataSource = henXNs;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8.75F, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.MediumBlue;
            dataGridView1.EnableHeadersVisualStyles = false;

            Reload();

            dataGridView1.Columns[1].HeaderText = "Tên bệnh nhân";
            dataGridView1.Columns[2].HeaderText = "Ngày hẹn xét nghiệm";
            dataGridView1.Columns[3].HeaderText = "Loại xét nghiệm";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public int maBN;
        public string tenBN;
        public string tenXN;
        public int idLoaiXN;
        public int idLichHen;
        public int thoiHanXN;

        public void Reload()
        {
            List<HenXN> henXNs = new HenXetNghiemBUL().LayDanhSachHenTheoNgay(key);
            dataGridView1.DataSource = henXNs;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            ngayXN = monthCalendar1.SelectionStart.ToString("dd\\/MM\\/yyyy");
            String key = ngayXN;
            List<HenXN> henXNs = new HenXetNghiemBUL().LayDanhSachHenTheoNgay(key);
            dataGridView1.DataSource = henXNs;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void frm_DachSachHenXN_Load(object sender, EventArgs e)
        {
            GetDanhSachTheoNgay();
        }

        public String ngayXN;



        public void GetDanhSachTheoNgay()
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbTim_TextChanged(object sender, EventArgs e)
        {
            String key = tbTim.Text.Trim();
            List<HenXN> henXNs = new HenXetNghiemBUL().TimHenTheoTen(key);
            dataGridView1.DataSource = henXNs;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dataGridView1.CurrentRow.Index;
            idLichHen = Convert.ToInt32(dataGridView1.Rows[n].Cells[0].Value.ToString());
            maBN = Convert.ToInt32(dataGridView1.Rows[n].Cells[4].Value.ToString());
            tenBN = dataGridView1.Rows[n].Cells[1].Value.ToString();
            tenXN = dataGridView1.Rows[n].Cells[3].Value.ToString();
            idLoaiXN = Convert.ToInt32(dataGridView1.Rows[n].Cells[5].Value.ToString());
            thoiHanXN = Convert.ToInt32(dataGridView1.Rows[n].Cells[6].Value.ToString());
            frm_AddXnTuLichHen f = new frm_AddXnTuLichHen(this);
            f.ShowDialog();
        }

        private void dataGridView1_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            e.ToolTipText = "Nhấp đúp chuột để thêm xét nghiệm cho bệnh nhân này";
        }
    }
}
