using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{
    public class Ellipse : IShape
    {
        public double centerX, centerY, r1, r2, orientation, _area, _perimeter, _centroidX, _centroidY;

        public Ellipse(int _id, double centerX, double centerY, double r1, double r2, double orientation)
        {
            this.Id = _id;
            this.centerX = centerX;
            this.centerY = centerY;
            this.r1 = r1;
            this.r2 = r2;
            this.orientation = orientation;
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
                this._area = Math.PI * this.r1 * this.r2;
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
                this._perimeter = Math.PI * (3 * (this.r1 + this.r2) - Math.Sqrt(((3 * this.r1) + this.r2) * (this.r1 + (3 * this.r2))));
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
                this._centroidX = (this.centerX * Math.Cos(this.orientation)) - (this.centerY * Math.Sin(this.orientation));
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
                this._centroidY = (this.centerY * Math.Cos(this.orientation)) + (this.centerX * Math.Sin(this.orientation));
            }
        }
    }
}
