using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UseRangePanelManager : MonoBehaviour {
    [SerializeField]
    Button cheWaiYuanMian;
    [SerializeField]
    Button jiaGongXiChang;
    [SerializeField]
    GameObject videoPlayer;
    public bool onChewai=false;
    public int StepJiagongXichang=3;
    public string videoName="";
	// Use this for initialization
	void Start () {
        cheWaiYuanMian.onClick.AddListener(delegate
        {
            ShowVideoPlayer();
            videoPlayer.GetComponent<VideioPlayerController>().currentSelectedToolname = "";
            videoName = "车外圆面";
            TipsUpdate.Instance.UpdateTipsText("车外圆面：请选择45度、75度或90度车刀.");
            onChewai = true;
            StartCoroutine(ChewaiYuanmian());
            
           
        });
        jiaGongXiChang.onClick.AddListener(delegate
        {
            ShowVideoPlayer();
            videoPlayer.GetComponent<VideioPlayerController>().currentSelectedToolname = "";
            videoName = "加工细长轴";
            TipsUpdate.Instance.UpdateTipsText("加工细长轴：请从工具栏中选择车刀（45度、75度、90度）、顶尖、跟刀架（中心架）。");
            StepJiagongXichang = 3;
            i = 0;
            StartCoroutine(jiaGongXiChangZhou());
        });
	}

   
	
	// Update is called once per frame
	void Update () {
	
	}
    /// <summary>
    /// 控制车外圆面视频的播放
    /// </summary>
    /// <returns></returns>
    IEnumerator ChewaiYuanmian()
    {
        while (onChewai)
        {
            if (videoPlayer.GetComponent<VideioPlayerController>().currentSelectedToolname!="")
            {
                videoName = videoName + videoPlayer.GetComponent<VideioPlayerController>().currentSelectedToolname;
                videoPlayer.GetComponent<VideioPlayerController>().PlayVideoByName(videoName + ".avi");
                TipsUpdate.Instance.UpdateTipsText(videoName);
                onChewai = false;
            }
        yield return null;
        }
    }
        int i = 0;
        string currentName;
    IEnumerator jiaGongXiChangZhou()
    {
        while (i < StepJiagongXichang)
        {
            currentName = videoPlayer.GetComponent<VideioPlayerController>().currentSelectedToolname;
            //Debug.Log(currentName);
            if (i == 0 && (currentName.IndexOf("度车刀")!=-1))
            {
                videoName = videoName + currentName;
                //currentName = "";
                TipsUpdate.Instance.UpdateTipsText("请选择顶尖。");
                i=1;
            }
            if (i==1&&currentName=="顶尖")
            {
                //videoName += currentName;
                TipsUpdate.Instance.UpdateTipsText("请选择中心架（跟刀架）。");
                i=2;

            }
            if (i == 2 && (currentName == "中心架" || currentName == "跟刀架"))
            {
               videoName += currentName;
               videoPlayer.GetComponent<VideioPlayerController>().PlayVideoByName(videoName+".avi");
               TipsUpdate.Instance.UpdateTipsText(videoName);
                i++; 
            }
        yield return null;
        }
    }
    /// <summary>
    /// 显示播放器
    /// </summary>
    void ShowVideoPlayer()
    {
        if (!videoPlayer.activeSelf)
        {
            videoPlayer.SetActive(true);
        }
    }
}
