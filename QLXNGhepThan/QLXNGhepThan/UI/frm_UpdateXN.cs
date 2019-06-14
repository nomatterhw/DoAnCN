using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLXNGhepThan.BLL;

namespace QLXNGhepThan.UI
{
    public partial class frm_UpdateXN : MetroFramework.Forms.MetroForm
    {
        Form2 f2;
        DBDataContext db = new DBDataContext();
        DAL dal = new DAL();
        public frm_UpdateXN(Form2 frm2)
        {
            InitializeComponent();
            ToolTip tip = new ToolTip();
            tip.SetToolTip(cbXnLai,"Lưu kết quả xét nghiệm mới cho xét nghiệm đã hết hạn");

            this.f2 = frm2;
            LayTenLoaiXN();
            this.Text = "Bệnh nhân: " + f2.tenBN;
            lbLoaiXN.Text = "Loại xét nghiệm: " + TenXN;
            if (TenXN != f2.tenXN)
            {
                lbDoiTenXN.Text = "Lưu ý: xét nghiệm "+ f2.tenXN + " đã được đổi tên thành: " + TenXN + "\nvui lòng nhấn cập nhật lại để lưu tên mới";
            }
            lbNgayXN.Text = "Ngày xét nghiệm: " + f2.ngayXN;
            SetColorThoiHan();
            lbHanXN.Text= f2.hanXN;
            SetColorStatus();
            lbStatus.Text = f2.stt;
            lbSoLanXN.Text = f2.soLan.ToString();
            tbketQua.Text = f2.ketQua;
            tbGhiChu.Text = f2.ghiChu;
            LoadImage();
        }
        public int hanXN;
        public int IDLoaiXN;
        public string TenXN;

        public void SetColorStatus()
        {
            if (f2.stt == "Thông qua")
            {
                lbStatus.ForeColor = Color.Green;
            }
            if (f2.stt == "Không đạt")
            {
                lbStatus.ForeColor = Color.Red;
            }
            if (f2.stt == "Chưa có kết quả")
            {
                lbStatus.ForeColor = Color.Orange;
            }
        }

        public void SetColorThoiHan()
        {
            DateTime hanXN = DateTime.ParseExact(f2.hanXN, "dd/MM/yyyy", null);
            DateTime now = DateTime.UtcNow;
            TimeSpan ngay = hanXN - now;
            int tongngay = ngay.Days;
            if (tongngay < 0)
            {
                lbHanXN.ForeColor = Color.Red;
            }
        }

        public void LoadImage()
        {
            XetNghiem xn = db.XetNghiems.Where(x => x.ID.Contains(f2.maXN)).FirstOrDefault();
            if (xn == null)
                return;
            MemoryStream memoryStream = new MemoryStream(xn.Image.ToArray());
            Image image = Image.FromStream(memoryStream);
            if (image == null)
                return;
            pictureBox1.Image = image;
        }

