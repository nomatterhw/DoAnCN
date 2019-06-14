using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXNGhepThan.BLL
{
    class XetNghiemBUL
    {
        public bool ThemXN(XetNghiem xn)
        {
            bool result = new DAL().AddXN(xn);
            return result;
        }

        public List<XetNghiem> TimXN(int key)
        {
            List<XetNghiem> xetNghiems = new DAL().GetXN(key);
            return xetNghiems;
        }



        public bool UpdateXN(String id, XetNghiem xn)
        {
            bool result = new DAL().UpdateXN(id, xn);
            return result;
        }

        public List<XetNghiem> TimXNCuaBN(int id, String key)
        {
            List<XetNghiem> xetNghiems = new DAL().TimXN(id, key);
            return xetNghiems;
        }


        // Bộ lộc xét nghiệm-----------------------

        public List<XetNghiem> LocXnDaThongQua(int id, String key)
        {
            List<XetNghiem> xetNghiems = new DAL().LocXnThanhCong(id, key);
            return xetNghiems;
        }

        public List<XetNghiem> LocXnThatBai(int id, String key)
        {
            List<XetNghiem> xetNghiems = new DAL().LocXnThatBai(id, key);
            return xetNghiems;
        }

        public List<XetNghiem> LocXnChoKetQua(int id, String key)
        {
            List<XetNghiem> xetNghiems = new DAL().LocXnChoKetQua(id, key);
            return xetNghiems;
        }
    }
}
