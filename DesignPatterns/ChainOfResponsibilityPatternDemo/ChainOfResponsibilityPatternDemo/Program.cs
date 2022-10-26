// See https://aka.ms/new-console-template for more information
using ChainOfResponsibilityPatternDemo;

Console.WriteLine("Hello, Chain of Responsibility Pattern!");

static AbstractLogger getChainOfLoggers()
{

    AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
    AbstractLogger fileLogger = new FileLogger(AbstractLogger.DEBUG);
    AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.INFO);

    errorLogger.setNextLogger(fileLogger);
    fileLogger.setNextLogger(consoleLogger);

    return errorLogger;
}

AbstractLogger loggerChain = getChainOfLoggers();

loggerChain.logMessage(AbstractLogger.INFO,
   "This is an information.");

loggerChain.logMessage(AbstractLogger.DEBUG,
   "This is an debug level information.");

loggerChain.logMessage(AbstractLogger.ERROR,
   "This is an error information.");