        public void LayTenLoaiXN()
        {
            string constring = dal.StrConn;
            string Query = "SELECT * FROM LoaiXetNghiem WHERE IDLoaiXN='" + f2.IDLoaiXN + "'";
            SqlConnection conDB = new SqlConnection(constring);
            SqlCommand cmdDB = new SqlCommand(Query, conDB);
            conDB.Open();
            SqlDataReader reader = cmdDB.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    TenXN = reader.GetString(1);
                }
            }
            catch
            { }
        }

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

        public void UpdateXN()
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
            String tenXN = TenXN;
            String idXN = f2.maXN;
            String ketQua = tbketQua.Text.Trim();
            String ghiChu = tbGhiChu.Text.Trim();
            String stt = f2.stt;
            int maBN = f2.maBN;

            if (cbPass.Checked == true)
            {
                stt = "Thông qua";
            }
            if (cbFail.Checked == true)
            {
                stt = "Không đạt";
            }


            if (cbXnLai.Checked == true) // bệnh nhân xét nghiệm lại: gia hạn thời hạn XN + thêm số lần XN
            {
                DateTime hanXn = DateTime.ParseExact(f2.hanXN, "dd/MM/yyyy", null);
                DateTime now = DateTime.UtcNow;
                TimeSpan ngay = hanXn - now;
                int tongngay = ngay.Days;

                if (tongngay < 0) // kiểm tra hạn xét nghiệm trước khi thêm
                {
                    LayHanXN();
                    String thoiHan = DateTime.Now.AddDays(hanXN).ToString("dd/MM/yyyy");
                    String ngayXN = DateTime.Now.ToString("dd/MM/yyyy");
                    int solan = f2.soLan++;
                    String maXN = f2.maXN + solan;
                    if (ketQua == "")
                    {
                        stt = "Chưa có kết quả";
                        DialogResult dialogResult = MessageBox.Show("Chưa điền kết quả\nKết quả sẽ ở trạng thái chờ", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            XetNghiem xn1 = new XetNghiem() { ID = maXN, TenXN = tenXN, NgayXN = ngayXN, KetQua = ketQua, MaBN = maBN, Note = ghiChu, IDLoaiXN = f2.IDLoaiXN, Status = stt, Thoihan = thoiHan, SoLanXN = solan, Image = stream.ToArray() };
                            bool result1 = new XetNghiemBUL().ThemXN(xn1);
                            if (result1)
                            {
                                f2.Reload();
                                Thread.Sleep(200);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Đây là xét nghiệm cũ\nhãy cập nhật ở xét nghiệm lần gần đây nhất", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        XetNghiem xn1 = new XetNghiem() { ID = maXN, TenXN = tenXN, NgayXN = ngayXN, KetQua = ketQua, MaBN = maBN, Note = ghiChu, IDLoaiXN = f2.IDLoaiXN, Status = stt, Thoihan = thoiHan, SoLanXN = solan, Image = stream.ToArray() };
                        bool result1 = new XetNghiemBUL().ThemXN(xn1);
                        if (result1)
                        {
                            f2.Reload();
                            Thread.Sleep(200);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Đây là xét nghiệm cũ\nhãy cập nhật ở xét nghiệm lần gần đây nhất", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else 
                {
                    DialogResult dialogResultThem = MessageBox.Show("Xét nghiệm vẫn còn hạn \nBạn có muốn xét nghiệm lại", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResultThem == DialogResult.Yes)
                    {
                        LayHanXN();
                        String thoiHan = DateTime.Now.AddDays(hanXN).ToString("dd/MM/yyyy");
                        String ngayXN = DateTime.Now.ToString("dd/MM/yyyy");
                        int solan = f2.soLan + 1;
                        String maXN = f2.maXN + solan;
                        if (ketQua == "")
                        {
                            stt = "Chưa có kết quả";
                            DialogResult dialogResult1 = MessageBox.Show("Chưa điền kết quả\nKết quả sẽ ở trạng thái chờ", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dialogResult1 == DialogResult.Yes)
                            {
                                XetNghiem xn1 = new XetNghiem() { ID = maXN, TenXN = tenXN, NgayXN = ngayXN, KetQua = ketQua, MaBN = maBN, Note = ghiChu, IDLoaiXN = f2.IDLoaiXN, Status = stt, Thoihan = thoiHan, SoLanXN = solan, Image = stream.ToArray() };
                                bool result1 = new XetNghiemBUL().ThemXN(xn1);
                                if (result1)
                                {
                                    f2.Reload();
                                    Thread.Sleep(200);
                                    this.Close();
                                }
                                else
                                    MessageBox.Show("Đây là xét nghiệm cũ\nhãy cập nhật ở xét nghiệm lần gần đây nhất", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            XetNghiem xn1 = new XetNghiem() { ID = maXN, TenXN = tenXN, NgayXN = ngayXN, KetQua = ketQua, MaBN = maBN, Note = ghiChu, IDLoaiXN = f2.IDLoaiXN, Status = stt, Thoihan = thoiHan, SoLanXN = solan, Image = stream.ToArray() };
                            bool result1 = new XetNghiemBUL().ThemXN(xn1);
                            if (result1)
                            {
                                f2.Reload();
                                Thread.Sleep(200);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Đây là xét nghiệm cũ\nhãy cập nhật ở xét nghiệm lần gần đây nhất", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            else // Chỉ update thông tin, bệnh nhân không XN lại
            {
                String thoiHanTruocDo = f2.hanXN;
                String ngayXN = f2.ngayXN;
                if (ketQua == "")
                {
                    stt = "Chưa có kết quả";
                    DialogResult dialogResult = MessageBox.Show("Chưa điền kết quả\nKết quả sẽ ở trạng thái chờ", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        XetNghiem xn1 = new XetNghiem() { TenXN = tenXN, NgayXN = ngayXN, KetQua = ketQua, MaBN = maBN, Note = ghiChu, Status = stt, Thoihan = thoiHanTruocDo, Image = stream.ToArray() };
                        bool result1 = new XetNghiemBUL().UpdateXN(idXN, xn1);
                        if (result1)
                        {
                            f2.Reload();
                            Thread.Sleep(200);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Cập nhật không thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {

                    XetNghiem xn1 = new XetNghiem() { TenXN = tenXN, NgayXN = ngayXN, KetQua = ketQua, MaBN = maBN, Note = ghiChu, Status = stt, Thoihan = thoiHanTruocDo, Image = stream.ToArray() };
                    bool result1 = new XetNghiemBUL().UpdateXN(idXN, xn1);
                    if (result1)
                    {
                        f2.Reload();
                        Thread.Sleep(200);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Cập nhật không thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void tbUpdateXN_Click(object sender, EventArgs e)
        {
            UpdateXN();
        }

      
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            frm_ShowImage img = new frm_ShowImage(this.f2);
            img.pictureBox1.Image = this.pictureBox1.Image;
            img.ShowDialog();
        }

        public void LayHanXN()
        {
            string constring = dal.StrConn;
            string Query = "select * from LoaiXetNghiem where TenXN=N'" + f2.tenXN + "'";
            SqlConnection conDB = new SqlConnection(constring);
            SqlCommand cmdDB = new SqlCommand(Query, conDB);
            conDB.Open();
            SqlDataReader reader = cmdDB.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    hanXN = reader.GetInt32(2);
                }
            }
            catch
            { }
        }

        private void cbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPass.Checked == true)
            {
                cbFail.Checked = false;
            }
        }

        private void cbFail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFail.Checked == true)
            {
                cbPass.Checked = false;
            }
        }
    }
}
