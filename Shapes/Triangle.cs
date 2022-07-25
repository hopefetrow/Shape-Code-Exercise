using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{

    // Triangle class 
    class Triangle : IShape
    {
        public double centerX, centerY, sideLength, orientation, _area, _perimeter, _centroidX, _centroidY;

        // Constructor 
        public Triangle(int _id, double centerX, double centerY, double sideLength, double orientation)
        {
            this.Id = _id;
            this.centerX = centerX;
            this.centerY = centerY;
            this.sideLength = sideLength;
            this.orientation = orientation;
        }

        // Getter/setter for ID
        public int Id
        {
            get; set;
        }

        // Getter/setter for area
        public double Area
        {
            get
            {
                return this._area;
            }
            set
            {
                this._area = .5 * this.sideLength * ((Math.Pow(3, .5) * this.sideLength) / 2);
            }
        }

        // Getter/setter for perimeter
        public double Perimeter
        {
            get
            {
                return this._perimeter;
            }
            set
            {
                this._perimeter = this.sideLength * 3;
            }
        }

        // Getter/setter for x-value of centroid
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

        // Getter/setter for y-value of centroid 
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
