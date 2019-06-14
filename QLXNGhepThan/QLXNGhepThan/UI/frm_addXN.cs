using QLXNGhepThan.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLXNGhepThan.BLL;

namespace QLXNGhepThan
{
    public partial class frm_addXN : MetroFramework.Forms.MetroForm
    {
        Form2 f2;
        DAL dal = new DAL();

        public frm_addXN(Form2 frm2)
        {
            InitializeComponent();

            this.f2 = frm2;
            this.Text = "Thêm xét nghiệm bệnh nhân: "+f2.tenBN;
            FillCbb();
            TenBN = f2.tenBN;
            MaBN = f2.maBN;
            IDXN = "BN" + f2.maBN + id;
        }

        public String TenXN;
        public String TenBN;
        public int MaBN;

        public string id;
        public String IDXN;
        public String stt;
        public int thoiHan;
        

        private void frm_addXN_Load(object sender, EventArgs e)
        {
            //using (QLXNGhepThan.DBDataContext db = new DBDataContext())
            //{
            //    cbbLoaiXN.ValueMember = "IDLoaiXN";
            //    cbbLoaiXN.DisplayMember = "TenXN";
            //    cbbLoaiXN.DataSource = db.LoaiXetNghiems.ToList<LoaiXetNghiem>();
            //}

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
            try
            {
                MemoryStream stream = new MemoryStream();
                pictureBox1.Image.Save(stream, ImageFormat.Jpeg);           
                String tenXN = cbbLoaiXN.Text;
                String idXN = "BN" + f2.maBN + id;
                String ngayXN = DateTime.Now.ToString("dd/MM/yyyy");
                String ketQua = tbketQua.Text.Trim();
                String ghiChu = tbGhiChu.Text.Trim();
                String hanXN = DateTime.Now.AddDays(thoiHan).ToString("dd/MM/yyyy");
                int solan = 1;
                int maBN = f2.maBN;
                if (ketQua == "")
                {
                    stt = "Chưa có kết quả";
                    DialogResult dialogResult = MessageBox.Show("Chưa điền kết quả\nKết quả sẽ ở trạng thái chờ", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        XetNghiem xn1 = new XetNghiem() { ID = idXN, TenXN = tenXN, NgayXN = ngayXN, KetQua = ketQua, IDLoaiXN = Convert.ToInt32(id), MaBN = maBN, Note = ghiChu, Status = stt, SoLanXN = solan, Image = stream.ToArray(), Thoihan = hanXN };
                        bool result1 = new XetNghiemBUL().ThemXN(xn1);
                        if (result1)
                        {
                            f2.Reload();
                            Thread.Sleep(200);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Chưa chọn xét nghiệm !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else if (cbFail.Checked == true || cbPass.Checked == true)
                {
                    XetNghiem xn1 = new XetNghiem() { ID = idXN, TenXN = tenXN, NgayXN = ngayXN, KetQua = ketQua, IDLoaiXN = Convert.ToInt32(id), MaBN = maBN, Note = ghiChu, Status = stt, SoLanXN = solan, Image = stream.ToArray(), Thoihan = hanXN };
                    bool result1 = new XetNghiemBUL().ThemXN(xn1);
                    if (result1)
                    {
                        f2.Reload();
                        Thread.Sleep(200);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Chưa chọn xét nghiệm !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Chưa chọn trạng thái cho kết quả", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbADD_Click(object sender, EventArgs e)
        {
            UpdateXN();  
        }


        private void lbSolanXN_TextChanged(object sender, EventArgs e)
        {
            //lbSolanXN.Text = "Số lần xét nghiệm: " + f2.soLan;
        }


        private void tbcbb_TextChanged(object sender, EventArgs e)
        {

        }


        public void FillCbb()
        {
            string constring = dal.StrConn;
            string Query = "SELECT * FROM LoaiXetNghiem WHERE NOT EXISTS (SELECT *FROM XetNghiem WHERE LoaiXetNghiem.IDLoaiXN=XetNghiem.IDLoaiXN AND XetNghiem.MaBN='"+f2.maBN+"')";
            SqlConnection conDB = new SqlConnection(constring);
            SqlCommand cmdDB = new SqlCommand(Query, conDB);
            conDB.Open();
            SqlDataReader reader = cmdDB.ExecuteReader();
            try
            {
              while (reader.Read())
                {
                    String name = reader.GetString(1);                   
                    cbbLoaiXN.Items.Add(name);
                }
            }
            catch
            { }
        }

        private void cbbLoaiXN_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string constring = dal.StrConn;
            string Query = "select * from LoaiXetNghiem where TenXN=N'" + cbbLoaiXN.Text + "'";
            SqlConnection conDB = new SqlConnection(constring);
            SqlCommand cmdDB = new SqlCommand(Query, conDB);
            conDB.Open();
            SqlDataReader reader = cmdDB.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    id = reader.GetInt32(0).ToString();
                    TenXN = reader.GetString(1).ToString();
                    thoiHan = reader.GetInt32(2);
                }
            }
            catch
            { }
        }

        private void cbFail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFail.Checked == true)
            {
                cbPass.Checked = false;
                stt = "Không đạt";
            }
        }

        private void cbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPass.Checked == true)
            {
                cbFail.Checked = false;
                stt = "Thông qua";
            }
        }

        private void btHenKham_Click(object sender, EventArgs e)
        {
            if (cbbLoaiXN.Text != "")
            {
                frm_HenLamXN f = new frm_HenLamXN(this);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa chọn xét nghiệm");
            }

        }


    }
}
