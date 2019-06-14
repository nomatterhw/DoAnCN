using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXNGhepThan.BLL
{
    class BenhNhanBUL
    {

        // Xử lý bệnh nhân
        public List<BenhNhan> GetAll()
        {
            List<BenhNhan> benhNhans = new DAL().GetAll();
            return benhNhans;
        }

        public bool Them(BenhNhan bn)
        {
            bool result = new DAL().Add(bn);
            return result;
        }

        public bool Sua(int id, BenhNhan bn)
        {
            bool result = new DAL().Update(id, bn);
            return result;
        }

        public List<BenhNhan> Tim(String key)
        {
            List<BenhNhan> benhNhans = new DAL().Search(key);
            return benhNhans;
        }
        public bool Delete(int id)
        {
            bool result = new DAL().Delete(id);
            return result;
        }
    }
}
