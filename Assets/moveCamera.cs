using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class moveCamera : MonoBehaviour
{
    public CinemachineVirtualCamera vCam;
    CinemachineTrackedDolly cinenachineTrackedDolly;
    public static bool cameraAnimating = false;
    public static float NextPathPosition = 0;
    public float speed = 1.0F;
    private float startTime;
    private float journeyLength;

    private void Start()
    {
        cinenachineTrackedDolly = vCam.GetCinemachineComponent<CinemachineTrackedDolly>();
    }
    public void switchPosition()
    {
        cinenachineTrackedDolly.m_PathPosition = NextPathPosition;
    }


    public IEnumerator animateCamera()
    {
        cameraAnimating = true;
        yield return new WaitForSeconds(.5f);
        startTime = Time.time;
        journeyLength = NextPathPosition - cinenachineTrackedDolly.m_PathPosition;
        while (cinenachineTrackedDolly.m_PathPosition < NextPathPosition)
        {
            float distCovered = (Time.time - startTime) * speed;
            float fractionOfJourney = distCovered / journeyLength;
            cinenachineTrackedDolly.m_PathPosition = Mathf.Lerp(cinenachineTrackedDolly.m_PathPosition, NextPathPosition, 0.1f * Time.deltaTime);
            Debug.Log("Lerping");
            if (cinenachineTrackedDolly.m_PathPosition < NextPathPosition - 0.1f)
            {
                cinenachineTrackedDolly.m_PathPosition = NextPathPosition;
                cameraAnimating = false;
            }
        }
    }
}