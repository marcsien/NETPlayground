// See https://aka.ms/new-console-template for more information
using VisitorComputerPartsExample;

Console.WriteLine("Hello, Visitor!");

IComputerPart computer = new Computer();
computer.accept(new ComputerPartDisplayVisitor());