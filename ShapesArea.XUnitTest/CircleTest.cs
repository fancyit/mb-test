using Xunit;

namespace ShapesArea.XUnitTest
{
    public class CircleTest
    {
        [Fact]
        public void Test1()
        {
            Circle c = new Circle(5);
            Assert.Equal("78,53981", c.GetArea().ToString());            
        }
        [Fact]
        public void TestGetAreaFromNegativeNumber()
        {
            Circle c = new Circle(-5);
            Assert.Equal("-1", c.GetArea().ToString());
        }
    }
}
