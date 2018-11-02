using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeToRotate : MonoBehaviour {

    float rotSpeed = 100;
    float rotSpeeds = 60;
    void OnMouseDrag()
    {
        float rotY = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        transform.Rotate(0, -rotY, 0, Space.Self);

        float rotX = Input.GetAxis("Mouse Y") * rotSpeeds * Mathf.Deg2Rad;
        transform.Rotate(rotX, 0, 0, Space.Self);
    }
}
