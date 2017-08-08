using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CheChuangFujianManager : MonoBehaviour {
    public Toggle sanzhuakapanTog;
    public Toggle zhongxinjiaTog;
    public Toggle gendaojiaTog;

    public GameObject sanzhuaPanel;
    public GameObject fujianPanel;
    public GameObject sanzhuaModel;
    public GameObject zhongxinjiaModel;
    public GameObject gendaojiaModel;
    public GameObject sanzhuayuanliModel;
	// Use this for initialization
	void Start () {
        sanzhuakapanTog.onValueChanged.AddListener(delegate(bool isOn)
        {
            InitState();
            sanzhuaPanel.SetActive(isOn);
            sanzhuaModel.SetActive(isOn);
            Camera.main.GetComponent<CamRot>().mode = sanzhuaModel.transform;
        });
        zhongxinjiaTog.onValueChanged.AddListener(delegate(bool isOn)
        {
            InitState();
            zhongxinjiaModel.SetActive(isOn);
            Camera.main.GetComponent<CamRot>().mode = zhongxinjiaModel.transform;
        });
        gendaojiaTog.onValueChanged.AddListener(delegate(bool isOn)
        {
            InitState();
            gendaojiaModel.SetActive(isOn);
            Camera.main.GetComponent<CamRot>().mode = gendaojiaModel.transform;
        });
	}

    void InitState()
    {
        sanzhuayuanliModel.SetActive(false);
        //fujianPanel.SetActive(false);
    }
}
