using System.Text;

namespace Shapes
{
    class CodeChallenge
    {
        public static void Main()
        {
            // for working with shapes 
            List<IShape> shapes = new List<IShape>();
            Circle circle;
            Square square;
            Ellipse ellipse;
            Triangle triangle;
            Polygon polygon;
            // for reading from csv file 
            string line;
            string[] row;
            // open csv file 
            using var streamReader = File.OpenText("input/Machine Vision Development Engineer Coding Exercise _ ShapeList2.csv");

            /*
               1. Determine what shape is being read
               2. Create that shape
               3. Find shape area, perimeter, and centroid
               4. Add shape to list containing all shapes
            */
            while ((line = streamReader.ReadLine()) != null)
            {
                row = line.Split(",");
                switch (row[1])
                {

                    case "Circle":
                        // create new circle
                        circle = new Circle(
                            Convert.ToInt32(row[0]),
                            Convert.ToDouble(row[3]),
                            Convert.ToDouble(row[5]),
                            Convert.ToDouble(row[7])
                        );
                        // call setter/getters for properties 
                        circle.Area = circle.Area;
                        circle.Perimeter = circle.Perimeter;
                        circle.CentroidX = circle.CentroidX;
                        circle.CentroidY = circle.CentroidY;
                        // add to list of shapes 
                        shapes.Add(circle);
                        break;

                    case "Ellipse":
                        // create new ellipse, sending longer radius as primary radius 
                        ellipse = (Convert.ToDouble(row[7]) > Convert.ToDouble(row[9])) ?
                            new Ellipse(Convert.ToInt32(row[0]),
                                Convert.ToDouble(row[3]),
                                Convert.ToDouble(row[5]),
                                Convert.ToDouble(row[7]),
                                Convert.ToDouble(row[9]),
                                Convert.ToDouble(row[11]))
                       :
                            new Ellipse(Convert.ToInt32(row[0]),
                               Convert.ToDouble(row[3]),
                               Convert.ToDouble(row[5]),
                               Convert.ToDouble(row[9]),
                               Convert.ToDouble(row[7]),
                               Convert.ToDouble(row[11]));
                        // call setter/getters for properties 
                        ellipse.Area = ellipse.Area;
                        ellipse.Perimeter = ellipse.Perimeter;
                        ellipse.CentroidX = ellipse.CentroidX;
                        ellipse.CentroidY = ellipse.CentroidY;
                        // add to list of shapes 
                        shapes.Add(ellipse);
                        break;

                    case "Square":
                        square = new Square(
                            Convert.ToInt32(row[0]),
                            Convert.ToDouble(row[3]),
                            Convert.ToDouble(row[5]),
                            Convert.ToDouble(row[7]),
                            Convert.ToDouble(row[9]));
                        // call setter/getters for properties 
                        square.Area = square.Area;
                        square.Perimeter = square.Perimeter;
                        square.CentroidX = square.CentroidX;
                        square.CentroidY = square.CentroidY;
                        // add to list of shapes 
                        shapes.Add(square);
                        break;

                    case "Equilateral Triangle":
                        // create new triangle 
                        triangle = new Triangle(
                            Convert.ToInt32(row[0]),
                            Convert.ToDouble(row[3]),
                            Convert.ToDouble(row[5]),
                            Convert.ToDouble(row[7]),
                            Convert.ToDouble(row[9]));
                        // call setter/getters for properties 
                        triangle.Area = triangle.Area;
                        triangle.Perimeter = triangle.Perimeter;
                        triangle.CentroidX = triangle.CentroidX;
                        triangle.CentroidY = triangle.CentroidY;
                        // add to list of shapes 
                        shapes.Add(triangle);
                        break;

                    case "Polygon":
                        int i = 3;
                        int n = 0;
                        List<List<double>> vertices = new List<List<double>>();
                        // extract x,y coordinates from row 
                        while (i < row.Length - 3 && row[i].CompareTo("") != 0)
                        {
                            vertices.Add(new List<double>());
                            vertices[n].Add(Convert.ToDouble(row[i]));
                            vertices[n].Add(Convert.ToDouble(row[i + 2]));
                            i = i + 4;
                            n++;
                        }
                        // create new polygon 
                        polygon = new Polygon(Convert.ToInt32(row[0]), vertices);
                        // call setter/getters for properties 
                        polygon.Area = polygon.Area;
                        polygon.Perimeter = polygon.Perimeter;
                        polygon.CentroidX = polygon.CentroidX;
                        polygon.CentroidY = polygon.CentroidY;
                        // add to list of shapes 
                        shapes.Add(polygon);
                        break;
                }
            }


            // export data to csv 
            ExportData.ExportCsv(shapes, "output/Output Shape Properties.csv");
        }
    }

    /// <summary>
    /// Exports a list of IShape objects with their properties to a .csv file
    /// </summary>
    public static class ExportData
    {
        public static void ExportCsv<IShape>(List<IShape> shapes, string fileName)
        {
            var sb = new StringBuilder();
            var basePath = AppDomain.CurrentDomain.BaseDirectory;
            var info = typeof(IShape).GetProperties();

            if (!File.Exists(fileName))
            {
                TextWriter sw = new StreamWriter(fileName, true);
                sw.Write(sb.ToString());
                sw.Close();
            }
            foreach (IShape shape in shapes)
            {
                sb = new StringBuilder();
                var line = "";

                foreach (var prop in info)
                {
                    line += ((prop.Name).CompareTo("Id") == 0) ? prop.GetValue(shape, null) + ", " + shape.GetType().Name : ", " + prop.Name + ", " + prop.GetValue(shape, null);
                }
                Console.WriteLine(line);
                line = line.Substring(0, line.Length - 2);
                sb.AppendLine(line);
                TextWriter sw = new StreamWriter(fileName, true);
                sw.Write(sb.ToString());
                sw.Close();


            }
        }
    }
}