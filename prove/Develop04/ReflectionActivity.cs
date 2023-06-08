public class ReflectionActivity : Activity
{
    private string[] prompts = new string[]
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        // Add more prompts here...
    };

    private string[] questions = new string[]
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        // Add more questions here...
    };

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public override void RunActivity()
    {
        var random = new Random();
        var prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);

        var startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < Duration)
        {
            var question = questions[random.Next(questions.Length)];
            Console.WriteLine(question);
            Thread.Sleep(3000); // Pause for 3 seconds
        }
    }
}