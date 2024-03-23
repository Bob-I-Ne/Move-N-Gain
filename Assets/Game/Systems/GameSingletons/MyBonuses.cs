using System;
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

    public Dictionary<string, int> bonuses = new Dictionary<string, int>()
    {
        {"MainButtonClick", 1},
        {"CraftButtonClick", 1},
    };

    [Serializable]
    public class Bonus
    {
        public string name;
        public Type type;
        public int value;

        public enum Type { percentage, flat }
    }
}
