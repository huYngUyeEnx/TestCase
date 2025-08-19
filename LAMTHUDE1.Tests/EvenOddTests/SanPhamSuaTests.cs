using LAMTHUDE1.EvenOdd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMTHUDE1.Tests.EvenOddTests
{
    [TestFixture]
    public class SanPhamSuaTests
    {
        private SanPhamService _service;
    
        [SetUp]
        public void Setup()
        {
            //Tạo đối tượng kiểu  SanPhamService và gán cho _service sử dụng để test

            _service = new SanPhamService(new List<SanPham>
            {
                new SanPham(){ma = "SP1", ten = "A", namBaoHanh= 2025, gia = 10, soLuong = 10},
                new SanPham(){ma = "SP2", ten = "B", namBaoHanh= 2025, gia = 10, soLuong = 10}
            });
        }

        [Test] public void Sua_MaTonTai_True() 
            => Assert.IsTrue(_service.SuaSanPham("SP1", "New", 2025, 1, 1, "DM"));
        [Test] public void Sua_MaKhongTonTai_False() 
            => Assert.IsFalse(_service.SuaSanPham("SP99", "New", 2025, 1, 1, "DM"));
        [Test] public void Sua_MaNull_False() 
            => Assert.IsFalse(_service.SuaSanPham(null, "New", 2025, 1, 1, "DM"));
        [Test] public void Sua_MaRong_False() 
            => Assert.IsFalse(_service.SuaSanPham("", "New", 2025, 1, 1, "DM"));
        [Test] public void Sua_MaKhacHoaThuong_False() 
            => Assert.IsFalse(_service.SuaSanPham("sp01", "New", 2025, 1, 1, "DM"));




    }
}
