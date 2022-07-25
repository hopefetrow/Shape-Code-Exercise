
namespace ShapesTests;

public class UnitTest1
{

    /// Tests Area setter/getter for Triangle 
    [Fact]
    public void TestTriangleArea()
    {
        var shapeTester = new Shapes.Triangle(3, 431.063, 37.5185, 47.7961, 6.21924);
        shapeTester.Area = shapeTester.Area;
        Assert.Equal(989.2033, Math.Round(shapeTester.Area, 4));
    }

    /// Tests Perimeter setter/getter for Triangle 
    [Fact]
    public void TestTrianglePerimeter()
    {
        var shapeTester = new Shapes.Triangle(3, 431.063, 37.5185, 47.7961, 6.21924);
        shapeTester.Perimeter = shapeTester.Perimeter;
        Assert.Equal(143.3883, Math.Round(shapeTester.Perimeter, 4));
    }

    /// Tests Area setter/getter for Square 
    [Fact]
    public void TestSquareArea()
    {
        var shapeTester = new Shapes.Square(6, 174.317, 270.922, 1.65259, 3.22175);
        shapeTester.Area = shapeTester.Area;
        Assert.Equal(2.7311, Math.Round(shapeTester.Area, 4));
    }

    /// Tests Perimeter setter/getter for Square 
    [Fact]
    public void TestSquarePerimeter()
    {
        var shapeTester = new Shapes.Square(6, 174.317, 270.922, 1.65259, 3.22175);
        shapeTester.Perimeter = shapeTester.Perimeter;
        Assert.Equal(6.6104, Math.Round(shapeTester.Perimeter, 4));
    }

    /// Tests Area setter/getter for Circle 
    [Fact]
    public void TestCircleArea()
    {
        var shapeTester = new Shapes.Circle(1, 490.064, 36.3991, 75.7771);
        shapeTester.Area = shapeTester.Area;
        Assert.Equal(18039.5556, Math.Round(shapeTester.Area, 4));
    }

    /// Tests Perimeter setter/getter for Circle 
    [Fact]
    public void TestCirclePerimeter()
    {
        var shapeTester = new Shapes.Circle(1, 490.064, 36.3991, 75.7771);
        shapeTester.Perimeter = shapeTester.Perimeter;
        Assert.Equal(476.1216, Math.Round(shapeTester.Perimeter, 4));
    }

    /// Tests Area setter/getter for Ellipse 
    [Fact]
    public void TestEllipseArea()
    {
        var shapeTester = new Shapes.Ellipse(7, 161.34, 140.2391, 20.9523,
            6.58786, 2.44081);
        shapeTester.Area = shapeTester.Area;
        Assert.Equal(433.6366, Math.Round(shapeTester.Area, 4));
    }

    /// Tests Perimeter setter/getter for Ellipse 
    [Fact]
    public void TestEllipsePerimeter()
    {
        var shapeTester = new Shapes.Ellipse(7, 161.34, 140.2391, 20.9523,
            6.58786, 2.44081);
        shapeTester.Perimeter = shapeTester.Perimeter;
        Assert.Equal(92.51, Math.Round(shapeTester.Perimeter, 2));
    }

    /// Tests Area setter/getter for Polygon 
    [Fact]
    public void TestPolygonArea()
    {
        List<List<double>> vertices = new List<List<double>>();

        vertices.Add(new List<double>());
        vertices[0].Add(346.746);
        vertices[0].Add(51.165);
        vertices.Add(new List<double>());
        vertices[1].Add(413.75);
        vertices[1].Add(208.36);
        vertices.Add(new List<double>());
        vertices[2].Add(309.926);
        vertices[2].Add(280.286);
        vertices.Add(new List<double>());
        vertices[3].Add(34.4096);
        vertices[3].Add(297.813);
        vertices.Add(new List<double>());
        vertices[4].Add(346.746);
        vertices[4].Add(51.165);

        var shapeTester = new Shapes.Polygon(4, vertices);
        shapeTester.Area = shapeTester.Area;
        Assert.Equal(41810.596, Math.Round(shapeTester.Area, 3));
    }

    /// Tests Perimeter setter/getter for Polygon 
    [Fact]
    public void TestPolygonPerimeter()
    {
        List<List<double>> vertices = new List<List<double>>();

        vertices.Add(new List<double>());
        vertices[0].Add(346.746);
        vertices[0].Add(51.165);
        vertices.Add(new List<double>());
        vertices[1].Add(413.75);
        vertices[1].Add(208.36);
        vertices.Add(new List<double>());
        vertices[2].Add(309.926);
        vertices[2].Add(280.286);
        vertices.Add(new List<double>());
        vertices[3].Add(34.4096);
        vertices[3].Add(297.813);
        vertices.Add(new List<double>());
        vertices[4].Add(346.746);
        vertices[4].Add(51.165);

        var shapeTester = new Shapes.Polygon(4, vertices);
        shapeTester.Perimeter = shapeTester.Perimeter;
        Assert.Equal(971.239, Math.Round(shapeTester.Perimeter, 3));
    }

}
