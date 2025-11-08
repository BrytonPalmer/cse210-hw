public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What made you smile today?",
        "Describe a challenge you overcame recently.",
        "What are you grateful for today?",
        "Write about a moment of peace you experienced.",
        "What’s something new you learned?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}
     