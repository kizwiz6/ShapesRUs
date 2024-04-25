using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapresRUs
{
    /// <summary>
    /// IMplementation of the IRectangle interface representing a rectangle shape.
    /// </summary>
    internal class Rectangle : IRectangle
    {
        // Width property of the rectangle.
        public double Width { get; set; }
        // Height property of the rectangle.
        public double Height { get; set; }

        /// <summary>
        /// Method to calculate the area of the rectangle.
        /// </summary>
        /// <returns></returns>
        public double CalculateArea()
        {
            // Using the formula: width * height to calculate the area.
            return Width * Height;
        }
    }
}
