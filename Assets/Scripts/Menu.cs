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

    // Use this for initialization
    void Start () {
        TrainingLevel = transform.Find("Training Level").GetComponent<Text>();
        MarketingLevel = transform.Find("Marketing Level").GetComponent<Text>();
        ReleaseNumber = transform.Find("Release Number").GetComponent<Text>();
        SprintNumber = transform.Find("Sprint Number").GetComponent<Text>();
        WorkRemaining = transform.Find("Work Remaining ").GetComponent<Text>();
        MoneyRemaining = transform.Find("Funds").GetComponent<Text>();
        PayrollCost = transform.Find("Setup/Payroll Cost").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update () {
		
	}
}
