using System.Security.Authentication.ExtendedProtection;
using Microsoft.Extensions.DependencyInjection;

namespace ShapresRUs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Setup DI container
            // Create a service collection to register dependencies.
            var serviceProvider = new ServiceCollection()
                // Register ICircle, specifying its implementation as Circle and its lifetime as transient (new instance createde each time it is requested).
                .AddTransient<ICircle, Circle>()
                // Register IRectangle, specifying its implementation as Rectangle and its lifetime as transient (new instance createde each time it is requested).
                .AddTransient<IRectangle, Rectangle>()
                // Register IAreaCalculator, specifying its implementation as AreaCalculator and its lifetime as transient (new instance createde each time it is requested).
                .AddTransient<IAreaCalculator, AreaCalculator>()
                // Build the service provider.
                .BuildServiceProvider();

            // Resolve services
            // Retrieve instances of ICircle, IRectangle, and IAreaCalculator from the service provider.
            var circle = serviceProvider.GetService<ICircle>();
            circle.Radius = 5;

            var rectangle = serviceProvider.GetService<IRectangle>();
            rectangle.Width = 4;
            rectangle.Height = 6;

            var areaCalculator = serviceProvider.GetService<IAreaCalculator>();

            // Calculate and print areas
            // Calculate and print the area of the circle using the areaCalculator service.
            Console.WriteLine("Area of circle: " + areaCalculator.CalculateArea(circle));
            // Calculate and print the area of the rectangle using the areaCalculator service.
            Console.WriteLine("Area of rectangle: " + areaCalculator.CalculateArea(rectangle));
        }
    }
}
