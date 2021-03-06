﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    private Text TrainingLevel;
    private Text MarketingLevel; 
    private Text ReleaseNumber;
    private Text SprintNumber;
    private Text WorkRemaining;
    private Text MoneyRemaining;
    private Text PayrollCost;
    private Text MoneySpent;
    private Text MoneyEarned;
    
    private List<GameObject> EmployeeList;
    
    private GameObject ListItemPrefab;
    private Model model;

    public GameObject EmployeePrefabRef;
    public GridLayoutGroup EmployeeListContainer;

    // Use this for initialization
    void Start () {
        TrainingLevel = transform.Find("Training Level").GetComponent<Text>();
        MarketingLevel = transform.Find("Marketing Level ").GetComponent<Text>();
        ReleaseNumber = transform.Find("Release Number").GetComponent<Text>();
        SprintNumber = transform.Find("Sprint Number").GetComponent<Text>();
        WorkRemaining = transform.Find("Work Remaining").GetComponent<Text>();
        MoneyRemaining = transform.Find("Funds").GetComponent<Text>();
        PayrollCost = transform.Find("Setup/Employees/Payroll cost").GetComponent<Text>();
        //MoneySpent = transform.Find("Results/Money spent").GetComponent<Text>();
        //MoneyEarned = transform.Find("Results/Money earned").GetComponent<Text>();

        model = GetComponent<CycleManager>().model;

        UpdateData();
    }

    // Update is called once per frame
    public void UpdateData () {
        TrainingLevel.text = "Training Level: " + model.Training.Level.ToString();
        MarketingLevel.text = "Marketing Level: " + model.Marketing.Level.ToString();
        ReleaseNumber.text = "Release " + model.Release.ToString();
        SprintNumber.text = "Sprint " + model.Sprint.ToString();
        WorkRemaining.text = "Work Remaining: " + model.WorkRemaining.ToString();
        MoneyRemaining.text = "Funds: $" + model.Budget.ToString();
        
        foreach (Transform child in EmployeeListContainer.transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        var totalCost = 0;
        for (int i = 0; i < model.Employees.Count; i++)
        {
            GameObject newEmployee = Instantiate(EmployeePrefabRef) as GameObject;
            newEmployee.transform.GetChild(0).GetComponent<Text>().text = model.Employees[i].Name;
            newEmployee.transform.GetChild(1).GetComponent<Text>().text = model.Employees[i].Cost.ToString();
            newEmployee.transform.GetChild(2).GetComponent<Text>().text = model.Employees[i].Output.ToString();

            newEmployee.transform.parent = EmployeeListContainer.transform;
            newEmployee.GetComponent<EmployeeListItem>().index = i;

            totalCost += model.Employees[i].Cost;
        }
        PayrollCost.text = "Payroll cost/sprint: $" + totalCost;
        
    }

}
