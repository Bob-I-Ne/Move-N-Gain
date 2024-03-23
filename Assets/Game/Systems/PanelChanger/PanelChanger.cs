using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelChanger : MonoBehaviour
{

    public GameObject grindingPanel;
    public GameObject craftingPanel;
    public GameObject botsPanel;
    public GameObject buildingsPanel;
    public GameObject upgradesPanel;
    public GameObject settingsPanel;
    private int actPanel;
    private GameObject[] panels = new GameObject[6];

    void Start()
    {
        bool grind = grindingPanel.activeInHierarchy;
        bool craft = craftingPanel.activeInHierarchy;
        bool bots = botsPanel.activeInHierarchy;
        bool buildings = buildingsPanel.activeInHierarchy;
        bool upgrades = upgradesPanel.activeInHierarchy;
        bool settings = settingsPanel.activeInHierarchy;

        if (grind) actPanel = 0;
        if (craft) actPanel = 1;
        if (bots) actPanel = 2;
        if (buildings) actPanel = 3;
        if (upgrades) actPanel = 4;
        if (settings) actPanel = 5;

        panels[0] = grindingPanel;
        panels[1] = craftingPanel;
        panels[2] = botsPanel;
        panels[3] = buildingsPanel;
        panels[4] = upgradesPanel;
        panels[5] = settingsPanel;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && !panels[0].activeInHierarchy)
        {
            panels[actPanel].SetActive(false);
            panels[0].SetActive(true);
            actPanel = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && !panels[1].activeInHierarchy)
        {
            panels[actPanel].SetActive(false);
            panels[1].SetActive(true);
            actPanel = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && !panels[2].activeInHierarchy)
        {
            panels[actPanel].SetActive(false);
            panels[2].SetActive(true);
            actPanel = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && !panels[3].activeInHierarchy)
        {
            panels[actPanel].SetActive(false);
            panels[3].SetActive(true);
            actPanel = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) && !panels[4].activeInHierarchy)
        {
            panels[actPanel].SetActive(false);
            panels[4].SetActive(true);
            actPanel = 4;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6) && !panels[5].activeInHierarchy)
        {
            panels[actPanel].SetActive(false);
            panels[5].SetActive(true);
            actPanel = 5;
        }
    }
}
