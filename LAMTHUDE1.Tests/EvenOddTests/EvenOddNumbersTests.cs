using LAMTHUDE1.EvenOdd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMTHUDE1.Tests.EvenOddTests
{
    [TestFixture]
    public class EvenOddNumbersTests
    
    {
        private EvenOddNumbers _e; 
        
        [SetUp]
        public void Setup()
        {
            _e = new EvenOddNumbers();
        }

        [Test]
        public void EvenOdd_PositiveEven_ReturnsChẵn()
        {
            Assert.AreEqual("Chẵn", _e.EvenOdd(2));
        }

        [Test]
        public void so0travechan()
        {
                       Assert.AreEqual("Chẵn", _e.EvenOdd(0));
        }
        [Test]
        public void travesole()
        {
            Assert.AreEqual("Lẻ", _e.EvenOdd(1));
        }

        [Test]
        public void soamtravesochan()
        {
            Assert.AreEqual("Chẵn", _e.EvenOdd(-4));
        }

        [Test]
        public void soamtravesoLE()
        {
            Assert.AreEqual("Lẻ", _e.EvenOdd(-3));
        }
    }
}
