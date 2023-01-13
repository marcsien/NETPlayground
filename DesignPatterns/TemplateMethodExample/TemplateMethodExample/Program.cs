// See https://aka.ms/new-console-template for more information
using TemplateMethodExample;

Console.WriteLine("Hello, Template Method!");



Game game = new Cricket();
game.play();
Console.WriteLine();
game = new Football();
game.play();