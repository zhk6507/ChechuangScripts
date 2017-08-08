using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadTools : MonoBehaviour {
    public Button daoju;
    public Button fujian;
    public string[] daojuNames;
    public string[] fujianNames;
    public Sprite[] backgroundImage;
    public Transform toolbox;
    public ScrollRect toolboxes;
    GameObject prefbTool;
	// Use this for initialization

	void Start () {
       
        daoju.onClick.AddListener(delegate
        {
            LoadDaoJu();
        });
        fujian.onClick.AddListener(delegate
        {
            LoadFujian();
        });
	}
    /// <summary>
    /// 加载车床附件
    /// </summary>
    private void LoadFujian()
    {
        DestroyChild();
        prefbTool = Resources.Load<GameObject>("FujianContent");
        Transform temp = Instantiate<GameObject>(prefbTool).transform;
        temp.parent = toolbox;
        temp.localPosition = Vector3.zero;
        temp.localScale = Vector3.one;
        toolboxes.content = temp.GetComponent<RectTransform>();
    }
    /// <summary>
    /// 加载刀具
    /// </summary>
    private void LoadDaoJu()
    {
        DestroyChild();
        //if (toolbox.childCount == 0)
        //{
            prefbTool = Resources.Load<GameObject>("DaojutoolContent");
            Transform temp = Instantiate<GameObject>(prefbTool).transform;
            temp.parent = toolbox;
            temp.localPosition = Vector3.zero;
            temp.localScale = Vector3.one;
            toolboxes.content = temp.GetComponent<RectTransform>();
        //}
    }
    void DestroyChild()
    {
        //if (toolBoxContent.childCount!=0)
        //{
        //    foreach (Transform child in toolBoxContent)
        //    {
        //        Destroy(child.gameObject);

        //    }
            
        //}
        for (int i = 0; i < toolbox.childCount; i++)
        {
            Destroy(toolbox.GetChild(i).gameObject);

        }  
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
