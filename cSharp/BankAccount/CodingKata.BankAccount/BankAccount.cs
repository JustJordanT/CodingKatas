namespace CodingKata.BankAccount;

public class BankAccount
{
    private decimal _initialDeposit;

    public BankAccount()
    {
        AccountNumber = new Guid();
    }

    public BankAccount(
        string accountName,
        AccountHolder accountHolder,
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
    private AccountHolder AccountHolder { get; set; }
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
        Console.WriteLine(description);
        // TODO add this to a log file. adding date time and  description to log file.
        return $"{amount} - has been successfully deposited into account {AccountNumber}";
    }
    public void Withdraw(decimal amount, string description)
    {
        AccountBalance += amount;
        // TODO add this to a log file. adding date time and  description to log file.
    }
    public void GetTransactions(decimal amount)
    {
        AccountBalance += amount;
        // TODO add this to a log file. adding date time and  description to log file.
    }

    public string GetAccountBalance() => $"Current Balance: {AccountBalance}";

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