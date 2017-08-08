using UnityEngine;
using System.Collections;

public class CheChuangInfo : MonoBehaviour {

    public GameObject infoImage;

    void OnMouseDown() 
    {
        infoImage.SetActive(true);
    }
}
