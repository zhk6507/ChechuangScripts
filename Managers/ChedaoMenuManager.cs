using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChedaoMenuManager : MonoBehaviour {
    [SerializeField]
    Toggle chedaoJiegou;
    [SerializeField]
    Toggle FuzhuPingmian;
    [SerializeField]
    GameObject chedaoModel;
    [SerializeField]
    GameObject videoPlayer;
    [SerializeField]
    GameObject chedaojiegouMenu;
	// Use this for initialization
	void Start () {
        chedaoJiegou.onValueChanged.AddListener(delegate(bool isOn)
        {
            chedaoModel.SetActive(isOn);
            chedaojiegouMenu.SetActive(isOn);
            if (isOn)
            {
                Camera.main.GetComponent<CamRot>().mode = chedaoModel.transform;
            }
        });
        FuzhuPingmian.onValueChanged.AddListener(delegate(bool isOn)
        {
            videoPlayer.SetActive(isOn);
            videoPlayer.GetComponent<VideioPlayerController>().PlayVideoByName("车刀的辅助平面.avi");
            
            
            
        });
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
