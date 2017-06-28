using System.Collections;
using System.Collections.Generic;

public class Model {

    public Model (int budget = 1000)
    {
        _budget = budget;
        _release = 0;
        _prices = new List<int>();
        _marketing = new Marketing();
        _training = new Training();
        _workRemaining = 0;
    }

    private double _workRemaining;
    public double WorkRemaining
    {
        get
        {
            return _workRemaining;
        }
    }

    public void deductWorkRemaining(double deductAmt)
    {
        _workRemaining -= deductAmt;
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

    private Marketing _marketing;
    public Marketing Marketing
    {
        get { return _marketing; }
    }

    private Training _training;
    public Training Training
    {
        get { return _training; }
    }

    public void addEmployee(Staffer noob)
    {
        _employees.Add(noob);
    }
}
