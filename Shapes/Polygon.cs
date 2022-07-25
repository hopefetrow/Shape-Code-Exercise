using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{
    public class Polygon : IShape
    {
        public List<List<double>> vertices;
        public double _area, _perimeter, _centroidX, _centroidY;

        public Polygon(int _id, List<List<double>> vertices)
        {
            this.Id = _id;
            this.vertices = vertices;
        }

        public int Id
        {
            get; set;
        }

        public double Area
        {
            get
            {
                return this._area;
            }
            set
            {
                for (int row = 0; row < vertices.Count - 1; row++)
                {
                    for (int col = 0; col < vertices[row].Count - 1; col++)
                    {
                        this._area += ((this.vertices[row][col] * this.vertices[row + 1][col + 1]) - (this.vertices[row][col + 1] * this.vertices[row + 1][col]));
                    }
                }
                this._area = _area / 2;
            }
        }

        public double Perimeter
        {
            get
            {
                return this._perimeter;
            }
            set
            {
                double _perimeter = 0.0;
                for (int row = 0; row < vertices.Count - 1; row++)
                {
                    for (int col = 0; col < vertices[row].Count - 1; col++)
                    {
                        this._perimeter += Math.Sqrt(
                             (Math.Pow(vertices[row][col] - vertices[row + 1][col], 2)
                             + Math.Pow(vertices[row][col + 1] - vertices[row + 1][col + 1], 2)));
                    }
                }
            }
        }

        public double CentroidX
        {
            get
            {
                return this._centroidX;
            }
            set
            {
                for (int row = 0; row < vertices.Count - 1; row++)
                {
                    for (int col = 0; col < vertices[row].Count - 1; col++)
                    {
                        this._centroidX += ((this.vertices[row][col]
                             + this.vertices[row + 1][col])
                             * ((this.vertices[row][col] * this.vertices[row + 1][col + 1]) - (this.vertices[row + 1][col] * this.vertices[row][col + 1])));
                    }
                }
                this._centroidX = (1 / (6 * this.Area)) * this._centroidX;
            }
        }

        public double CentroidY
        {
            get
            {
                return this._centroidY;
            }
            set
            {
                for (int row = 0; row < vertices.Count - 1; row++)
                {
                    for (int col = 0; col < vertices[row].Count - 1; col++)
                    {
                        this._centroidY += ((this.vertices[row][col + 1]
                             + this.vertices[row + 1][col + 1])
                             * ((this.vertices[row][col] * this.vertices[row + 1][col + 1]) - (this.vertices[row + 1][col] * this.vertices[row][col + 1])));
                    }
                }
                this._centroidY = (1 / (6 * this.Area)) * this._centroidY;
            }
        }
    }
}
