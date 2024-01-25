namespace Logger;

public abstract class BaseLogger
{
    public string? ClassName
    {
        get;
        set;
    }
    //environment.getcurrentdirectory
    public abstract void Log(LogLevel logLevel, string message);
}

