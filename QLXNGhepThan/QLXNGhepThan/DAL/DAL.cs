using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXNGhepThan
{
    class DAL
    {
        public string StrConn = "Data Source=DESKTOP-HB480T7;Initial Catalog=QLGhepThan;Integrated Security=True";
        // public string StrConn = "workstation id=QLGhepThan2.mssql.somee.com;packet size=4096;user id=datnguyen1406_SQLLogin_1;pwd=6548diq3ip;data source=QLGhepThan2.mssql.somee.com;persist security info=False;initial catalog=QLGhepThan2";
        private DBDataContext db = new DBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);


        //---Xử lý thông tin bệnh nhân
        public List<BenhNhan> GetAll()
        {
            List<BenhNhan> benhNhans = db.BenhNhans.ToList<BenhNhan>();
            return benhNhans;
        }

        public bool Add(BenhNhan bn)
        {
            try
            {
                db.BenhNhans.InsertOnSubmit(bn);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool Delete(int id)
        {
            BenhNhan bns = db.BenhNhans.Where(x => x.MaBN == id).SingleOrDefault();
            db.BenhNhans.DeleteOnSubmit(bns);
            if (db.HenXNs.FirstOrDefault(n => n.MaBN == bns.MaBN) != null)
            {
                db.HenXNs.DeleteOnSubmit(db.HenXNs.FirstOrDefault(n => n.MaBN == bns.MaBN));
            }
            if (db.XetNghiems.FirstOrDefault(n => n.MaBN == bns.MaBN) != null)
            {
                db.XetNghiems.Where(n => n.MaBN == bns.MaBN).ToList().ForEach(bn =>
                {
                    db.XetNghiems.DeleteOnSubmit(bn);

                });
            }

            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool Update(int id, BenhNhan bn)
        {

            BenhNhan bns = db.BenhNhans.Where(x => x.MaBN == id).SingleOrDefault();
            bns.MaBN = bn.MaBN;
            bns.TenBN = bn.TenBN;
            bns.NamSinh = bn.NamSinh;
            bns.GioiTinh = bn.GioiTinh;
            bns.SDT = bn.SDT;
            bns.NgayXN = bn.NgayXN;
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            { return false; }
            return true;
        }

        public List<BenhNhan> Search(String key)
        {
            List<BenhNhan> benhNhans = db.BenhNhans.Where(x => x.TenBN.Contains(key)).ToList<BenhNhan>();
            return benhNhans;
        }


        //---Xử lý hẹn khám xét nghiệm
        public bool AddHen(HenXN bn)
        {
            try
            {
                db.HenXNs.InsertOnSubmit(bn);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public List<HenXN> GetDanhSachHenXNTheoNgay(String key)
        {
            List<HenXN> henXNs = db.HenXNs.Where(x => x.NgayXN.Contains(key)).ToList<HenXN>();
            return henXNs;
        }

        public List<HenXN> TimHenTheoTen(String key)
        {
            List<HenXN> henXNs = db.HenXNs.Where(x => x.TenBN.Contains(key)).ToList<HenXN>();
            return henXNs;
        }

        public bool XoaLichHen(int id) // Xóa lịch hẹn sau khi thêm XN
        {
            HenXN hen = db.HenXNs.Where(x => x.ID == id).SingleOrDefault();
            db.HenXNs.DeleteOnSubmit(hen);
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            { return false; }
            return true;
        }


        //---Danh mục loại xét nghiệm
        public List<LoaiXetNghiem> GetDanhMucXN()
        {
            List<LoaiXetNghiem> loaiXetNghiems = db.LoaiXetNghiems.ToList<LoaiXetNghiem>();
            return loaiXetNghiems;
        }

        public bool AddLoaiXN(LoaiXetNghiem lxn)
        {
            try
            {
                db.LoaiXetNghiems.InsertOnSubmit(lxn);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }


        public bool UpdateLoaiXN(int id, LoaiXetNghiem lxn)
        {

            LoaiXetNghiem loaiXetNghiem = db.LoaiXetNghiems.Where(x => x.IDLoaiXN == id).SingleOrDefault();
            loaiXetNghiem.TenXN = lxn.TenXN;
            loaiXetNghiem.ThoiHan = lxn.ThoiHan;
            loaiXetNghiem.Note = lxn.Note;          
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            { return false; }
            return true;
        }



        //---Xử lý thông tin xét nghiệm của bệnh nhân
        public bool AddXN(XetNghiem xn)
        {
            try
            {
                db.XetNghiems.InsertOnSubmit(xn);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public List<XetNghiem> GetXN(int key)// Lấy danh sách xét nghiệm của bệnh nhân
        {
            List<XetNghiem> xetNghiems = db.XetNghiems.Where(x => x.MaBN == key).OrderBy(x=>x.TenXN).ToList<XetNghiem>();
            return xetNghiems;
        }

        public bool UpdateXN(String id, XetNghiem xn)
        {

            XetNghiem xns = db.XetNghiems.Where(x => x.ID == id).SingleOrDefault();
            xns.NgayXN = xn.NgayXN;
            xns.TenXN = xn.TenXN;
            xns.KetQua = xn.KetQua;
            xns.Note = xn.Note;
            xns.Status = xn.Status;
            xns.Thoihan = xn.Thoihan;
            xns.Image = xn.Image;
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            { return false; }
            return true;
        }

        public List<XetNghiem> TimXN(int id, String key)// Lọc XN đã thất bại
        {
            List<XetNghiem> xetNghiems = db.XetNghiems.Where(x => (x.MaBN == id) && (x.TenXN.Contains(key))).OrderBy(x => x.IDLoaiXN).ToList<XetNghiem>();
            return xetNghiems;
        }

        //---Bộ lọc xét nghiệm

        
        public List<XetNghiem> LocXnThanhCong(int id, String key)// Lọc XN đã thông qua
        {
            List<XetNghiem> xetNghiems = db.XetNghiems.Where(x => (x.MaBN == id) && (x.Status.Contains(key))).OrderBy(x => x.IDLoaiXN).ToList<XetNghiem>();
            return xetNghiems;
        }

        public List<XetNghiem> LocXnThatBai(int id, String key)// Lọc XN đã thất bại
        {
            List<XetNghiem> xetNghiems = db.XetNghiems.Where(x => (x.MaBN == id) && (x.Status.Contains(key))).OrderBy(x => x.IDLoaiXN).ToList<XetNghiem>();
            return xetNghiems;
        }

        public List<XetNghiem> LocXnChoKetQua(int id, String key)// Lọc XN đã thất bại
        {
            List<XetNghiem> xetNghiems = db.XetNghiems.Where(x => (x.MaBN == id) && (x.Status.Contains(key))).OrderBy(x => x.IDLoaiXN).ToList<XetNghiem>();
            return xetNghiems;
        }
    }
}
