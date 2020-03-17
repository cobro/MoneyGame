using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public new string name;
    public string problemDescription;
    public string answerA;
    public string answerB;
    public int phycisalA = 0;
    public int physicalB = 0;
    public int mentalA = 0;
    public int mentalB = 0;
    public int moneyA = 0;
    public int moneyB = 0;
    public int familyA = 0;
    public int familyB = 0;
    public int friendsA = 0;
    public int friendsB = 0;
}
