// See https://aka.ms/new-console-template for more information
using ShapeDecoratorExample;

Console.WriteLine("Hello, Shape Decorator Example!");

IShape circle = new Circle();

IShape redCircle = new RedShapeDecorator(new Circle());

IShape redRectangle = new RedShapeDecorator(new Rectangle());
Console.WriteLine("Circle with normal border");
circle.Draw();

Console.WriteLine("\nCircle of red border");
redCircle.Draw();

Console.WriteLine("\nRectangle of red border");
redRectangle.Draw();