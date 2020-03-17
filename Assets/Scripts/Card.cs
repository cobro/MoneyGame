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
    public int mentalA = 0;
    public int friendsA = 0;
    public int familyA = 0;
    public int moneyA = 0;

    [Header("Answer B")]
    [TextArea(2,4)]
    public string answerTextB;
    public int mentalB = 0;
    public int friendsB = 0;
    public int familyB = 0;
    public int moneyB = 0;
}
