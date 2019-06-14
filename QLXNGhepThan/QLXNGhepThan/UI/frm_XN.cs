using QLXNGhepThan.UI;
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
using Microsoft.Office;
using Microsoft.Office.Interop.Excel;
using System.Threading;

namespace QLXNGhepThan
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        Form1 f1;
        public String tenBN;
        public Form2(Form1 frm1)
        {
            InitializeComponent();
            ToolTip tip = new ToolTip();
            tip.SetToolTip(btExportExcel, "Xuất danh sách ra file Excel");
            this.f1 = frm1;
            this.Text = f1.tenBN;
            tenBN = f1.tenBN;
            AutoClickFristCell();
        }

        public int key;
        public int maBN;
        public int IDLoaiXN;
        public String tenXN;
        public String maXN;
        public String ketQua;
        public String ngayXN;
        public String ghiChu;
        public String stt;
        public String hanXN;
        public int soLan;



        private void Form2_Load(object sender, EventArgs e)
        {
            Reload();
            DgvDefine();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.MediumBlue;
            dataGridView1.EnableHeadersVisualStyles = false;

            CheckStatus();
            AutoClickFristCell();
        }

        public void Reload()
        {
            key = int.Parse(f1.tbID.Text.Trim());
            List<XetNghiem> xetNghiems = new XetNghiemBUL().TimXN(key);
            dataGridView1.DataSource = xetNghiems;
            DgvDefine();
            CheckStatus();
            CheckHan();      
        }

        public void AutoClickFristCell()
        {
            maBN = Convert.ToInt32(f1.tbID.Text);
        }

        public void DgvDefine()
        {
            dataGridView1.Columns[1].HeaderText = "Loại xét nghiệm";
            dataGridView1.Columns[2].HeaderText = "Ngày xét nghiệm";
            dataGridView1.Columns[3].HeaderText = "Kết quả";
            dataGridView1.Columns[9].HeaderText = "Thời hạn";
            dataGridView1.Columns[6].HeaderText = "Trạng thái";
            dataGridView1.Columns[8].HeaderText = "Lần xét nghiệm thứ";

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;

            dataGridView1.Columns[8].Width = 100;

            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        

        public void CheckStatus()
        {
            //try
            //{
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[6].Value.ToString().Contains("Không đạt"))
                        row.Cells[6].Style.ForeColor = Color.Red;
                    else if (row.Cells[6].Value.ToString().Contains("Thông qua"))
                        row.Cells[6].Style.ForeColor = Color.Green;
                    else if (row.Cells[6].Value.ToString().Contains("Chưa có kết quả"))
                        row.Cells[6].Style.ForeColor = Color.Orange;
                }
            //}
            //catch
            //{ }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int n = dataGridView1.CurrentRow.Index;
                maXN = dataGridView1.Rows[n].Cells[0].Value.ToString();
                tenXN = dataGridView1.Rows[n].Cells[1].Value.ToString();
                ketQua = dataGridView1.Rows[n].Cells[3].Value.ToString();
                ngayXN = dataGridView1.Rows[n].Cells[2].Value.ToString();
                ghiChu = dataGridView1.Rows[n].Cells[4].Value.ToString();
                stt = dataGridView1.Rows[n].Cells[6].Value.ToString();
                IDLoaiXN = Convert.ToInt32(dataGridView1.Rows[n].Cells[7].Value.ToString());
                hanXN = dataGridView1.Rows[n].Cells[9].Value.ToString();
                soLan = Convert.ToInt32(dataGridView1.Rows[n].Cells[8].Value.ToString());
            }
            catch { }
        }




        private void btEditXN_Click(object sender, EventArgs e)
        {           
            frm_addXN f = new frm_addXN(this);
            f.ShowDialog();   
        }


        //------------Kiểm tra thời hạn của xét nghiệm---------Quá hạn (trên 30 ngày) yêu cầu làm lại xét nghiệm-----------------
        public void CheckHan()
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    //DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    DateTime hanXN = DateTime.ParseExact(row.Cells[9].Value.ToString(), "dd/MM/yyyy", null);
                    DateTime now = DateTime.UtcNow;
                    TimeSpan ngay = hanXN - now;
                    int tongngay = ngay.Days;
                    if (tongngay < 0)
                    {
                        row.Cells[9].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        row.Cells[9].Style.ForeColor = Color.Black;
                    }
                }
            }
            catch
            {

            }
        }
    
        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            CheckHan();
        }

        //============================ LỌC KẾT QUẢ XÉT NGHIỆM=================================
        private void cbLocXNPass_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cbLocXNPass.Checked == true)
            {
                cbChoketQua.Checked = false;
                cbLocXNfail.Checked = false;
                String key1 = "Thông qua";
                List<XetNghiem> xetNghiems = new XetNghiemBUL().LocXnDaThongQua(maBN, key1);
                dataGridView1.DataSource = xetNghiems;
                CheckStatus();
                CheckHan();
            }
            else
            {
                Reload();
            }
        }

        private void cbLocXNfail_CheckedChanged(object sender, EventArgs e)
        {
            if(cbLocXNfail.Checked == true)
            {
                cbChoketQua.Checked = false;
                cbLocXNPass.Checked = false;
                String key1 = "Không đạt";
                List<XetNghiem> xetNghiems = new XetNghiemBUL().LocXnThatBai(maBN, key1);
                dataGridView1.DataSource = xetNghiems;
                CheckStatus();
                CheckHan();
            }
            else
            {
                Reload();
            }
        }

        private void cbChoketQua_CheckedChanged(object sender, EventArgs e)
        {
            if (cbChoketQua.Checked == true)
            {
                cbLocXNPass.Checked = false;
                cbLocXNfail.Checked = false;
                String key1 = "Chưa có kết quả";
                List<XetNghiem> xetNghiems = new XetNghiemBUL().LocXnChoKetQua(maBN, key1);
                dataGridView1.DataSource = xetNghiems;
                CheckStatus();
                CheckHan();
            }
            else
            {
                Reload();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_UpdateXN f = new frm_UpdateXN(this);
            f.ShowDialog();
        }

        // TÌM XÉT NGHIỆM
        private void tbTimXN_TextChanged(object sender, EventArgs e)
        {
            String key = tbTimXN.Text.Trim();
            List<XetNghiem> xetNghiems = new XetNghiemBUL().TimXNCuaBN(maBN,key);
            dataGridView1.DataSource = xetNghiems;
            CheckHan();
            CheckStatus();
        }

        // XỬ LÝ XUẤT EXCEL---------------------------------------------------------------------------
        struct DataParameter
        {
            public List<XetNghiem> XetNghiemLists;
            public string FileName;
        }

        DataParameter _inputParameter;
  
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<XetNghiem> list = ((DataParameter)e.Argument).XetNghiemLists;
            string filename = ((DataParameter)e.Argument).FileName;
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)excel.ActiveSheet;
            excel.Visible = false;
            int index = 4;
            int process = list.Count;

            ws.Range["A1", "D1"].Merge();
            ws.Range["A1"].EntireRow.Font.Bold = true;
            ws.Cells[1, 1].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            ws.Cells[1, 1] = "PHIẾU KẾT QUẢ XÉT NGHIỆM";

            ws.Range["A2", "D2"].Merge();
            ws.Cells[2, 1].Font.Bold = true;
            ws.Cells[2, 1] = "Bệnh nhân: "+tenBN;

            ws.Cells[3, 1] = "Giới tính: "+f1.tbGioiTinh.Text;
            ws.Cells[3, 4] = "Năm sinh: " +f1.tbNamSinh.Text;

            ws.Range["A4"].EntireRow.Font.Bold = true;
            ws.Range["A4"].EntireRow.ColumnWidth = 18;
            ws.Range["A4"].EntireRow.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            ws.Range["A4", "D4"].Borders.LineStyle = XlLineStyle.xlContinuous;
            ws.Cells[4, 1] = "Xét nghiệm";
            ws.Cells[4, 2] = "Ngày xét nghiệm";
            ws.Cells[4, 3] = "Kết quả";
            ws.Cells[4, 4] = "Thời hạn";

            foreach (XetNghiem p in list)
            {
                if (!backgroundWorker1.CancellationPending)
                {
                    backgroundWorker1.ReportProgress(index++ * 100 / process);
                    ws.Cells[index, 1] = p.TenXN.ToString();
                    ws.Cells[index, 2] = p.NgayXN.ToString();
                    ws.Cells[index, 3] = p.KetQua.ToString();
                    ws.Cells[index, 4] = p.Thoihan.ToString();

                    ws.Cells[index, 1].EntireColumn.RowHeight = 20;              

                    ws.Cells[index, 1].EntireColumn.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    ws.Cells[index, 2].EntireColumn.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    ws.Cells[index, 3].EntireColumn.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    ws.Cells[index, 4].EntireColumn.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                    // Vẽ viền
                    ws.Cells[index, 1].Borders.LineStyle = XlLineStyle.xlContinuous;
                    ws.Cells[index, 2].Borders.LineStyle = XlLineStyle.xlContinuous;
                    ws.Cells[index, 3].Borders.LineStyle = XlLineStyle.xlContinuous;
                    ws.Cells[index, 4].Borders.LineStyle = XlLineStyle.xlContinuous;
                }
            }
            //ws.Cells.Columns.AutoFit();
            ws.SaveAs(filename, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
            excel.Quit();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                Thread.Sleep(100);
                lbStatus.Text = "Đã xuất file !";
            }
        }

        private void btExportExcel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
                return;
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook |*.xlsx" })
            {
                sfd.FileName = "PhieuXetNghiem_BN" + maBN + "_" + tenBN;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    _inputParameter.FileName = sfd.FileName;                    
                    _inputParameter.XetNghiemLists = dataGridView1.DataSource as List<XetNghiem>;                   
                    backgroundWorker1.RunWorkerAsync(_inputParameter);
                }
            }
        }

        private void dataGridView1_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            e.ToolTipText = "Nhấp đúp chuột để xem thông tin xét nghiệm !";
        }
    }
}
