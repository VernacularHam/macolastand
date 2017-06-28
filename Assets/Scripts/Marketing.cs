using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Marketing
{
    public Marketing()
    {
        _costMultiplier = 1.2;
        _cost = 100.00;
        _level = 1;
    }

    private double _costMultiplier;

    /// <summary>
    /// Cost in units of money.
    /// </summary>
    private double _cost;
    public double Cost
    {
        get { return _cost; }
        //set
        //{
        //    _cost = value;
        //}
    }

    private int _level;
    public int Level
    {
        get { return _level; }
        //set
        //{
        //    _level = value;
        //}
    }

    public void Update()
    {
        _level++;
        _cost *= _costMultiplier;
    }
 
}

