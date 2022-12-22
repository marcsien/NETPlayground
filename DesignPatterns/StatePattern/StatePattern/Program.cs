// See https://aka.ms/new-console-template for more information
using StatePattern;

Console.WriteLine("Hello, State pattern!");


Context context = new Context();

StartState startState = new StartState();
startState.doAction(context);

Console.WriteLine(context.getState().toString());

StopState stopState = new StopState();
stopState.doAction(context);

Console.WriteLine(context.getState().toString());