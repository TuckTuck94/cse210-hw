public class ListingActivity : Activity
{
    private string[] prompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        // Add more prompts here...
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void RunActivity()
    {
        var random = new Random();
        var prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);

        var startTime = DateTime.Now;
        int itemCount = 0;
        while ((DateTime.Now - startTime).TotalSeconds < Duration)
        {
            Console.Write("List an item: ");
            var item =Console.ReadLine();
            itemCount++;
            Thread.Sleep(3000); // Pause for 3 seconds
        }

        Console.WriteLine($"You have listed {itemCount} items.");
    }
}