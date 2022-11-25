// See https://aka.ms/new-console-template for more information
using ChatMediatorExample;

Console.WriteLine("Hello, Mediator");


User robert = new User("Robert");
User john = new User("John");

robert.sendMessage("Hi! John!");
john.sendMessage("Hello! Robert!");