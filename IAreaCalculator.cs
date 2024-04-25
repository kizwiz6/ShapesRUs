using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapresRUs
{
    /// <summary>
    /// Itnerface defining the contract for a service that calculates the area of a shape.
    /// </summary>
    internal interface IAreaCalculator
    {
        // Method to calculate the area of a given shape.
        double CalculateArea(IShape shape);
    }
}
