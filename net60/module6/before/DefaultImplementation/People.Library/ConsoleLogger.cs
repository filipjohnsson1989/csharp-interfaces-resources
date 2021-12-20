namespace People.Library;

public class ConsoleLogger : IPeopleLogger
{
    public void Log(PeopleLogLevel level, string message)
    {
        Console.WriteLine($"{DateTimeOffset.Now:T} - {level}: {message}");
    }

    public void LogException(Exception ex) => Log(PeopleLogLevel.Error, $"{DateTimeOffset.Now:T} -Error: {ex.Message}");
}
