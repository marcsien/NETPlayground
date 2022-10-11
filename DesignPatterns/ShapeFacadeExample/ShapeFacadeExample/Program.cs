// See https://aka.ms/new-console-template for more information
using ShapeFacadeExample;

Console.WriteLine("Hello, Facade Pattern !");

ShapeMakerFacade shapeMaker = new ShapeMakerFacade();

shapeMaker.drawCircle();
shapeMaker.drawRectangle();
shapeMaker.drawSquare();