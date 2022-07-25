using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{

    public class Square : IShape
    {
        public double centerX, centerY, sideLength, orientation, _area, _perimeter, _centroidX, _centroidY;

        public Square(int _id, double centerX, double centerY, double sideLength, double orientation)
        {
            this.Id = _id;
            this.centerX = centerX;
            this.centerY = centerY;
            this.sideLength = sideLength;
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
                this._area = this.sideLength * this.sideLength;
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
                this._perimeter = sideLength * 4;
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
