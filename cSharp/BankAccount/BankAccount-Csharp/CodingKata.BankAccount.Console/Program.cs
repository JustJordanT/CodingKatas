// See https://aka.ms/new-console-template for more information


using CodingKata.BankAccount;

var customer_1 = new AccountHolder(
    "Jordan",
    "Taylor",
    "jordan@mybank.com",
    "888-888-8888",
    "123 Main Street");

var customer_2 = new AccountHolder(
    "Nova",
    "Taylor",
    "Nova@mybank.com",
    "888-888-8888",
    "123 Main Street");

Console.Write(customer_2);
Console.WriteLine();

var account1 = new BankAccount("jordan's - personal account", customer_1, AccountType.personal, 25);

Console.WriteLine(account1.GetAccountBalance());

Console.WriteLine(account1.Deposit(100, "initial deposit"));

Console.WriteLine(account1.AccountDetails());
// Console.WriteLine(account1.Balance);