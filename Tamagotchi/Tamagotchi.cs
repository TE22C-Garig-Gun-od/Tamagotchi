
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
        Console.WriteLine($"You fed {name} and it's less hungry!");
        Hunger -=4;
    }

     public void Hi()
    {
        int i = Random.Shared.Next(words.Count);
        Console.WriteLine(words[i]);
        ReduceBoredom();
    }


    public void Teach (string word)
    {
        
        Console.WriteLine($"{name} learns : {word}");
        words.Add(word);
        ReduceBoredom();
    }

    public void Tick()
    {
        Boredom ++;
        Hunger ++;
    }

    public void PrintStats()
    {
        Console.WriteLine($"Name: {name} || Hunger: {Hunger} || Boredom; {Boredom} || Vocabulary: {words.Count} words");
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

