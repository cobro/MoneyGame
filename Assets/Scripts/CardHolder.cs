using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardHolder : MonoBehaviour
{

    public TextMeshProUGUI CardName;
    public TextMeshProUGUI description;
    public TextMeshProUGUI answerA;
    public TextMeshProUGUI answerB;
    public Slider health;
    public Slider social;
    public TextMeshProUGUI money;
    public Card card;
    public Button buttonA;
    public Button buttonB;
    public moneyTracker moneyTracker;
    public moveCamera moveCamera;

    void OnValidate(){
        CardName.text = card.name;
        description.text = card.problemDescription;
        answerA.text = card.answerTextA;
        answerB.text = card.answerTextB;
    }

    public void AnswerA()
    {
        health.value += card.mentalA/10;
        social.value += card.familyA/10;
        moneyTracker.Money += card.moneyA;
        money.text = "$" + moneyTracker.Money.ToString();

        if (!moveCamera.cameraAnimating)
        {
            Debug.Log("Coroutine Called");
            StartCoroutine(moveCamera.animateCamera());
        }
        buttonA.interactable = false;
        buttonB.interactable = false;
    }
    public void AnswerB()
    {
        health.value += card.mentalB / 10;
        social.value += card.familyB / 10;
        moneyTracker.Money += card.moneyB;
        money.text = "$" + moneyTracker.Money.ToString();

        if (!moveCamera.cameraAnimating)
        {
            StartCoroutine(moveCamera.animateCamera());
        }
        buttonA.interactable = false;
        buttonB.interactable = false;
    }
}
