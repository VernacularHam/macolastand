using System.Collections;
using System.Collections.Generic;

public class Model {

    public Model (int budget = 1000)
    {
        _budget = budget;
        _release = 0;
        _prices = new List<int>();
    }

    private double _budget;
    public double Budget
    {
        get { return _budget; }
        set
        {
            _budget = value;
        }
    }

    private int _release;
    public int Release
    {
        get { return _release; }
        set
        {
            _release = value;
        }
    }

    private List<int> _prices;
    public int CurrentPrice
    {
        get
        {
            return _prices[_prices.Count - 1];
        }
        set
        {
            _prices.Add(value);
        }
    }

    private List<Staffer> _employees;
    public List<Staffer> Employees
    {
        get
        {
            return _employees;
        }
    }

    public void addEmployee(Staffer noob)
    {
        _employees.Add(noob);
    }
}
