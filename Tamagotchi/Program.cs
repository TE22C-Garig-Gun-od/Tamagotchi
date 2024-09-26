
Console.WriteLine("Hello! Welcome to Tamagotchi");
Tamagotchi tama = new();
Console.WriteLine("Please write a name for your tamagotchi!");
tama.name = Console.ReadLine();
Console.WriteLine($"Yay! {tama.name} is a cool name!");
Console.ReadKey();



while (tama.GetAlive() == true)
{

tama.PrintStats();
Console.WriteLine("Now what do you want to do?");
Console.WriteLine($"1. Teach {tama.name} a new word!");
Console.WriteLine($"2. Talk to {tama.name}!");
Console.WriteLine($"3. Feed {tama.name}!");
Console.WriteLine($"4. Do nothing.");

string toDo = Console.ReadLine();

if (toDo == "1")
{
    Console.WriteLine($"What word do you want to teach {tama.name}?");
    string word = Console.ReadLine();
    tama.Teach(word);
}
if (toDo == "2")
{
    tama.Hi();
}

if (toDo == "3")
{
    tama.Feed();
}

if (toDo == "4")
{
    Console.WriteLine("Doing nothing..");
}
tama.Tick();
Console.WriteLine("Press enter to continue!");
Console.ReadLine();
}




Console.ReadKey();