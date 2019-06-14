using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXNGhepThan.BLL
{
    class LoaiXetNghiemBUL
    {
        public List<LoaiXetNghiem> GetDanhMucXN()
        {
            List<LoaiXetNghiem> loaiXetNghiems = new DAL().GetDanhMucXN();
            return loaiXetNghiems;
        }

        public bool ThemLoaiXN(LoaiXetNghiem lxn)
        {
            bool result = new DAL().AddLoaiXN(lxn);
            return result;
        }

        public bool UpdateLoaiXN(int id, LoaiXetNghiem lxn)
        {
            bool result = new DAL().UpdateLoaiXN(id, lxn);
            return result;
        }
    }
}
