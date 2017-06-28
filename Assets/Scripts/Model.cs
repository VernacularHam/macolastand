using System;
using System.Collections;
using System.Collections.Generic;

public class Model {

    public Model (int budget = 10000)
    {
        _budget = budget;
        _prices = new List<int>();
        _marketing = new Marketing();
        _training = new Training();
        _employees = new List<Staffer>();
        _prices = new List<int>();

        WorkRemaining = 0;

        //generate starter employees
        for (int i = 0; i < 3; i++)
        {
            addEmployee(new Staffer(i);
        }
        _prices.Add(10000);
    }

    private int _sprint;
    public int Sprint
    {
        get { return _sprint; }
        set
        {
            _sprint = value;
        }
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

    public void RemoveEmployee(int index)
    {
        _employees.RemoveAt(index);
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

    private int _workRemaining;
    public int WorkRemaining 
    {
        get { return _workRemaining; }
        set 
        {
            if (value <= 0) {
                Release++;
                var randMod = (new Random()).Next(1,4);

                _workRemaining = 50 * Release * randMod;
            } 
            else 
            {
                _workRemaining = value;
            }                
        }
    }

    public void addEmployee(Staffer noob)
    {
        _employees.Add(noob);
    }

    public void PayEmployees() {
        foreach (var employee in Employees) {
            Budget -= employee.Cost;
        }
    }

    public bool PerformWork() {
        int previousRelease = Release;

        foreach (var employee in Employees) {
            WorkRemaining -= employee.Output;
        }

        return previousRelease != Release;
    }

    public void BuyTraining() {
        Training.Update();
        Budget -= Training.Cost;

        foreach (var employee in Employees) {
            employee.Output = (int)(1.10 * employee.Output);
        }
    }

    public void BuyMarketing() {
        Marketing.Update();
        Budget -= Training.Cost;
    }

}
