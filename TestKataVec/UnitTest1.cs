using KataVA;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestKA
{
    [TestClass]
    public class UnitTest1
    {
        [Fact]
        public void ValidateMagnitude()
        {
            Vector vec = new Vector(4, 4);
            Assert.AreEqual(5.656854249492381, vec.Magnitude());
        }
        [Fact]
        public void ValidateDotProduct()
        {
            Vector VecA = new Vector(4, 4);
            Vector VecB = new Vector(4, 4);
            Assert.AreEqual(32, VecA.DotProduct(VecA, VecB));
        }
        [Fact]
        public void ValidateAngleBetween()
        {
            Vector VecA = new Vector(1, 2);
            Vector VecB = new Vector(4, 2);
            Assert.AreEqual(28.6624203821656, VecA.AngleBetween(VecA, VecB));

        }

    }
}
