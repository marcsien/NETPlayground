// See https://aka.ms/new-console-template for more information
using MementoExample;

Console.WriteLine("Hello, Memento!");


Originator originator = new Originator();
CareTaker careTaker = new CareTaker();

originator.setState("State #1");
originator.setState("State #2");
careTaker.add(originator.saveStateToMemento());

originator.setState("State #3");
careTaker.add(originator.saveStateToMemento());

originator.setState("State #4");
Console.WriteLine("Current State: " + originator.getState());

originator.getStateFromMemento(careTaker.get(0));
Console.WriteLine("First saved State: " + originator.getState());
originator.getStateFromMemento(careTaker.get(1));
Console.WriteLine("Second saved State: " + originator.getState());