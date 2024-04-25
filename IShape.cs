using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapresRUs
{
    /// <summary>
    /// Interface defining the contract for any shape.
    /// </summary>
    internal interface IShape
    {
        /// <summary>
        /// Method to return the area of the shape.
        /// </summary>
        /// <returns></returns>
        double CalculateArea();
    }
}
