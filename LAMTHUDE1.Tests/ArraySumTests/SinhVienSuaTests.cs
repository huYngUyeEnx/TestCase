using LAMTHUDE1.ArraySum;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace LAMTHUDE1.Tests;
[TestFixture]
public class SinhVienSuaTests
{
    SinhVienService _svc;

    [SetUp]
    public void S() => _svc = new(new()
    {
        new(){ MaSV="SV01", Ten="An", Tuoi=20, DiemTrungBinh=7, KyHoc=3, ChuyenNganh="CNTT" }
    });

    [Test]
    public void Sua_Valid_Updated()
    {
        Assert.IsTrue(_svc.Sua("SV01", "Binh", 21, 8, 4, "KTPM"));
        Assert.AreEqual("Binh", _svc.GetAll().First(x => x.MaSV == "SV01").Ten);
    }

    [Test]
    public void Sua_KhongTonTai_False()
        => Assert.IsFalse(_svc.Sua("SV99", "A", 20, 7, 3, "CNTT"));

    [Test]
    public void Sua_MaNull_False()
        => Assert.IsFalse(_svc.Sua(null, "A", 20, 7, 3, "CNTT"));

    [Test]
    public void Sua_TenRong_False()
        => Assert.IsFalse(_svc.Sua("SV01", "", 20, 7, 3, "CNTT"));

    [Test]
    public void Sua_ChuyenNganhSpace_False()
        => Assert.IsFalse(_svc.Sua("SV01", "A", 20, 7, 3, "   "));
}
