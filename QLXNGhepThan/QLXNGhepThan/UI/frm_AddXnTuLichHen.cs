using QLXNGhepThan.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXNGhepThan.UI
{
    public partial class frm_AddXnTuLichHen : MetroFramework.Forms.MetroForm
    {
        frm_DachSachHenXN f;
        public frm_AddXnTuLichHen(frm_DachSachHenXN frm)
        {
            InitializeComponent();
            this.f = frm;
            this.Text = "Bệnh nhân: "+f.tenBN;
            lbLoaiXN.Text = f.tenXN;
        }

        public String stt;

        private void btImage_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                string file = openFileDialog1.FileName;
                if (string.IsNullOrEmpty(file))
                    return;
                Image myImage = Image.FromFile(file);
                pictureBox1.Image = myImage;
            }
            catch { }
        }


        public void AddXN()
        {
            try
            {
                System.IO.MemoryStream stream = new MemoryStream();
                pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
                int id = f.idLoaiXN;
                String tenXN = f.tenXN;
                String idXN = "BN" + f.maBN + id;
                String ngayXN = DateTime.Now.ToString("dd/MM/yyyy");
                String ketQua = tbketQua.Text.Trim();
                String ghiChu = tbGhiChu.Text.Trim();
                String hanXN = DateTime.Now.AddDays(f.thoiHanXN).ToString("dd/MM/yyyy");
                int solan = 1;
                int maBN = f.maBN;
                if (ketQua == "")
                {
                    stt = "Chưa có kết quả";
                    DialogResult dialogResult = MessageBox.Show("Chưa điền kết quả\nKết quả sẽ ở trạng thái chờ", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        XetNghiem xn1 = new XetNghiem() { ID = idXN, TenXN = tenXN, NgayXN = ngayXN, KetQua = ketQua, IDLoaiXN = id, MaBN = maBN, Note = ghiChu, Status = stt, SoLanXN = solan, Image = stream.ToArray(), Thoihan = hanXN };
                        bool result1 = new XetNghiemBUL().ThemXN(xn1);
                        if (result1)
                        {
                            Thread.Sleep(200);
                            bool result = new HenXetNghiemBUL().XoaHen(f.idLichHen); // Xóa thông tin lịch sau khi thêm XN
                            f.Reload(); // reload Dgv danh sách hẹn
                            this.Close();
                        }
                        else
                        {
                            DialogResult dialogResult2 = MessageBox.Show("Xét nghiệm đã có !\nXóa lịch hẹn ?", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            if (dialogResult == DialogResult.Yes)
                            {
                                bool result = new HenXetNghiemBUL().XoaHen(f.idLichHen);
                                f.Reload();
                                this.Close();
                            }
                        }
                    }

                }
                else if (cbFail.Checked == true || cbPass.Checked == true)
                {
                    XetNghiem xn1 = new XetNghiem() { ID = idXN, TenXN = tenXN, NgayXN = ngayXN, KetQua = ketQua, IDLoaiXN = Convert.ToInt32(id), MaBN = maBN, Note = ghiChu, Status = stt, SoLanXN = solan, Image = stream.ToArray(), Thoihan = hanXN };
                    bool result1 = new XetNghiemBUL().ThemXN(xn1);
                    if (result1)
                    {
                        Thread.Sleep(200);
                        bool result = new HenXetNghiemBUL().XoaHen(f.idLichHen);
                        f.Reload();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Xét nghiệm đã có !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dialogResult2 = MessageBox.Show("Xét nghiệm đã có !\nXóa lịch hẹn ?", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (dialogResult2 == DialogResult.Yes)
                    {
                        bool result = new HenXetNghiemBUL().XoaHen(f.idLichHen);
                        f.Reload();
                        this.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbADD_Click(object sender, EventArgs e)
        {
            AddXN();
            
        }

        private void cbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPass.Checked == true)
            {
                cbFail.Checked = false;
                stt = "Thông qua";
            }
        }

        private void cbFail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFail.Checked == true)
            {
                cbPass.Checked = false;
                stt = "Không đạt";
            }
        }
    }
}
