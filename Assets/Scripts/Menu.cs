using System.Collections;
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
    
    private List<GameObject> EmployeeList;
    private Model model; 

    // Use this for initialization
    void Start () {
        TrainingLevel = transform.Find("Training Level").GetComponent<Text>();
        MarketingLevel = transform.Find("Marketing Level ").GetComponent<Text>();
        ReleaseNumber = transform.Find("Release Number").GetComponent<Text>();
        SprintNumber = transform.Find("Sprint Number").GetComponent<Text>();
        WorkRemaining = transform.Find("Work Remaining").GetComponent<Text>();
        MoneyRemaining = transform.Find("Funds").GetComponent<Text>();

        model = GetComponent<CycleManager>().model;

        UpdateData();
    }

    // Update is called once per frame
    public void UpdateData () {
        TrainingLevel.text = "Training Level: " + model.Training.Level.ToString();
        MarketingLevel.text = "Marketing Level: " + model.Marketing.Level.ToString();
        ReleaseNumber.text = "Release " + model.Release.ToString();
        SprintNumber.text = "Sprint " + model.Sprint.ToString();
        WorkRemaining.text = "WorkRemaining: " + model.WorkRemaining.ToString();
        MoneyRemaining.text = "$ " + model.Budget.ToString();
    }

}
