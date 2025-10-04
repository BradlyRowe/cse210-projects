public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.Write("Get Ready... ");
        PauseWithSpinner(5);
    }

    public void End()
    {
        Console.WriteLine("Well done!!");
        PauseWithSpinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        PauseWithSpinner(5);
    }

    protected void PauseWithSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("-");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Thread.Sleep(100);
            Console.Write("\\");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Thread.Sleep(100);
            Console.Write("|");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Thread.Sleep(100);
            Console.Write("/");
            Thread.Sleep(100);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public abstract void Run();
}
