public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") {}

    public override void Run()
    {
        Start();
        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            Countdown(4);
            Console.Write("Breathe out... ");
            Countdown(6);
            Console.WriteLine();
            elapsed += 10;
        }
        End();
    }
}
