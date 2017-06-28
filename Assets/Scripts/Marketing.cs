using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Marketing
{
    public Marketing()
    {
        _costMultiplier = 10;
        _cost = 100;
        _level = 1;
    }

    private int _costMultiplier;

    /// <summary>
    /// Cost in units of money.
    /// </summary>
    private int _cost;
    public int Cost
    {
        get { return _cost; }
    }

    private int _level;
    public int Level
    {
        get { return _level; }
    }

    public void Update()
    {
        _level++;
        _cost += _cost * _costMultiplier;
    }
 
}

