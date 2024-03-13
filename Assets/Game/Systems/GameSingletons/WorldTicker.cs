using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldTicker : MonoBehaviour
{
    public static WorldTicker inst;
    public static Action secTick;
    public static Action uiTick;
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
    private void Start()
    {
        StartCoroutine(OneSecTicker());
        
    }
    private IEnumerator OneSecTicker()
    {
        while(true)
        {
            secTick.Invoke();
            uiTick.Invoke();
            yield return new WaitForSeconds(1f);
        }
    }
}
