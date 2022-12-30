using System.Collections;
using CodingKata.BankAccount;

namespace CodingKata.BankAccount.Texts;

public class AccountHolderTests
{
    
    public static IEnumerable<object[]> AccountHolderMethod()
    {
        return new List<object[]>()
        {
            new object[]
            {
                new AccountHolder(
                    "John",
                    "Doe",
                    "john@doe.com",
                    "888-888-8888",
                    "123 Main Street"),
                new AccountHolder(
                    "Jane",
                    "Doe",
                    "jane@doe.com",
                    "999-999-9999",
                    "123 Main Street")
            },
        };
    }


    [Theory]
    [MemberData(nameof(AccountHolderMethod))]
    public void AccountHolderHasAllProps(AccountHolder holder1, AccountHolder holder2)
    {
        // Holder 1
        Assert.Equal("John", holder1.FirstName);
        Assert.Equal("Doe", holder1.LastName);
        Assert.Equal("john@doe.com", holder1.Email);
        Assert.Equal("888-888-8888", holder1.Phone);
        Assert.Equal("123 Main Street", holder1.Address);
        
        // Holder 2
        Assert.Equal("Jane", holder2.FirstName);
        Assert.Equal("Doe", holder2.LastName);
        Assert.Equal("jane@doe.com", holder2.Email);
        Assert.Equal("999-999-9999", holder2.Phone);
        Assert.Equal("123 Main Street", holder2.Address);
    }
}
