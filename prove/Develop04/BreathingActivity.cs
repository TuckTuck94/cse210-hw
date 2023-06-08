public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void RunActivity()
    {
        var startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < Duration)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(3000); // Pause for 3 seconds
            Console.WriteLine("Breathe out...");
            Thread.Sleep(3000); // Pause for 3 seconds
        }
    }
}