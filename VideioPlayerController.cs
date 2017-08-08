using UnityEngine;
using System.Collections;
using RenderHeads.Media.AVProVideo;

public class VideioPlayerController : MonoBehaviour {
    public MediaPlayer media;
    public string currentSelectedToolname="";
	// Use this for initialization
	void Start () {
        //PlayVideoByName("车刀的辅助平面.avi");
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    public void PlayVideoByName(string videoName)
    {
        media.OpenVideoFromFile(MediaPlayer.FileLocation.RelativeToStreamingAssetsFolder, videoName, true);
        //Debug.Log("当前播放:"+videoName);
    }
}
