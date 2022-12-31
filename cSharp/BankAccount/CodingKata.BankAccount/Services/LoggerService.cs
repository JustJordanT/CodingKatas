using Serilog;
using Serilog.Sinks.SystemConsole.Themes;


namespace CodingKata.BankAccount.Console.Services;

public class LoggerService
{
    private readonly ILogger _logger;

    public LoggerService()
    {
        _logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File("logs/log.txt", outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level}] {Message}{NewLine}{Exception}")
            .CreateLogger();
    }
    
    public void Deposit(string message, params object[] args)
    {
        _logger.Information(message, args);
    }

    public void Withdraw(string message, params object[] args)
    {
        _logger.Information(message, args);
    }

    public void Warning(string message, params object[] args)
    {
        _logger.Warning(message, args);
    }
}