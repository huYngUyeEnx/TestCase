using LAMTHUDE1.SumOdd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMTHUDE1.Tests.SumOddTests
{
    [TestFixture]
    public class SanPhamServiceTest
    {
        private SanPhamService _service;
       
        [SetUp]
        public void Setup()
        {
            //Tạo đối tượng kiểu  SanPhamService và gán cho _service sử dụng để test

            _service = new SanPhamService(new List<SanPham>
            {
                new SanPham(){Ma = "SP1", Ten = "A", NamBaoHanh= 2025, Gia = 10, SoLuong = 10},
                new SanPham(){Ma = "SP2", Ten = "B", NamBaoHanh= 2025, Gia = 10, SoLuong = 10}
            });
        }

        [Test]
        public void Xoa_MaKhongTonTai_Flase() => Assert.IsTrue(!_service.XoaSanPham("SP3"));
        
        [Test]
        public void Xoa_MaTonTai_True() => Assert.IsTrue(_service.XoaSanPham("SP1"));
       
        [Test]
        public void Xoa_MaRong_False() => Assert.IsFalse(_service.XoaSanPham(""));
       
        [Test]
        public void Xoa_MaNull_() => Assert.IsFalse(_service.XoaSanPham(""));
       
        [Test]
        public void Xoa_XoaThanhCong_KhongConTrongDS()
        {
            _service.XoaSanPham("SP1");
            Assert.IsNull(_service.GetAll().Find(sp => sp.Ma == "SP1"));
        }
    }
}
