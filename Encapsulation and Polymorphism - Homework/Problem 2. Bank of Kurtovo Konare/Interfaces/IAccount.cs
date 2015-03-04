namespace BankOfKurtovoKonare
{
    interface IAccount
    {
        decimal Balance { get; }
        decimal InterestRate { get; }
        Customer Customer { get; }

        decimal GetInterest(int months);
    }
}
