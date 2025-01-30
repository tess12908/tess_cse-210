
public class Prompt 
{
    public List<string> _prompts;
    public Random rnd;

    public void Prompt_Dict()
    {
        _prompts = new List<string>()
        {
            "Imagine it is 10 years from now. Where are you, what are you doing, and how does your life look?",
            "Write about the little things in life that consistently bring you happiness.",
            "Choose a specific age or moment in your life and write a letter to yourself during that time.",
            "Reflect on a recent dream. What emotions did it evoke, and what might it reveal about your current mindset?",
            "Describe what a perfect day would look like from morning to night—no limits, just pure joy."
        };
        //rnd = new Random();
    }

    public string Display()
    {
        Prompt_Dict(); 
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count); 
        return _prompts[index];  
    } 
}
