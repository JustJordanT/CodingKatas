namespace CodingKata.BankAccount;

public record AccountHolder(string FirstName, string LastName, string Email, string Phone, string Address)
{
    private Guid Id { get; init; } = Guid.NewGuid();
}