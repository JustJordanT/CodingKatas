using System.Collections;
using CodingKata.BankAccount;

namespace CodingKata.BankAccount.Texts;

public class BankAccountTests
{
    [Fact]
    public void BankAccountSuccessfulCreation()
    {
        // Arrange
        var accountHolder = new AccountHolder(
            "Jane",
            "Doe",
            "jane.doe@example.com",
            "999-888-7777",
            "1234 Main Street");

        var bankAccount = new BankAccount(
            "jane's personal account",
            accountHolder,
            AccountType.personal,
            50);
        
        Assert.Equal("personal", AccountType.personal.ToString());
        Assert.Equal(50, bankAccount.GetAccountBalance());
    }  
    
    [Fact]
    public void BankAccountDepositWasSuccessful()
    {
        // Arrange
        var accountHolder = new AccountHolder(
            "Jane",
            "Doe",
            "jane.doe@example.com",
            "999-888-7777",
            "1234 Main Street");

        var bankAccount = new BankAccount(
            "jane's personal account",
            accountHolder,
            AccountType.personal,
            50);
        
        bankAccount.Deposit(500, "Weekly deposit");
        
        Assert.Equal(550, bankAccount.GetAccountBalance());
    }
    
    [Fact]
    public void BankAccountWithdrawWasSuccessful()
    {
        // Arrange
        var accountHolder = new AccountHolder(
            "Jane",
            "Doe",
            "jane.doe@example.com",
            "999-888-7777",
            "1234 Main Street");

        var bankAccount = new BankAccount(
            "jane's personal account",
            accountHolder,
            AccountType.personal,
            50);
        
        bankAccount.Deposit(500, "Weekly deposit");
        bankAccount.Withdraw(50, "Going out!");
        
        Assert.Equal(500, bankAccount.GetAccountBalance());
    }
}