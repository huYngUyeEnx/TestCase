using LAMTHUDE1.ArraySum;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMTHUDE1.Tests.ArraySumTests
{
    [TestFixture]
    public class ArraySumMathTests
    {
        [Test] public void Sum_Empty_Returns0() => Assert.AreEqual(0, ArraySumMath.Sum(System.Array.Empty<int>()));
        [Test] public void Sum_Single_ReturnsElement() => Assert.AreEqual(5, ArraySumMath.Sum(new[] { 5 }));
        // BVA: mảng null
        [Test] public void Sum_Null_Returns0() => Assert.AreEqual(0, ArraySumMath.Sum(null));

        // EP: toàn dương
        [Test] public void Sum_AllPositive() => Assert.AreEqual(6, ArraySumMath.Sum(new[] { 1, 2, 3 }));
        // EP: toàn âm
        [Test] public void Sum_AllNegative() => Assert.AreEqual(-6, ArraySumMath.Sum(new[] { -1, -2, -3 }));
        // EP: trộn dấu
        [Test] public void Sum_MixedSigns() => Assert.AreEqual(0, ArraySumMath.Sum(new[] { -2, -1, 1, 2 }));

    }
}
