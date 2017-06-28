using System.Collections;
using System.Collections.Generic;
using System;

public class Staffer {
    public Staffer(int seed = -1)
    {
        Random random;

        if (seed != -1)
        {
            random = new Random(seed);
        }
        else
        {
            random = new Random();
        }

        int randomName = random.Next(0, 17);
        _level = random.Next(1, 10);
        _name = names[randomName];
    }

    private string[] names = { "Aniket", "Joe", "Mike", "Claudia", "Mathew", "Ben", "Stephanie", "Pratap", "Derek", "Connor", "Greta", "John DM", "Debra", "Scott", "Rex", "Kathy", "Mitch", "Rogelio" };

    private string _name;
    public string Name
    {
        get
        {
            return _name;
        }
    }

    private int _level;

    public int Cost
    {
        get
        {
            return _level * 100;
        }
    }

    public int Output
    {
        get
        {
            return _level;
        }

        set 
        {
            _level = value;
        }
    }
}
