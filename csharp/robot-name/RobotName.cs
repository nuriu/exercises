using System;
using System.Collections.Generic;
using System.Linq;

public class Robot
{
    private static readonly Random _random = new Random();
    private static readonly List<string> _nameDatabase = new List<string>();
    private string _currentName = null;

    public string Name
    {
        get
        {
            if (_currentName == null)
            {
                GenerateName();
            }
            
            return _currentName;
        }
    }

    public void Reset()
    {
        _nameDatabase.Remove(_currentName);

        _currentName = null;
    }

    private void GenerateName()
    {
        do
        {
            _currentName = string.Concat(GetRandomLetter(), GetRandomLetter(), GetRandomDigit(), GetRandomDigit(), GetRandomDigit());
        } while (_nameDatabase.Contains(_currentName));

        _nameDatabase.Add(_currentName);
    }

    private char GetRandomLetter()
    {
        return (char)_random.Next((int)'A', (int)'Z' + 1);
    }

    private int GetRandomDigit()
    {
        return _random.Next(0, 10);
    }
}
