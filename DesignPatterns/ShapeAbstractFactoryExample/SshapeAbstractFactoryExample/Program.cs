// See https://aka.ms/new-console-template for more information
using ShapeAbstractFactoryExample;

Console.WriteLine("Hello, ShapeAbstractFactory!");



AbstractShapeFactory shapeFactory = ShapeFactoryProducer.getFactory(false);
IShape shape1 = shapeFactory.GetShape("RECTANGLE");
shape1.Draw();
IShape shape2 = shapeFactory.GetShape("SQUARE");
shape2.Draw();


AbstractShapeFactory shapeFactory1 = ShapeFactoryProducer.getFactory(true);
IShape shape3 = shapeFactory1.GetShape("RECTANGLE");
shape3.Draw();
IShape shape4 = shapeFactory1.GetShape("SQUARE");
shape4.Draw();