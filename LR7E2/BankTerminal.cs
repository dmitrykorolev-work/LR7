namespace LR7E2;

internal class BankTerminal
{
    //internal Action<int> OnMoneyWithdraw;
    internal event Action<int> OnMoneyWithdraw;

    public void Withdraw(int amount)
    {
        Console.WriteLine($"Withdrawing {amount}");
        OnMoneyWithdraw?.Invoke(amount);
    }
}
