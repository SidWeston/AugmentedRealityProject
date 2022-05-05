using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.Video;

public class VuforiaPlayVideo : MonoBehaviour
{
    public VideoPlayer videoToPlay;
    public ImageTargetBehaviour imageBehaviour;

    private void Update()
    {
        if (imageBehaviour.CurrentStatus == TrackableBehaviour.Status.DETECTED && !videoToPlay.isPlaying)
        {
            PlayVideo();
        }
        else if (imageBehaviour.CurrentStatus != TrackableBehaviour.Status.DETECTED && videoToPlay.isPlaying)
        {
            StopVideo();
        }
    }

    private void PlayVideo()
    {
        videoToPlay.Play();
    }

    private void StopVideo()
    {
        videoToPlay.Stop();
    }
}
