using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// 开启或关闭一个对象
/// </summary>
public class OnOff : MonoBehaviour {

    public GameObject view;
    private bool isOn = true;
	// Use this for initialization
	void Start () {
        GetComponent<Button>().onClick.AddListener(delegate
        {
            isOn = !isOn;
            OnOffFunction(isOn);
        });
	}

    private void OnOffFunction(bool isOn)
    {
        view.gameObject.SetActive(isOn);
    }
	
}
