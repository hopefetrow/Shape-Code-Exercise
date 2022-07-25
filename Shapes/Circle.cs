using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes {
    /// Circle class
    public class Circle : IShape {
        public double centerX, centerY, radius, _area, _perimeter, _centroidX, _centroidY;

        /// Constructor
        public Circle (int id, double centerX, double centerY, double radius) {
            this.Id = id;
            this.centerX = centerX;
            this.centerY = centerY;
            this.radius = radius;
        }

        // Getter/setter for ID
        public int Id {
            get; set;
        }

        // Getter/setter for area
        public double Area {
            get
            {
                return this._area;
            }
            set
            {
                this._area = Math.PI * ( this.radius * this.radius );
            }
        }

        // Getter/setter for perimeter 
        public double Perimeter {
            get
            {
                return this._perimeter;
            }
            set
            {
                this._perimeter = 2 * Math.PI * this.radius;
            }
        }

        // Getter/setter for x-value of centroid
        public double CentroidX {
            get
            {
                return this._centroidX;
            }
            set
            {
                this._centroidX = this.centerX;
            }
        }

        // Getter/setter for y-value of centroid 
        public double CentroidY {
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