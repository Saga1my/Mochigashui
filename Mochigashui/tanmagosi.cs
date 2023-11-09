using System;

Console.WriteLine("Hello");

Tamagotchi Tamagotchi = new Tamagotchi();

Console.WriteLine("Write a name that you want for you tamahosgi");
Tamagotchi.name = Console.ReadLine();

Console.WriteLine($"Ok..here is{Tamagotchi.name}");

while (Tamagotchi.GetAlive() == true)
{
  Console.Clear();
  Tamagotchi.PrintStats();
  Console.WriteLine("what now?");
  Console.WriteLine($"1. Teach {Tamagotchi.name} a new word");
  Console.WriteLine($"2. Talk to {Tamagotchi.name}");
  Console.WriteLine($"3. Feed {Tamagotchi.name}");
  Console.WriteLine($"4. Ignore him");

  string choice = Console.ReadLine();

  if (choice == "1")
  {
    Console.WriteLine("What word?");
    string word = Console.ReadLine();
    Tamagotchi.Teach(word);
    Console.ReadLine();
  }
  if (choice == "2")
  {
    Tamagotchi.Talking();
    Console.ReadLine();
  }
  if (choice == "3")
  {
    Tamagotchi.food();
    Console.ReadLine();
  }
  if (choice == "4")
  {
    Console.WriteLine("...");
    Console.ReadLine();
  }
  Tamagotchi.Time();

}

Console.WriteLine($"OH NO! {Tamagotchi.name} is dead!");
Console.WriteLine("Press ENTER to quit");
Console.ReadLine();