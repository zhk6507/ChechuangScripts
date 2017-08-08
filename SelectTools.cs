using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SelectTools : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Button>().onClick.AddListener(delegate
        {
            if (GameObject.Find("VideoPlayer")!=null)
            {
             GameObject.Find("VideoPlayer").GetComponent<VideioPlayerController>().currentSelectedToolname = GetComponentInChildren<Text>().text;
                
            }
            //Debug.Log(GameObject.Find("VideoPlayer").GetComponent<VideioPlayerController>().currentSelectedToolname);
        });
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
