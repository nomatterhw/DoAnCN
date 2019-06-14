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
    public partial class frm_ShowImage : MetroFramework.Forms.MetroForm
    {
        Form2 f2;
        public frm_ShowImage(Form2 frm2)
        {
            InitializeComponent();
            this.f2 = frm2;
            this.Text = "Bệnh nhân: " + f2.tenBN;
        }
    }
}
