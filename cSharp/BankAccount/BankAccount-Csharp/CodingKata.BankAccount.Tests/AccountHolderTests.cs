namespace CodingKata.BankAccount.Texts;

public class AccountHolderTests
{
    [Fact]
    public void AccountHolderHasAllProps()
    {
        var accountHolder = new AccountHolder(
            "John",
            "Doe",
            "john@example.com",
            "555-555-5555",
            "123 Main Street");

        Assert.Equal("John", accountHolder.FirstName);
        Assert.Equal("Doe", accountHolder.LastName);
        Assert.Equal("john@example.com", accountHolder.Email);
        Assert.Equal("555-555-5555", accountHolder.Phone);
        Assert.Equal("123 Main Street", accountHolder.Address);
    }
}