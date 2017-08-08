using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using RenderHeads.Media.AVProVideo;
/// <summary>
/// 左边主菜单管理
/// </summary>
public class LeftPanelManager : MonoBehaviour {
    public Toggle chechuanggaishu;
    public Toggle chechuangjiegou;
    public Toggle yingyongfanwei;
    public Toggle chechuangfujian;
    public Toggle chedao;

    public GameObject chechuangModel;
    public Image chechuangImage;
    public GameObject useRangeBtnPanel;
    public GameObject rightPanel;
    public GameObject chedaoMenu;
    public GameObject videoPlayer;
    public GameObject chedaoModel;
    public GameObject chedaojiegouPanel;
    public GameObject chechuangfujianPanel;
    public GameObject sanzhuakapanModel;
    public GameObject gendaojiaModel;
    public GameObject zhongxinjiaModel;
    public GameObject sanzhuakaPanyuanliModel;
    public GameObject sanzhuakapanPanel;
    public MediaPlayer mp;
    //车船概述文本
    private string chechuanggaishuText;
    public Text tipsText;
	// Use this for initialization
	void Start () {
        chechuanggaishuText = tipsText.text;
        //车床概述
        chechuanggaishu.onValueChanged.AddListener(delegate(bool isOn)
        {
            chechuangImage.gameObject.SetActive(isOn);
            if (isOn)
            {
                TipsUpdate.Instance.UpdateTipsText(chechuanggaishuText);
            }
        });
        //车床结构
        chechuangjiegou.onValueChanged.AddListener(delegate(bool isOn)
        {
            initState();
            chechuangModel.gameObject.SetActive(isOn);
            Camera.main.GetComponent<CamRot>().mode = chechuangModel.transform;
         });
        //应用范围
        yingyongfanwei.onValueChanged.AddListener(delegate(bool isOn)
        {
            initState();
            useRangeBtnPanel.SetActive(isOn);
            rightPanel.SetActive(isOn);
        });
        //车床附件
        chechuangfujian.onValueChanged.AddListener(delegate(bool isOn)
        {
            initState();
            chechuangfujianPanel.SetActive(isOn);
        });
        //车刀
        chedao.onValueChanged.AddListener(delegate(bool isOn)
        {
            initState();
            chedaoMenu.SetActive(isOn);
        });

	}
    /// <summary>
    /// 初始化
    /// </summary>
    private void initState()
    {
        
        TipsUpdate.Instance.UpdateTipsText("");
        chechuangModel.gameObject.SetActive(false);
        //Camera.main.GetComponent<CamRot>().mode = null;
        chechuangImage.gameObject.SetActive(false);
        useRangeBtnPanel.SetActive(false);
        rightPanel.SetActive(false);
        chedaoMenu.SetActive(false);
        videoPlayer.SetActive(false);
        chedaoModel.SetActive(false);
        chedaojiegouPanel.SetActive(false);
        chechuangfujianPanel.SetActive(false);
        sanzhuakapanModel.SetActive(false);
        gendaojiaModel.SetActive(false);
        zhongxinjiaModel.SetActive(false);
        sanzhuakapanPanel.SetActive(false);
        sanzhuakaPanyuanliModel.SetActive(false);
        mp.CloseVideo();
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
