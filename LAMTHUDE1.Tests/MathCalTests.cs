using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LAMTHUDE1;

namespace LAMTHUDE1.Tests
{
    public class MathCalTests
    {
        private MathCal _m;

        [SetUp]
        public void Setup()
        {
            _m = new MathCal();
        }

        // TC1: n = -5 → return 0 (ngoài miền hợp lệ)
        [Test]
        public void SumOddNumber_NegativeInput_Returns0()
        {
            Assert.AreEqual(0, _m.SumOddNumber(-5));
        }

        // TC2: n = 0 → return 0
        [Test]
        public void SumOddNumber_ZeroInput_Returns0()
        {
            Assert.AreEqual(0, _m.SumOddNumber(0));
        }

        // TC3: n = 1 → return 1
        [Test]
        public void SumOddNumber_Input1_Returns1()
        {
            Assert.AreEqual(1, _m.SumOddNumber(1));
        }

        // TC4: n = 5 → return 9 (1 + 3 + 5)
        [Test]
        public void SumOddNumber_Input5_Returns9()
        {
            Assert.AreEqual(9, _m.SumOddNumber(5));
        }

        // TC5: n = 6 → return 9 (1 + 3 + 5)
        [Test]
        public void SumOddNumber_Input6_Returns9()
        {
            Assert.AreEqual(9, _m.SumOddNumber(6));
        }
    }
}
