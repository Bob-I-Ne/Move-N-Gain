using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBonuses : MonoBehaviour
{
    public static MyBonuses inst;
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

    private Dictionary<string, float> bonuses = new Dictionary<string, float>()
    {
        {"MainButtonClick", 1},
        {"CraftButtonClick", 1},
    };
}
