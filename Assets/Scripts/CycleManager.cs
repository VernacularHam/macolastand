using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleManager : MonoBehaviour {

    public int TurnProfit;

    private Model model;
    private Marketing marketing;
    private Training training;

    private int turnsFromPreviousRelease;

    // Use this for initialization
    void Start() {
        model = new Model();
        marketing = model.Marketing;
        training = model.Training;
    }

    // Update is called once per frame
    void Update() {
        NextTurn();
    }

    private void NextTurn() {
        if (model.Budget <= 0) {
            LoseGame();
        }

        if(IsRelease()) {
            model.Budget += CalcRevenue(); 
        }

        model.PayEmployees();


    }

    private int CalcNumberOfSales() {
        var baseSales = model.Release * 100;
        var randomMod = 1.5 * Random.value;

        return (int)(baseSales * randomMod);
    }

    private int CalcRevenue() {
        var marketingModifier = marketing.Level;

        return (int)(model.CurrentPrice * CalcNumberOfSales() * marketingModifier);
    }

    private bool IsRelease() {
        return false;
    }

    private void LoseGame() {
        return;
    }
}
