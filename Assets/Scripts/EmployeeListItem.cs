using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmployeeListItem : MonoBehaviour {
    public int index;
    public GameObject UI;

    void Awake()
    {
        UI = GameObject.Find("UI");
        Debug.Log("What is UI");
        Debug.Log(UI);
    }

    public void deleteEmployee()
    {
        UI.GetComponent<CycleManager>().FireEmployee(index);
        UI.GetComponent<Menu>().UpdateData();
    }
}
