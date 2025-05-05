using UnityEngine;

public class ButtonFaceCamera : MonoBehaviour
{
    void LateUpdate()
    {
        Transform cam = Camera.main.transform;

        Vector3 targetPosition = cam.position;
        targetPosition.y = transform.position.y;

        transform.LookAt(targetPosition);

    }
}
