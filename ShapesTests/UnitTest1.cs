
namespace ShapesTests;

public class UnitTest1 {

    /// Tests for Triangle Area setter/getter
    [Fact]
    public void TestTriangleArea () {
        var shapeTester = new Shapes.Triangle(0, 431.063, 37.5185, 47.7961, 6.21924);
        shapeTester.Area = shapeTester.Area;
        Assert.Equal(989.2033, Math.Round(shapeTester.Area, 4));
    }

    /// Tests for Triangle Perimeter setter/getter 
    [Fact]
    public void TestTrianglePerimeter () {
        var shapeTester = new Shapes.Triangle(3, 431.063, 37.5185, 47.7961, 6.21924);
        shapeTester.Perimeter = shapeTester.Perimeter;
        Assert.Equal(143.3883, Math.Round(shapeTester.Perimeter, 4));
    }

    /// Tests Square Area setter/getter 
    [Fact]
    public void TestSquareArea () {
        var shapeTester = new Shapes.Square(6, 174.317, 270.922, 1.65259, 3.22175);
        shapeTester.Area = shapeTester.Area;
        Assert.Equal(2.7311, Math.Round(shapeTester.Area, 4));
    }


    /// Tests Square Perimeter setter/getter 
    [Fact]
    public void TestSquarePerimeter () {
        var shapeTester = new Shapes.Square(6, 174.317, 270.922, 1.65259, 3.22175);
        shapeTester.Area = shapeTester.Area;
        Assert.Equal(2.7311, Math.Round(shapeTester.Area, 4));
    }
}
