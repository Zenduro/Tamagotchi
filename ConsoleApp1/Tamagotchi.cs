
public class Tamagotchi
{
    private int hunger = 0;
    private int boredom = 0;
    private List<string> words = new List<string>() {"hej"};
    private bool isAlive;
    private Random generator;
    public string name;

    public Tamagotchi()
    {
        isAlive = true;
        generator = new Random();
    }

    public void Feed()
    {
        Console.WriteLine($" [{name}]Äter och blir mindre hungrig");
        hunger -= 2;
        if (hunger < 0)
        {
            hunger = 0;
        }
    }


    public void PrintStats()
    {
        Console.WriteLine($"Boredom: {this.boredom}");
        Console.WriteLine($"Hunger: {this.hunger}");

        if (isAlive == true)
        {
            Console.WriteLine($"You are Alive");
        }
        else
        {
            Console.WriteLine($"You are not so Alive");
        }

    }
    public void Hi()
    {
     int wordNum = generator.Next(words.Count); 
     Console.WriteLine($" [{name}] säger: {words[wordNum]}");
     ReduceBordom(); 
    }

    public void Teach(string word)
    {
        Console.WriteLine($" [{name}] lär sig: {word}");
        words.Add(word);
        ReduceBordom();
    }
    public void Tick()
    {
        hunger++;
        boredom++;
        if (hunger > 10 || boredom > 10)
        {
            isAlive = false;
        }
    }
    public bool GetAlive()
    {
        return true;
    }
    private void ReduceBordom()
    {
        Console.WriteLine($" [{name}] Är nu mindre utråkad");
        boredom -= 2;
        if (boredom < 0)
        {
            boredom = 0;
        }
    }
}