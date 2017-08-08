using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SanZhuaPanelManager : MonoBehaviour
{
    public Toggle zhuangPei;
    public Toggle baoZha;
    public Toggle yuanLi;

    public GameObject sanzhuakaPan;
    public GameObject sanzhuaKapanYuanli;
    // Use this for initialization
    void Start()
    {
        zhuangPei.onValueChanged.AddListener(delegate(bool isOn)
        {
            sanzhuakaPan.SetActive(isOn);
            if (isOn)
            {
                  Camera.main.GetComponent<CamRot>().mode = sanzhuakaPan.transform;
            }
        });
        baoZha.onValueChanged.AddListener(delegate(bool isOn)
        {
            sanzhuakaPan.SetActive(isOn);
            if (isOn)
            {
                Camera.main.GetComponent<CamRot>().mode = sanzhuakaPan.transform;
            }
        });
        yuanLi.onValueChanged.AddListener(delegate(bool isOn)
        {
            sanzhuakaPan.SetActive(!isOn);
            sanzhuaKapanYuanli.SetActive(isOn);
            if (isOn)
            {
                Camera.main.GetComponent<CamRot>().mode = sanzhuaKapanYuanli.transform;
            }
            //sanzhuakaPan.SetActive(false);
        });
    }

}
