using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{
    public interface IShape
    {

        public int Id
        {
            get; set;
        }

        public double Area
        {
            get; set;
        }

        public double Perimeter
        {
            get; set;
        }

        public double CentroidX
        {
            get; set;
        }

        public double CentroidY
        {
            get; set;
        }
    }
}
