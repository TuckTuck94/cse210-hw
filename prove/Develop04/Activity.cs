public abstract class Activity
{
    protected string Name;
    protected string Description;
    protected int Duration;

    public Activity(string name, string description)
    {
        this.Name = name;
        this.Description = description;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Starting {Name} activity. {Description}");
        Console.Write("Set the duration of the activity in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    public abstract void RunActivity();

    public void EndActivity()
    {
        Console.WriteLine("You have done a good job!");
        Thread.Sleep(3000); // Pause for 3 seconds
        Console.WriteLine($"You have completed {Name} activity for {Duration} seconds.");
        Thread.Sleep(3000); // Pause for 3 seconds
        Console.WriteLine("Mindfulness is a good thing for your mental health and physical wellbeing. Continue to come back to this program for your own personal benefit.");
    }
}