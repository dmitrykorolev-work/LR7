namespace LR7E2;

internal class Program
{
    static void Main(string[] args)
    {
        var terminal = new BankTerminal();
        terminal.OnMoneyWithdraw += amount => Console.WriteLine($"You have withdrawn {amount}.");


        terminal.Withdraw(100); // Output: You have withdrawn 100.

        /*
        // The event 'BankTerminal.OnMoneyWithdraw' can only appear on the left hand side of += or -= (except when used from within the type 'BankTerminal')
        terminal.OnMoneyWithdraw?.Invoke(1000000); // Triggering an event manually without an operation
        terminal.OnMoneyWithdraw = null; // Unsubscribe all handlers
        */

        terminal.Withdraw(200);


    }
}
