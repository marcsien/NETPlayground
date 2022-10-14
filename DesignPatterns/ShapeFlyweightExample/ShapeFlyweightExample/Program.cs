// See https://aka.ms/new-console-template for more information
using ShapeFlyweightExample;

Console.WriteLine("Hello, Flyweight Shape Pattern demo !");


string[] colors = new string[5] { "Red", "Green", "Blue", "White", "Black" };



for (int i = 0; i < 20; ++i)
{
    Circle circle = (Circle)ShapeFactory.GetCircle(getRandomColor());
    circle.setX(getRandomX());
    circle.setY(getRandomY());
    circle.setRadius(100);
    circle.Draw();
}




string getRandomColor()
{
    Random rnd = new Random();
    return colors[(int)(rnd.Next(1,colors.Length))];
}

int getRandomX()
{
    Random rnd = new Random();
    return (int)(rnd.Next(1,100));
}

int getRandomY()
{
    Random rnd = new Random();
    return (int)(rnd.Next(1, 100));
}