using System;
using System.Collections.Generic;

public class Robot
{
    private static readonly Random _random = new Random();
    private static readonly HashSet<string> _nameDatabase = new HashSet<string>();

    public string Name { get; private set; }

    public Robot() => Reset();

    public void Reset()
    {
        while (!_nameDatabase.Add(Name = GenerateName())) { };
    }

    private string GenerateName() => $"{GetRandomLetter()}{GetRandomLetter()}{GetRandomDigit()}{GetRandomDigit()}{GetRandomDigit()}";
    private char GetRandomLetter() => (char)_random.Next('A', 'Z' + 1);
    private int GetRandomDigit() => _random.Next(0, 10);
}
