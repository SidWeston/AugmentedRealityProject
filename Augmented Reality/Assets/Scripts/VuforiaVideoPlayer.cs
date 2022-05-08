using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.Video;

public class VuforiaVideoPlayer : MonoBehaviour
{
    public DefaultTrackableEventHandler eventHandler;
    public VideoPlayer videoPlayer;

    // Update is called once per frame
    void Update()
    {
        //if the object is being tracked
        if (eventHandler.m_NewStatus == TrackableBehaviour.Status.DETECTED ||
            eventHandler.m_NewStatus == TrackableBehaviour.Status.TRACKED ||
            eventHandler.m_NewStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            if(!videoPlayer.isPlaying)
            {
                videoPlayer.Play();
            }
        } //if the object has lost tracking
        else if (eventHandler.m_PreviousStatus == TrackableBehaviour.Status.TRACKED &&
            eventHandler.m_NewStatus == TrackableBehaviour.Status.NO_POSE)
        {
            if(videoPlayer.isPlaying)
            {
                videoPlayer.Stop();
            }
        }
    }
}
