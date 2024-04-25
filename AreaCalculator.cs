using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapresRUs
{
    /// <summary>
    /// Implementation of the IAreaCalculator interface to calculate the area of any shape.
    /// </summary>
    internal class AreaCalculator : IAreaCalculator
    {
        /// <summary>
        /// Method to calculate the area of a given shape.
        /// </summary>
        /// <param name="shape"></param>
        /// <returns></returns>
        public double CalculateArea(IShape shape)
        {
            // Delegate the calculation to the CalculateArea method of the provided shape.
            return shape.CalculateArea();
        }
    }
}
