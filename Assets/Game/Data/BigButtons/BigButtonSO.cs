using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New BigButtonSO", menuName = "BigButtonSO", order = 51)]
public class BigButtonSO : ScriptableObject
{
    public Sprite sprite;
    public string resource;
    public AudioClip soundOnClick;
}
