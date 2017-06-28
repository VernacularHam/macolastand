using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CycleManager : MonoBehaviour {

    public int TurnProfit;

    public Model model;

    private Marketing marketing;
    private Training training;
    private int trainingAmount;
    private System.Random random;

    private int turnsFromPreviousRelease;

    // Use this for initialization
    void Awake() {
        random = new System.Random();
        model = new Model();
        marketing = model.Marketing;
        training = model.Training;
    }

    // Update is called once per frame
    void Update() {

    }

    public void HireEmployee()
    {
        model.addEmployee(new Staffer(random.Next(0, 17) , random.Next(1, 10)));
    }

    public void BuyTraining() {
        model.BuyTraining();
        trainingAmount++;
    }

    public void BuyMarketing() {
        model.BuyMarketing();
    }

    public void NextTurn() {
        model.PayEmployees();

        var isReleased = model.PerformWork();       

        if (isReleased) {
            model.Budget += CalcRevenue();
            
            if (trainingAmount > 0) {
                model.ApplyTraining(trainingAmount);
                trainingAmount = 0;
                turnsFromPreviousRelease = 0;
            } 
        }

        turnsFromPreviousRelease++;

        if (model.Budget <= 0) {
            LoseGame();
        }
    }

    public void FireEmployee(int employee)
    {
        Debug.Log("attempting to fire employee");
        Debug.Log("firing: " + employee);
        model.RemoveEmployee(employee);
    }

    private int CalcNumberOfSales() {
        var baseSales = model.Release * 50;
        var randomMod = 1.5 * Random.value;

        return (int)(baseSales * randomMod);
    }

    private int CalcRevenue() {
        var marketingModifier = marketing.Level;

        return (int)(model.CurrentPrice * CalcNumberOfSales() * marketingModifier);
    }

    private void LoseGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Initialize() {
        model = new Model();
        marketing = model.Marketing;
        training = model.Training;
    }
}
