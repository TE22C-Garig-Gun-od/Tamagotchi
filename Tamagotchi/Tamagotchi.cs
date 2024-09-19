
using Microsoft.VisualBasic;

public class Tamagotchi
{
    private int Hunger;
    private int Boredom;
    private List<string> words = new() {"hewwow"};
    private bool IsAlive = true;
    public string name;

    public void Feed()
    {
        Console.WriteLine($"You fed {name} and it's less hungry ");
        Hunger -=4;
    }

     public void Hi()
    {
        int i = Random.Shared.Next(words.Count);
        Console.WriteLine(words[i]);
    }


    public void Teach (string word)
    {
        words.Add(word);
    }

    public void Tick()
    {
        Boredom ++;
        Hunger ++;
    }

    public void PrintStats()
    {
        Console.WriteLine($"You have {Boredom} boredom {Hunger}  hunger!");
    }

    public bool GetAlive()
    {
        return IsAlive;
    }

    private void ReduceBoredom()
    {
        Console.WriteLine($"You reduced {name}s boredom!");
        Boredom -= 3;
    }

}

