using UnityEngine;

public class InfoPanel : MonoBehaviour
{
    public GameObject infoPanel;
    public void ShowInfoPanel()
    {
        infoPanel.SetActive(!infoPanel.activeSelf);
    }
}
