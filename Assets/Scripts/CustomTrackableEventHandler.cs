using UnityEngine;
using UnityEngine.UI;

public class CustomTrackableEventHandler : DefaultTrackableEventHandler
{
    public Image detectionImg;
    [Space]
    public Color colorFound;
    public Color colorLost;

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        Debug.Log($"<color=green><b> FOUND! </b></color>");
        detectionImg.color = colorFound;
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        Debug.Log($"<color=red><b> LOST! </b></color>");
        detectionImg.color = colorLost;
    }
}
