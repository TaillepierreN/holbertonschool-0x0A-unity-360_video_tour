using UnityEngine;


public class XRRaycastDebuger : MonoBehaviour
{
    private UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor rayInteractor;

    void Start()
    {
        rayInteractor = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor>();
    }

    void Update()
    {
        if (rayInteractor == null)
            return;

        if (rayInteractor.TryGetCurrentUIRaycastResult(out var result))
        {
            Debug.Log($"UI Raycast Hit: {result.gameObject.name}");
        }
        else if (rayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit hit))
        {
            Debug.Log($"3D Raycast Hit: {hit.collider.name}");
        }
        else
        {
            Debug.Log("Nothing hit by the ray");
        }

        if (rayInteractor != null && rayInteractor.isSelectActive)
        {
            Debug.Log("UI Press Input is active");
        }

    }
}
