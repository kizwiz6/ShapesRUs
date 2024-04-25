using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapresRUs
{
    /// <summary>
    /// Interface defining the contract for a circle shape.
    /// </summary>
    internal interface ICircle : IShape
    {
        /// <summary>
        /// Radius property of the circle.
        /// </summary>
        public double Radius { get; set; }
    }
}
