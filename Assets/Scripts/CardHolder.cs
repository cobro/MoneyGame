using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CardHolder : MonoBehaviour
{

    public static float summaryHealth = 0;
    public static float summarySocial = 0;
    public static float summaryMoney = 0;
    public static bool tookALoan = false;
    public TextMeshProUGUI CardName;
    public TextMeshProUGUI description;
    public TextMeshProUGUI answerA;
    public TextMeshProUGUI answerB;
    public Slider health;
    public Slider social;
    public TextMeshProUGUI money;
    public GameObject buttonAGO;
    public GameObject buttonBGO;
    public GameObject continueButton;
    public moveCamera moveCamera;
    public changeDate changeDate;
    [Header("Drop A Card Here")]
    public Card card;

    
    void OnValidate(){
        CardName.text = card.name;
        description.text = card.problemDescription;
        answerA.text = card.answerTextA;
        answerB.text = card.answerTextB;
    }

    public void AnswerA()
    {
        health.value += card.healthA/10;
        summaryHealth += card.healthA / 10;
        social.value += card.socialA/10;
        summarySocial += card.socialA / 10;
        moneyTracker.Money += card.moneyA;
        summaryMoney += card.moneyA;
        money.text = moneyTracker.Money.ToString();
        buttonAGO.SetActive(false);
        buttonBGO.SetActive(false);
        continueButton.SetActive(true);
        description.text = card.feedbackA;
        Debug.Log("Health Change " + summaryHealth + " Social Change " + summarySocial + " Money Change " + summaryMoney);
    }

    public void AnswerB()
    {
        health.value += card.healthB / 10;
        summaryHealth += card.healthB / 10;
        social.value += card.socialB / 10;
        summarySocial += card.socialB / 10;
        moneyTracker.Money += card.moneyB;
        summaryMoney += card.moneyB;
        money.text = moneyTracker.Money.ToString();
        buttonAGO.SetActive(false);
        buttonBGO.SetActive(false);
        continueButton.SetActive(true);
        description.text = card.feedbackB;
        Debug.Log("Health Change " + summaryHealth + " Social Change " + summarySocial + " Money Change " + summaryMoney);
    }

    void summaryReset()
    {
        summaryHealth = 0;
        summarySocial = 0;
        summaryMoney = 0;
    }

    public void progressCards()
    {
        moveCamera.NextPathPosition++;
        moveCamera.switchPosition();
        changeDate.changeDateMethod();
    }

    public void continueFromSummary()
    {
        summaryReset();
        progressCards();
    }

    public void RestartGame()
    {
        moveCamera.NextPathPosition = 0;
        summaryReset();
        health.value = 0.5f;
        social.value = 0.5f;
        moneyTracker.Money = 500;
        tookALoan = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void takekALoan()
    {
        AnswerB();
        tookALoan = true;
    }
}
