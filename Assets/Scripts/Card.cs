using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public new string name;
    [TextArea(3,6)]
    public string problemDescription;

    [Header("Answer A")]
    [TextArea(2,4)]
    public string answerTextA;
    public float healthA = 0;
    public float socialA = 0;
    public float moneyA = 0;

    [Header("Answer B")]
    [TextArea(2,4)]
    public string answerTextB;
    public float healthB = 0;
    public float socialB = 0;
    public float moneyB = 0;
}
