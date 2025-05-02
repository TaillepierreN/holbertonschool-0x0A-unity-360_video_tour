using UnityEngine;

public class Hotspot : MonoBehaviour
{
    public GameObject CurrentSphere;
    public GameObject TargetSphere;
    public FadeController fadeController;

    public void OnHotspotClick()
    {
        fadeController.StartFade(CurrentSphere, TargetSphere);
    }
}
