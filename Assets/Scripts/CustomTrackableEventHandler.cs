using UnityEngine;

public class CustomTrackableEventHandler : DefaultTrackableEventHandler
{
    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        Debug.Log($"<color=green><b> FOUND! </b></color>");
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        Debug.Log($"<color=red><b> LOST! </b></color>");
    }
}
