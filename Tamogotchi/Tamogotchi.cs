using System;

public class Tamagotchi
{
    public string Name { get; set; }
    public int Health { get; set; } = 10;
    public int Hunger { get; set; } = 0;
    public int Tiredness { get; set; } = 0;
    public int Happiness { get; set; } = 10;

    public Tamagotchi(string name)
    {
        Name = name;
    }

    public void Feed()
    {
        if (Hunger > 0)
        {
            Hunger--;
        }
        else
        {
            Health--;
        }
        Happiness++;
    }

    public void Play()
    {
        if (Tiredness < 10)
        {
            Tiredness++;
            Hunger++;
            Happiness++;
        }
        else
        {
            Health--;
        }
    }

    public void Sleep()
    {
        Tiredness = 0;
        Health++;
        Hunger++;
        Happiness++;
    }

    public void Heal()
    {
        if (Health < 10)
        {
            Health++;
            Happiness++;
        }
    }

    public void CheckStatus()
    {
        Console.WriteLine($"Имя: {Name}");
        Console.WriteLine($"Здоровье: {Health}");
        Console.WriteLine($"Голод: {Hunger}");
        Console.WriteLine($"Усталость: {Tiredness}");
        Console.WriteLine($"Счастье: {Happiness}");
    }

    public bool IsAlive()
    {
        return Health > 0 && Hunger < 10 && Tiredness < 10;
    }
}