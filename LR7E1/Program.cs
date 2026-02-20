namespace LR7E1;

internal class Program
{
    static void Main(string[] args)
    {
        List<Action> actions = new();

        for (int i = 1; i <= 5; i++)
        {
            //actions.Add( () => Console.WriteLine(i) );

            int localI = i; // Capture the current value of i
            actions.Add( () => Console.WriteLine(localI) ); // Use the local variable in the lambda expression
        }

        foreach (var action in actions)
        {
            action();
        }
    }
}
