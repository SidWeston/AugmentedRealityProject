using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VuforiaTargetChecker : MonoBehaviour
{

    public DefaultTrackableEventHandler eventHandler;
    public UIImageChanger imageChanger;

    // Update is called once per frame
    void Update()
    { 
        //if the object is being tracked
        if(eventHandler.m_NewStatus == TrackableBehaviour.Status.DETECTED ||
            eventHandler.m_NewStatus == TrackableBehaviour.Status.TRACKED ||
            eventHandler.m_NewStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            imageChanger.active = true;
        } //if the object has lost tracking
        else if(eventHandler.m_PreviousStatus == TrackableBehaviour.Status.TRACKED &&
            eventHandler.m_NewStatus == TrackableBehaviour.Status.NO_POSE)
        {
            imageChanger.active = false;
        }
    }
}
