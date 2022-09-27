// See https://aka.ms/new-console-template for more information
using ShapeBridgeExample;

Console.WriteLine("Hello, Bridge Pattern !");


Shape redCircle = new Circle(100, 100, 10, new RedCircle());
Shape greenCircle = new Circle(100, 100, 10, new GreenCircle());

redCircle.draw();
greenCircle.draw();