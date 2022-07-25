using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{

    public class Circle : IShape
    {
        public double centerX, centerY, radius, _area, _perimeter, _centroidX, _centroidY;

        public Circle(int id, double centerX, double centerY, double radius)
        {
            this.Id = id;
            this.centerX = centerX;
            this.centerY = centerY;
            this.radius = radius;
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
                this._area = Math.PI * (this.radius * this.radius);
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
                this._perimeter = 2 * Math.PI * this.radius;
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
                this._centroidX = this.centerX;
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
                this._centroidY = this.centerY;
            }
        }
    }
}