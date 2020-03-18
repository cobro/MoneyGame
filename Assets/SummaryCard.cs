using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SummaryCard : MonoBehaviour
{
    
    public TextMeshProUGUI health;
    public TextMeshProUGUI social;
    public TextMeshProUGUI money;

    void Update()
    {
        
        health.text = "Health " + CardHolder.summaryHealth.ToString();
        if (Mathf.Abs(CardHolder.summarySocial) < .05)
            social.text = " Social 0";
        else
            social.text = "Social " + CardHolder.summarySocial.ToString();
        money.text = "Money " + CardHolder.summaryMoney.ToString();
    }
}
