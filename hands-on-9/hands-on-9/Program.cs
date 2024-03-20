using hands_on_9;

public enum LogLevel
{
    Comment,
    Warning,
    Error
}


public class SingletonLogger
{
    private static SingletonLogger instance;

    protected SingletonLogger()
    {
        
    }

    public static SingletonLogger Instance()
    {
        if (instance == null)
        {
            instance = new SingletonLogger();
        }

        return instance;
    }

    public void Log(LogLevel logLevel, string message)
    {
        switch (logLevel)
        {
            case LogLevel.Comment:
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(message);
                break;
            case LogLevel.Warning:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(message);
                break;
            case LogLevel.Error:
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(message);
                Environment.Exit(0);
                break;
        }
    }
    
    
}

public class StaticLogger
{
    public static void Log(LogLevel logLevel, string message)
    {
        switch (logLevel)
        {
            case LogLevel.Comment:
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(message);
                break;
            case LogLevel.Warning:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(message);
                break;
            case LogLevel.Error:
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(message);
                Environment.Exit(0);
                break;
        }
    }
}

public class Program
{

    public static void Main(string[] args)
    {
        // **** Animal Factory *****
        IAnimal Dog = AnimalFactory.Create(AnimalType.Dog);
        Dog.Speak();
        
        IAnimal Cat = AnimalFactory.Create(AnimalType.Cat);
        Cat.Speak();
        
        
        // **** Singleton Logger ****
        SingletonLogger logger = SingletonLogger.Instance();
        
        logger.Log(LogLevel.Comment, "This is a comment - SingletonLogger");
        logger.Log(LogLevel.Warning, "This is a warning - SingletonLogger");
        // logger.Log(LogLevel.Error, "This is an error - SingletonLogger");
        // logger.Log(LogLevel.Error, "This should not execute, we just logged an error above");
        
        // **** Static Logger ****
        StaticLogger.Log(LogLevel.Comment, "This is a comment - StaticLogger");
        StaticLogger.Log(LogLevel.Warning, "This is a warning - StaticLogger");
        StaticLogger.Log(LogLevel.Error, "This is an error - StaticLogger");
        
        StaticLogger.Log(LogLevel.Error, "This should not execute, we just logged an error above");
    }
}