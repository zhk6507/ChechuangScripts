using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChedaoThreeMenuManager : MonoBehaviour {
    /// <summary>
    /// 车刀结构三级菜单
    /// </summary>
    public Toggle qiexiao;
    public Toggle jiachi;
    public Toggle daojian;
    public Toggle fuqiexiaoren;
    public Toggle zhuqiedaoren;
    public Toggle fuhoudaomian;
    public Toggle zhuhoudaomian;
    public Toggle qiamdaomian;

    public GameObject qiexiaoPanel;
    public GameObject jiachiCube;
    public GameObject daojianCube;
    public GameObject fuqiexiaorenCube;
    public GameObject zhuqiexiaorenCube;
    public GameObject fuhoudaomianCube;
    public GameObject zhuhoudaomianCube;
    public GameObject qiandaomianCube;

	// Use this for initialization
	void Start () {
        qiexiao.onValueChanged.AddListener(delegate(bool isOn)
        {
            qiexiaoPanel.SetActive(isOn);
        });
        jiachi.onValueChanged.AddListener(delegate(bool isOn)
        {
            jiachiCube.SetActive(isOn);
        });
        daojian.onValueChanged.AddListener(delegate(bool isOn)
        {
            daojianCube.SetActive(isOn);
        });
        fuqiexiaoren.onValueChanged.AddListener(delegate(bool isOn)
        {
            fuqiexiaorenCube.SetActive(isOn);
        });
        zhuqiedaoren.onValueChanged.AddListener(delegate(bool isOn)
        {
            zhuqiexiaorenCube.SetActive(isOn);
        });
        fuhoudaomian.onValueChanged.AddListener(delegate(bool isOn)
        {
            fuhoudaomianCube.SetActive(isOn);
        });
        zhuhoudaomian.onValueChanged.AddListener(delegate(bool isOn)
        {
            zhuhoudaomianCube.SetActive(isOn);
        });
        qiamdaomian.onValueChanged.AddListener(delegate(bool isOn)
        {
            qiandaomianCube.SetActive(isOn);
        });
	}
}
