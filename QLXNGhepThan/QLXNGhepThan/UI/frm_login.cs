using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXNGhepThan.UI
{
    public partial class frm_login : MetroFramework.Forms.MetroForm
    {
        public string StrConn = "Data Source=DESKTOP-HB480T7;Initial Catalog=QLGhepThan;Integrated Security=True";
        SqlDataAdapter da;
        DataTable dt;
        public frm_login()
        {
            InitializeComponent();
            txt_email.Focus();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //string login1 = "select * from Account where SDT = '" + txt_email.Text.Trim() + "' and MatKhau = '" + txt_password.Text.Trim() + "'";
            string login1 = "select * from Account where Email = '" + txt_email.Text.Trim() + "'or SDT ='" + txt_email.Text.Trim() + "' and MatKhau = '" + txt_password.Text.Trim() + "'";
            da = new SqlDataAdapter(login1, StrConn);   
            dt = new DataTable();
            da.Fill(dt);
            Save();
            if (dt.Rows.Count == 1)
            {
                Form1 mf = new Form1();
                this.Hide();
                mf.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ!!! \n Vui lòng nhập lại tài khoản");
                txt_email.Text = "";
                txt_password.Text = "";
            }
        }
        void Save()
        {
            if (checkBox_remember.Checked == true)
            {
                Properties.Settings.Default.username = txt_email.Text;
                Properties.Settings.Default.password = txt_password.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.Save();

            }
        }
        void load()
        {
            if (Properties.Settings.Default.username != string.Empty)
            {
                txt_email.Text = Properties.Settings.Default.username;
                txt_password.Text = Properties.Settings.Default.password;
                checkBox_remember.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình không ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_register signin = new frm_register();
            signin.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
