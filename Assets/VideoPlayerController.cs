using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

[RequireComponent(typeof(VideoPlayer))]
public class VideoPlayerController : MonoBehaviour {

    VideoPlayer myVideoPlayer;

    private int counter = 0;

    public Text loopCounter;


	// Use this for initialization
	void Start () {
        myVideoPlayer = GetComponent<VideoPlayer>();

        myVideoPlayer.loopPointReached += OnVideoLoopPointReached;
    }

    public void OnVideoLoopPointReached(VideoPlayer vp)
    {
        StartCoroutine(RestartVideo());
    }

    IEnumerator RestartVideo()
    {
        myVideoPlayer.Stop();
        yield return null;
        yield return null;
        yield return null;

        counter++;
        loopCounter.text = counter.ToString();
        myVideoPlayer.Play();
        yield return null;
        yield return null;
        yield return null;

    }

}
