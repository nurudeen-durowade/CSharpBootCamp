using System;

class Program
{
    static void Main(string[] args)
    {
       //Area of a Circle
       double radius = 2.50;
       double area = Math.PI * radius * radius;

       Console.WriteLine($"The area of a circle with radius {radius}cm is: {area}cm²");
       // why not decimal? Because Math.PI is a double, so the result will be a double. If you want to use decimal, you would need to cast Math.PI to decimal, but that would lose precision.

    }   

}
