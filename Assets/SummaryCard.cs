﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SummaryCard : MonoBehaviour
{
    
    public TextMeshProUGUI health;
    public TextMeshProUGUI social;
    public TextMeshProUGUI money;
    public TextMeshProUGUI currentBalance;

    public void lastContinueBeforeSummary()
    {
        health.text = "Health: " + CardHolder.summaryHealth.ToString();
        if (Mathf.Abs(CardHolder.summarySocial) < .05)
            social.text = " Social 0";
        else
            social.text = "Social: " + CardHolder.summarySocial.ToString();
        
        if (CardHolder.tookALoan == true)
        {
            moneyTracker.Money -= 664;
            currentBalance.text = moneyTracker.Money.ToString();
            money.text = "Money: " + CardHolder.summaryMoney.ToString() + " - 664 (Loan interest) = " + (CardHolder.summaryMoney - 664).ToString();
        }
        else if (CardHolder.tookALoan == false)
            money.text = "Money " + CardHolder.summaryMoney.ToString();
    }
}
