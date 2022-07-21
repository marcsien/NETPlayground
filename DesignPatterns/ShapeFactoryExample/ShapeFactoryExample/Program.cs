// See https://aka.ms/new-console-template for more information
using ShapeFactoryExample;

Console.WriteLine("Hello, ShapeFactory !");

ShapeFactory shapeFactory = new ShapeFactory();

IShape shape1 = shapeFactory.GetShape("CIRCLE");
shape1.Draw();

IShape shape2 = shapeFactory.GetShape("RECTANGLE");
shape2.Draw();

IShape shape3 = shapeFactory.GetShape("SQUARE");
shape3.Draw();