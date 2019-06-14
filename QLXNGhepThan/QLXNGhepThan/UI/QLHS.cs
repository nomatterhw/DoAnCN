using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXNGhepThan.UI
{
    public partial class QLHS : Form
    {
        public QLHS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_KeNgan frmHenXN = new frm_KeNgan();
            frmHenXN.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_DSVB vb = new frm_DSVB();
            vb.ShowDialog();
        }
    }
}
