using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMTHUDE1.ArraySum
{
    public class SinhVienService
    {
        private readonly List<SinhVien> _ds;

        public SinhVienService(List<SinhVien> ds)
        {
            _ds = ds ?? new();
        }

        public bool Sua(string maSV, string ten, int tuoi, float diemTrungBinh, int kyHoc, string chuyenNganh)
        {
            if (string.IsNullOrWhiteSpace(maSV)) return false;
            var sv = _ds.FirstOrDefault(x => x.MaSV == maSV);
            if (sv == null) return false;
            sv.Ten = ten;
            sv.Tuoi = tuoi;
            sv.DiemTrungBinh = diemTrungBinh;
            sv.KyHoc = kyHoc;
            sv.ChuyenNganh = chuyenNganh;
            return true;
        }
    }
}
