using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class startScreen : MonoBehaviour
{
    public moveCamera moveCamera;
    public Animator Canvas;

    // Start is called before the first frame update
public void StartGame()
    {
        Canvas.SetBool("GetCanvasIn", true);
        moveCamera.NextPathPosition++;
        moveCamera.switchPosition();
    }
}
