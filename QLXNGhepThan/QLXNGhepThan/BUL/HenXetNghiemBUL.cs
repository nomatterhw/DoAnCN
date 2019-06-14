using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXNGhepThan.BLL
{
    class HenXetNghiemBUL
    {
        public List<BenhNhan> Tim(String key)
        {
            List<BenhNhan> benhNhans = new DAL().Search(key);
            return benhNhans;
        }

        public bool AddHenXN(HenXN bn)
        {
            bool result = new DAL().AddHen(bn);
            return result;
        }

        public List<HenXN> LayDanhSachHenTheoNgay(String key)
        {
            List<HenXN> henXNs = new DAL().GetDanhSachHenXNTheoNgay(key);
            return henXNs;
        }

        public List<HenXN> TimHenTheoTen(String key)
        {
            List<HenXN> henXNs = new DAL().TimHenTheoTen(key);
            return henXNs;
        }

        public bool XoaHen(int id)
        {
            bool result = new DAL().XoaLichHen(id);
            return result;
        }
    }
}
