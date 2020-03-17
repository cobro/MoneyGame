using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class CardHolder : MonoBehaviour
{

    public TextMeshProUGUI CardName;
    public TextMeshProUGUI description;
    public TextMeshProUGUI answerA;
    public TextMeshProUGUI answerB;
    public Slider sealth;
    public Slider social;
    public TextMeshProUGUI money;
    public ScriptableObject card;

    void onValidate(){
        CardName.text = card.name;
    }
}
