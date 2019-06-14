using QLXNGhepThan.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLXNGhepThan.BLL;
using System.Text.RegularExpressions;

namespace QLXNGhepThan
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            ToolTip tip = new ToolTip();
            tip.SetToolTip(btTimBN, "tìm thông tin bệnh nhân theo tên");

        }

        public String tenBN;
        public String maBN;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Reload();

                this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.MediumBlue;
                dataGridView1.EnableHeadersVisualStyles = false;

                DgvDesign();
                tbID.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                tbName.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                tbNamSinh.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                tbGioiTinh.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                tbSDT.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                tbNgayXN.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
            }
            catch
            { }

        }

        public void Reload()
        {
            List<BenhNhan> benhNhans = new BenhNhanBUL().GetAll();
            dataGridView1.DataSource = benhNhans;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dataGridView1.CurrentRow.Index;
            tbID.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
            tbName.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
            tenBN = dataGridView1.Rows[n].Cells[1].Value.ToString();
            tbNamSinh.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            tbGioiTinh.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
            tbSDT.Text = dataGridView1.Rows[n].Cells[4].Value.ToString();
            tbNgayXN.Text = dataGridView1.Rows[n].Cells[5].Value.ToString();
        }



        public void DgvDesign()
        {
            dataGridView1.Columns["MaBN"].HeaderText = "ID";
            dataGridView1.Columns["TenBN"].HeaderText = "Họ & tên";
            dataGridView1.Columns["NamSinh"].HeaderText = "Năm sinh";
            dataGridView1.Columns["GioiTinh"].HeaderText = "Giới tính";
            dataGridView1.Columns["SDT"].HeaderText = "SĐT";
            dataGridView1.Columns["NgayXN"].HeaderText = "Ngày xét nghiệm";

            dataGridView1.Columns[0].Width = 50;

            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }



        //Xử lý 3 button-----------------------------------------------

        private void btADD_Click(object sender, EventArgs e)
        {
            frm_add frm = new frm_add(this);
            frm.Show();
        }


        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tbID.Text.Trim());
                String name = tbName.Text.Trim();
                int namsinh = int.Parse(tbNamSinh.Text.Trim());
                String gioitinh = tbGioiTinh.Text.Trim();
                String sdt = tbSDT.Text.Trim();
                if (Regex.IsMatch(sdt, @"^\d+$"))
                {
                    String ngayXN = tbNgayXN.Text.Trim();
                    BenhNhan bn = new BenhNhan() { MaBN = id, TenBN = name, NamSinh = namsinh, GioiTinh = gioitinh, SDT = sdt, NgayXN = ngayXN };
                    bool result = new BenhNhanBUL().Sua(id, bn);
                    if (result)
                    {
                        Reload();
                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại không hợp lệ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Cập nhật thông tin thất bại", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btXetNghiem_Click_1(object sender, EventArgs e)
        {
            Form2 f3 = new Form2(this);
            f3.ShowDialog();
        }


        private void btDanhMucXN_Click(object sender, EventArgs e)
        {
            frm_LoaiXN frm = new frm_LoaiXN();
            frm.Show();
        }

        private void btDanhSachHenXN_Click(object sender, EventArgs e)
        {
            frm_DachSachHenXN frmHenXN = new frm_DachSachHenXN();
            frmHenXN.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 f3 = new Form2(this);
            f3.ShowDialog();
        }

        private void btTimBN_TextChanged(object sender, EventArgs e)
        {
            String key = btTimBN.Text.Trim();
            List<BenhNhan> benhNhans = new BenhNhanBUL().Tim(key);
            dataGridView1.DataSource = benhNhans;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dataGridView1_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            e.ToolTipText = "Nhấp đúp chuột để xem thông tin xét nghiệm !";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                QLHS ql = new QLHS();
            ql.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult Dresult = MessageBox.Show("Bạn chắc chắn chứ ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Dresult == DialogResult.Yes)
            {
                try
                {
                    int id = int.Parse(tbID.Text.Trim());
                    String name = tbName.Text.Trim();
                    int namsinh = int.Parse(tbNamSinh.Text.Trim());
                    String gioitinh = tbGioiTinh.Text.Trim();
                    String sdt = tbSDT.Text.Trim();
                    if (Regex.IsMatch(sdt, @"^\d+$"))
                    {
                        String ngayXN = tbNgayXN.Text.Trim();
                        BenhNhan bn = new BenhNhan() { MaBN = id, TenBN = name, NamSinh = namsinh, GioiTinh = gioitinh, SDT = sdt, NgayXN = ngayXN };
                        bool result = new BenhNhanBUL().Delete(id);
                        if (result)
                        {
                            Reload();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa thành công");
                    }
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại", "Kiểm tra lại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
