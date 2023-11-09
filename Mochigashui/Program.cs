using System;
using System.Collections.Generic;

public class Tamagotchi
{
  private int hunger;
  private int boredom;
  private List<string> words = new List<string>() { "MEOW" };
  private bool alive;
  private Random generator;
  public string name;

  public Tamagotchi()
  {
    generator = new Random();
    alive = true;
  }


  public void food()
  {
    Console.WriteLine($" {name} eats");
    hunger -= 2;
    if (hunger < 0)
    {
      hunger = 0;
    }
  }

  public void Talking()
  {
    int wordNum = generator.Next(words.Count);
    foreach (string word in words)
    {
      Console.WriteLine($" {name}: {words[wordNum]}");
      wordNum = generator.Next(words.Count);

    }
    ReduceBoredom();
  }

  public void Teach(string word)
  {
    Console.WriteLine($" {name} learns: {word}");
    words.Add(word);
    ReduceBoredom();
  }

  public void Time()
  {
    if (hunger > 10 || boredom > 10)
    {
      alive = false;
    }
    hunger++;
    boredom++;
  }

  public void PrintStats()
  {
    Console.WriteLine($"Name: {name} || Hunger: {hunger} || Boredom: {boredom} || Vocabulary: {words.Count} words");
  }

  public bool GetAlive()
  {
    return alive;
  }

  public void ReduceBoredom()
  {

    boredom -= 2;
    if (boredom < 0)
    {
      boredom = 0;
    }
  }
}