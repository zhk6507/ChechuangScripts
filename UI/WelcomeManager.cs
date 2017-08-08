using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WelcomeManager : MonoBehaviour {
    [SerializeField]
    Button goOn;
    [SerializeField]
    Button exit;
	// Use this for initialization
	void Start () {
        goOn.onClick.AddListener(delegate
        {
            SceneManager.LoadScene(1);
        });
        exit.onClick.AddListener(delegate
        {
            Application.Quit();
        });
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
