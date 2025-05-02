using UnityEngine;

public class ButtonFaceCamera : MonoBehaviour
{
    void LateUpdate()
    {
        Transform cam = Camera.main.transform;

        // Face the camera
        transform.LookAt(transform.position + cam.forward, cam.up);

        // Flip the button to face the camera correctly
        Vector3 scale = transform.localScale;
        scale.x = -Mathf.Abs(scale.x);
        transform.localScale = scale;
    }
}
