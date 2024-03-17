using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Storage : MonoBehaviour
{
    public static Storage inst;
    private string currentResource;
    private string currentHardResource;
    private void Awake()
    {
        if(inst != null)
        {
            Destroy(gameObject);
        }
        else
        {
            inst = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    private Dictionary<string, int> resources = new Dictionary<string, int>()
    {
        {"Scrap", 0},
        {"Wood", 0},
        {"Stone", 0},
        {"Water", 0},
        {"Metal", 0},
        {"Mechanism", 0},
        {"Weapon", 0}
    };
    private Dictionary<string, int> bots = new Dictionary<string, int>()
    {
        {"WeakRobot", 0},
        {"NormalRobot", 0},
        {"StrongRobot", 0}
    };
    
    public void SetCurrentResource(string resName) => currentResource = resName;
    public string GetCurrentResource() => currentResource;
    public int GetResourceCount(string resName) => resources[resName];
    public void ChangeResourceCount(string resName, int count) 
    {
        resources[resName] += count;
        if(WorldTicker.uiTick != null) WorldTicker.uiTick.Invoke();
        if(resources[resName] < 0) print("Кто-то позволил ресурсу быть меньше нуля >:("); 
    }
    public int GetBotCount(string resName) => resources[resName];
    public void ChangeBotCount(string resName, int count) 
    {
        resources[resName] += count;
        if(WorldTicker.uiTick != null) WorldTicker.uiTick.Invoke();
        if(resources[resName] < 0) print("Кто-то позволил боту быть меньше нуля >:("); 
    }
}
