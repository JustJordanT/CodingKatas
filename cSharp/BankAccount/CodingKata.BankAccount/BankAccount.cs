using CodingKata.BankAccount.Console.Services;
using Serilog;

namespace CodingKata.BankAccount;

public class BankAccount
{
    private readonly LoggerService _loggerService;
    
    // public BankAccount(LoggerService loggerService)
    // {
    // }
    
    private decimal _initialDeposit;

    public BankAccount()
    {
        AccountNumber = new Guid();
    }

    public BankAccount(
        LoggerService loggerService,
        string accountName,
        AccountHolder? accountHolder,
        AccountType accountType,
        decimal initialDeposit)
    {
        _loggerService = loggerService ?? throw new ArgumentNullException(nameof(loggerService));
        AccountName = accountName;
        AccountHolder = accountHolder;
        AccountType = accountType;
        InitialDeposit = initialDeposit;
    } 
    public BankAccount(
        string accountName,
        AccountHolder? accountHolder,
        AccountType accountType,
        decimal initialDeposit)
    {
        AccountName = accountName;
        AccountHolder = accountHolder;
        AccountType = accountType;
        InitialDeposit = initialDeposit;
    }

    private Guid AccountNumber { get; set; } = Guid.NewGuid();
    private string AccountName { get; set; } = string.Empty;
    private AccountHolder? AccountHolder { get; set; }
    private AccountType AccountType { get; set; }
    private decimal InitialDeposit {
        get => _initialDeposit;
        set {
            if (_initialDeposit <= 25)
            {
                _initialDeposit = value;
                AccountBalance += InitialDeposit;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Initial Deposit must at least 25$");
            }
        }
    }
    private decimal AccountBalance { get; set; }
    
    public string Deposit(decimal amount, string description)
    {
        AccountBalance += amount;
        // TODO add this to a log file. adding date time and  description to log file.
        _loggerService.Deposit($"{AccountAction.Deposit}: ({amount}) - has been successfully deposited into account {AccountNumber} - {description}");
        return $"{amount} - has been successfully deposited into account {AccountNumber}";
    }
    public string Withdraw(decimal amount, string description)
    {
        AccountBalance -= amount;
        _loggerService.Withdraw($"{AccountAction.Withdrawal}: ({amount}) - has been successfully withdrawn from account {AccountNumber} - {description}");
        return $"{amount} - has been successfully withdrawn from account - {AccountNumber}"; 
    }
    public void GetTransactions(decimal amount)
    {
        AccountBalance += amount;
        // TODO add this to a log file. adding date time and  description to log file.
    }

    public decimal GetAccountBalance() => AccountBalance; 

    public string AccountDetails()
    {
        string details = $$"""
        Account Number: {{AccountNumber}}
        Account Name: {{AccountName}}
        Account Holder: {{AccountHolder.FirstName + ", " + AccountHolder.LastName}}
        Account Type: {{AccountType}}
        Account Balance: {{AccountBalance}}
        """;
        return details;
    }
}