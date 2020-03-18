using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class moveCamera : MonoBehaviour
{
    public CinemachineDollyCart vCam;
    public static bool cameraAnimating = false;
    public static int NextPathPosition;
    public float speed = 1.0F;
    private float startTime;
    private float journeyLength;

    public IEnumerator animateCamera()
    {
        cameraAnimating = true;
        yield return new WaitForSeconds(.5f);
        startTime = Time.time;
        journeyLength = vCam.m_Position;
        /*while (mainCam.transform.position.x < tempCameraPos.x +850)
        {
            mainCam.transform.position = Vector3.Lerp(mainCam.transform.position, new Vector3(tempCameraPos.x + 850, tempCameraPos.y, tempCameraPos.z), 0.1f * Time.deltaTime);
            Debug.Log("Lerping");
            if (mainCam.transform.position.x > tempCameraPos.x + 850 - 0.1f)
            {
                mainCam.transform.position = new Vector3(tempCameraPos.x + 850, transform.position.y, transform.position.z);
                cameraAnimating = false;
            }
        }*/
    }
}