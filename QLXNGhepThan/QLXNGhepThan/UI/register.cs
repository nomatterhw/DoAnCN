using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLXNGhepThan.UI
{
    public partial class frm_register : Form
    {
        SqlConnection c = new SqlConnection("Data Source=DESKTOP-HB480T7;Initial Catalog=QLGhepThan;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt;
        public frm_register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            if (txt_TenNV.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên");
                return;
            }
            else if (txt_MaNV.Text != "")
            {
                MessageBox.Show("Nhân viên đã tồn tại");
                return;

            }

            else if (txt_GioiTinh.Text == "")
            {
                MessageBox.Show("Bạn phải nhập giới tính nhân viên");
                return;
            }
            else if (txt_DiaChi.Text == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ nhân viên");
                return;
            }
            else if (txt_email.Text == "")
            {
                MessageBox.Show("Bạn phải nhập email hoặc gmail nhân viên");
                return;
            }
            else if (txt_sdt.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại nhân viên");
                return;
            }
            else if (txt_mk.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mật khẩu nhân viên");
                return;
            }

            else
            {
                try
                {
                    c.Open();
                    string truyvan = string.Format("Insert into Account(TenNhanVien, GioiTinh, NamSinh,DiaChi,SDT,Email,MatKhau) values ('" + txt_TenNV.Text + "','" + txt_GioiTinh.Text + "','" + dateTimePicker_NamSinh.Text + "','" + txt_DiaChi.Text + "','" + txt_sdt.Text + "','" + txt_email.Text + "','" + txt_mk.Text + "' )");
                    SqlCommand cmd = new SqlCommand(truyvan, c);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Bạn đã tạo tài khoản thành công", "THÔNG BÁO");
                    this.Hide();
                    frm_login lg = new frm_login();
                    lg.Show();


                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            frm_login signin = new frm_login();
            signin.Show();
        }
    }
    }
