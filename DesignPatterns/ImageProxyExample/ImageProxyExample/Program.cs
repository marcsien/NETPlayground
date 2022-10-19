// See https://aka.ms/new-console-template for more information
using ImageProxyExample;

Console.WriteLine("Hello, Image Proxy Example!");



IImage image = new ProxyImage("test_10mb.jpg");

//image will be loaded from disk
image.Display();
Console.WriteLine("");

//image will not be loaded from disk
image.Display();