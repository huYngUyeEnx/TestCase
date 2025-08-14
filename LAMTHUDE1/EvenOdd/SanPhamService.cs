using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMTHUDE1.EvenOdd
{
    public class SanPhamService
    {
        private readonly List<SanPham> _ds;

        public SanPhamService(List<SanPham> ds)
        {
            _ds = ds ?? new();
        }

        public bool SuaSanPham(string ma, string ten, int namBaoHanh, float gia, int soLuong, string danhMuc)
        {
            if (string.IsNullOrWhiteSpace(ma)) return false;

            var sp = _ds.FirstOrDefault(x => x.ma == ma);
            if (sp == null) return false;

            sp.ten = ten;
            sp.namBaoHanh = namBaoHanh;
            sp.gia = gia;
            sp.soLuong = soLuong;
            sp.danhMuc = danhMuc;
            return true;
        }

    }
}
