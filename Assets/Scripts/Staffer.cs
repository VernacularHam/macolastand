using System.Collections;
using System.Collections.Generic;
using System;

public class Staffer {
    public Staffer(int index, int level)
    {
        _level = level;
        _name = names[index];
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
            return _level * 2;
        }

        set 
        {
            _level = value;
        }
    }
}
