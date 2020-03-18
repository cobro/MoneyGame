using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    public Camera mainCam;
    Vector3 tempCameraPos;
    public static bool cameraAnimating = false;

    public IEnumerator animateCamera()
    {
        cameraAnimating = true;
        yield return new WaitForSeconds(.5f);
        tempCameraPos = mainCam.transform.position;
        while (mainCam.transform.position.x < tempCameraPos.x +850)
        {
            mainCam.transform.position = Vector3.Lerp(mainCam.transform.position, new Vector3(tempCameraPos.x + 850, tempCameraPos.y, tempCameraPos.z), 0.1f * Time.deltaTime);
            Debug.Log("Lerping");
            if (mainCam.transform.position.x > tempCameraPos.x + 850 - 0.1f)
            {
                mainCam.transform.position = new Vector3(tempCameraPos.x + 850, transform.position.y, transform.position.z);
                cameraAnimating = false;
            }
        }
    }
}