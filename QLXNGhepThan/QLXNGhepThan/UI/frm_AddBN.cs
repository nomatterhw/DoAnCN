using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLXNGhepThan.BLL;

namespace QLXNGhepThan
{
    public partial class frm_add : MetroFramework.Forms.MetroForm
    {
        private readonly Form1 frm1;
        public frm_add(Form1 frm)
        {
            InitializeComponent();
            frm1 = frm;
        }


        private void btADD_Click(object sender, EventArgs e)
        {
            try
            {
                int namsinh=0;
                String sdt = "";
                if (tbNamSinh.Text != "")
                {
                    namsinh = int.Parse(tbNamSinh.Text.Trim());
                }
                String name = tbName.Text.Trim();
                String gioitinh = cbbGioiTinh.SelectedItem.ToString();
                String ngayXN = DateTime.Now.ToString("dd/MM/yyyy");
                if (Regex.IsMatch(tbSDT.Text.Trim(), @"^\d+$") && tbNamSinh.Text != "")
                {
                    sdt = tbSDT.Text.Trim();
                    BenhNhan bn = new BenhNhan() { TenBN = name, NamSinh = namsinh, GioiTinh = gioitinh, SDT = sdt, NgayXN = ngayXN };
                    bool result = new BenhNhanBUL().Them(bn);
                    if (result)
                    {
                        MessageBox.Show("Thêm thành công");
                        Form1 frm = new Form1();
                        frm1.Reload();
                    }
                    else
                        MessageBox.Show("Thêm thất bại");
                }
                else
                {
                    MessageBox.Show("Số điện thoại không hợp lệ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
