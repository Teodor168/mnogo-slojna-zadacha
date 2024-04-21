namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.ID = 1;
            account.Deposit(15);
            account.WithDraw(5);

            account.Print();
        }
    }
}
