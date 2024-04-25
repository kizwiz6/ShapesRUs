using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapresRUs
{
    /// <summary>
    /// Implementation of the ICircle interface representing a circle shape.
    /// </summary>
    internal class Circle : ICircle
    {
        // Radius property of the circle.
        public double Radius { get; set; }

        /// <summary>
        /// Method to calculate the area of the circle.
        /// </summary>
        /// <returns></returns>
        public double CalculateArea()
        {
            // Using the formula: π * r^2 to calculate the area.
            return Math.PI * Radius * Radius;
        }
    }
}
