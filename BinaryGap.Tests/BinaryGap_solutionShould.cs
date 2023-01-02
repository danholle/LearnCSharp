using NUnit.Framework;
using BinaryGap;

namespace BinaryGap.Tests
{
    [TestFixture]
    public class BinaryGap_solutionShould
    {
        private Solution _s;

        [SetUp]
        public void Setup()
        {
            _s = new Solution();
        }

        [Test]
        
        [TestCase(0b000000, 0)]
        [TestCase(0b000001, 0)]
        [TestCase(0b000010, 0)]
        [TestCase(0b000011, 0)]
        [TestCase(0b000111, 0)]
        [TestCase(0b1111111111111111111111111111111, 0)]
        [TestCase(0b100000, 0)]
        [TestCase(0b110000, 0)]
        [TestCase(0b111000, 0)]
        [TestCase(0b011100, 0)]
        [TestCase(0b001110, 0)]
        
        [TestCase(0b000101, 1)]
        [TestCase(0b001011, 1)]
        [TestCase(0b011010, 1)]
        [TestCase(0b101100, 1)]
        [TestCase(0b010111, 1)]
        [TestCase(0b1111111111111011111111111111111, 1)]
        [TestCase(0b101010, 1)]

        [TestCase(0b1000000000000000000000000000001, 29)]
        [TestCase(0b1001, 2)]
        [TestCase(0b1000101, 3)]
        [TestCase(0b101100001011, 4)]
        
        public void Test(int bits, int ans)
        {
            Assert.IsTrue(_s.solution(bits)==ans);
        }
    }
}
