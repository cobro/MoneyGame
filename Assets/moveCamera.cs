using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    Camera mainCam;
    Vector3 tempCameraPos;
    public static bool cameraAnimating = false;
    void Start()
    {
        mainCam = Camera.main;
    }
    public IEnumerator animateCamera()
    {
        cameraAnimating = true;
        yield return new WaitForSeconds(.5f);
        mainCam.transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x + 850, transform.position.y, transform.position.z), 1f);

    }
}
