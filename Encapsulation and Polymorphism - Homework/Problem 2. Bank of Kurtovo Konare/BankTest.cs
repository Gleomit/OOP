namespace BankOfKurtovoKonare
{
    using System;

    public class BankTest
    {
        public static void Main()
        {
            Individual temp = new Individual();
            DepositAccount account = new DepositAccount(10, 5, temp);
            Console.WriteLine(account.Balance);
            account.Withdraw(3.4m);
            account.Deposit(10000);
            Console.WriteLine(account.Balance);
            Console.ReadKey();
        }
    }
}
