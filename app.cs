namespace AreaCalculator
{
    class AreaCalculator
    {
        // Method to calculate the area of a circle
        static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius; // Area = π * r²
        }

        // Method to calculate the area of a triangle
        static double CalculateTriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height; // Area = 1/2 * base * height
        }

        // Method to calculate the area of a rectangle
        static double CalculateRectangleArea(double length, double width)
        {
            return length * width; // Area = length * width
        }

        // Method to calculate the area of a square
        static double CalculateSquareArea(double side)
        {
            return side * side; // Area = side²
        }

        static void Main(string[] args)
        {
            // Get user input for the circle area
            Console.Write("Enter the radius of the circle: ");
            double circleRadius = Convert.ToDouble(Console.ReadLine());
            double circleArea = CalculateCircleArea(circleRadius);
            Console.WriteLine($"The area of the circle is: {circleArea}");

            // Get user input for the triangle area
            Console.Write("Enter the base length of the triangle: ");
            double triangleBase = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the height of the triangle: ");
            double triangleHeight = Convert.ToDouble(Console.ReadLine());
            double triangleArea = CalculateTriangleArea(triangleBase, triangleHeight);
            Console.WriteLine($"The area of the triangle is: {triangleArea}");

            // Get user input for the rectangle area
            Console.Write("Enter the length of the rectangle: ");
            double rectangleLength = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the width of the rectangle: ");
            double rectangleWidth = Convert.ToDouble(Console.ReadLine());
            double rectangleArea = CalculateRectangleArea(rectangleLength, rectangleWidth);
            Console.WriteLine($"The area of the rectangle is: {rectangleArea}");

            // Get user input for the square area
            Console.Write("Enter the side length of the square: ");
            double squareSide = Convert.ToDouble(Console.ReadLine());
            double squareArea = CalculateSquareArea(squareSide);
            Console.WriteLine($"The area of the square is: {squareArea}");

            // BONUS: Prompt the user to choose a shape
            Console.WriteLine("Choose a shape to calculate its area (circle, triangle, rectangle, square):");
            string shapeChoice = Console.ReadLine().ToLower();

            switch (shapeChoice)
            {
                case "circle":
                    Console.Write("Enter the radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Area of circle: {CalculateCircleArea(radius)}");
                    break;
                case "triangle":
                    Console.Write("Enter the base length: ");
                    double baseLength = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the height: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Area of triangle: {CalculateTriangleArea(baseLength, height)}");
                    break;
                case "rectangle":
                    Console.Write("Enter the length: ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the width: ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Area of rectangle: {CalculateRectangleArea(length, width)}");
                    break;
                case "square":
                    Console.Write("Enter the side length: ");
                    double side = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Area of square: {CalculateSquareArea(side)}");
                    break;
                default:
                    Console.WriteLine("Invalid shape choice.");
                    break;
            }


        }
    }
}
