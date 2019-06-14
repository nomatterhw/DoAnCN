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
    public partial class frm_HenLamXN : Form
    {
        frm_addXN f;
        public frm_HenLamXN(frm_addXN frm)
        {
            InitializeComponent();
            lbResult.Visible = false;
            this.f = frm;
            this.Text = "Hẹn xét nghiệm";
            lbTenBN.Text = f.TenBN;
            lbTenXN.Text = "Xét nghiệm: " + f.TenXN;
            lbNgayXN.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.lbNgayXN.Text = monthCalendar1.SelectionStart.ToString("dd\\/MM\\/yyyy");
        }

        private void btHenKham_Click(object sender, EventArgs e)
        {
            try
            {
                String tenXN = f.TenXN;
                String tenBN = f.TenBN;
                int maBN = f.MaBN;
                String ngayXN = lbNgayXN.Text;
                int idLoaiXN = Convert.ToInt32(f.id);
                int thoiHan = f.thoiHan;
                HenXN bn = new HenXN() { TenBN = tenBN, NgayXN = ngayXN, LoaiXN = tenXN, MaBN = maBN, IDLoaiXN = idLoaiXN, ThoiHanXN=thoiHan };
                bool result = new HenXetNghiemBUL().AddHenXN(bn);
                if (result)
                {
                    lbResult.Visible = true;
                    lbResult.Text = "Đặt lịch thành công";
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
