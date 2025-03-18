

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator(List<string> prompts)
    {
        _prompts = prompts;
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        return randomPrompt;
    }
}