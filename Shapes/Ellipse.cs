using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{

    /// Ellipse class 
    public class Ellipse : IShape
    {
        public double centerX, centerY, r1, r2, orientation, _area, _perimeter, _centroidX, _centroidY;

        /// Constructor 
        public Ellipse(int _id, double centerX, double centerY, double r1, double r2, double orientation)
        {
            this.Id = _id;
            this.centerX = centerX;
            this.centerY = centerY;
            this.r1 = r1;
            this.r2 = r2;
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
                this._area = Math.PI * this.r1 * this.r2;
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
                //this._perimeter = (2 * Math.PI) * Math.Sqrt((Math.Pow(this.r1, 2) + Math.Pow(this.r2, 2)) / 2);

                this._perimeter = Math.PI * (3 * (this.r1 + this.r2) - Math.Sqrt(((3 * this.r1) + this.r2) * (this.r1 + (3 * this.r2))));

                // this._perimeter = Math.PI * (this.r1 + this.r2) * (3 * ((Math.Pow((this.r1 - this.r2), 2)) / (Math.Pow((this.r1 + this.r2), 2) * (Math.Sqrt(-3 * (Math.Pow((this.r1 - this.r2), 2) / Math.Pow((this.r1 + this.r2), 2)) + 4) + 10)) + 1));
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
