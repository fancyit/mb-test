using Xunit;

namespace ShapesArea.XUnitTest
{
    public class TriangleTest
    {
        [Fact]
        public void Test1()
        {
            Triangle t = new Triangle(2, 3, 4);
            Assert.Equal("2,90473", t.GetArea().ToString());
        }
        [Fact]
        public void TestAreFromNegativeNum()
        {
            Triangle t = new Triangle(2, 3, -4);
            Assert.Equal("-1", t.GetArea().ToString());
        }
    }
}
