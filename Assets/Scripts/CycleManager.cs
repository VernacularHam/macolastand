﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleManager : MonoBehaviour {

    public int TurnProfit;

    public Model model;

    private Marketing marketing;
    private Training training;
    private bool applyTraining;

    private int turnsFromPreviousRelease;

    // Use this for initialization
    void Awake() {
        model = new Model();
        marketing = model.Marketing;
        training = model.Training;
    }

    // Update is called once per frame
    void Update() {

    }

    public void BuyTraining() {
        model.BuyTraining();
        applyTraining = true;
    }

    public void BuyMarketing() {
        model.BuyMarketing();
    }

    public void NextTurn() {
        model.PayEmployees();

        var isReleased = model.PerformWork();       

        if (isReleased) {
            model.Budget += CalcRevenue();
            
            if (applyTraining) {
                model.BuyTraining();
                applyTraining = false;
            } 
        }

        if (model.Budget <= 0) {
            LoseGame();
            Debug.Log("You Lost");
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
        return;
    }
}
