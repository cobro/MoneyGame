using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class changeDate : MonoBehaviour
{
    public moveCamera moveCamera;
    public string [] days;
    public TextMeshProUGUI date;

    public void changeDateMethod()
    {
        date.text = days[(int)moveCamera.NextPathPosition];
    }
}
