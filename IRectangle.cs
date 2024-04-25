using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapresRUs
{
    /// <summary>
    /// Interface defining the contract for a rectangle shape.
    /// </summary>
    internal interface IRectangle : IShape
    {
        // Width property of the rectangle.
        public double Width { get; set; }
        // Height property of the rectangle.
        public double Height { get; set; }
    }
}
