using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ShowStringFollowMouse : MonoBehaviour {
    public GameObject nameView;
    public Toggle chechuangjiegou;
    public RectTransform ui_canvas;
    public Camera ui_Camera;
    public  string[] partInfo;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (chechuangjiegou.isOn)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    WriteInfoToTips(hit.collider.tag);
                    nameView.GetComponentInChildren<Text>().text = hit.collider.tag;
                    Vector2 temppos = new Vector2();
                    RectTransformUtility.ScreenPointToLocalPointInRectangle(ui_canvas, Input.mousePosition, ui_Camera, out temppos);
                    nameView.GetComponent<RectTransform>().anchoredPosition = temppos;

                    //将屏幕坐标转换为视口坐标
                    //Vector3 pos1=Camera.main.ScreenToViewportPoint(Input.mousePosition);
                    //Vector3 pos2=Camera.main.ScreenToViewportPoint(nameView.transform.position);
                    //Vector3 pos=new Vector3(pos1.x,pos1.y,pos2.z);
                    //nameView.transform.position=Camera.main.ScreenToWorldPoint(pos);

                }
                else
                {
                    nameView.GetComponent<RectTransform>().anchoredPosition = new Vector2(1000, 0);
                }
        }
	}
    /// <summary>
    /// 更新提示框
    /// </summary>
    /// <param name="info"></param>
    void WriteInfoToTips(string info)
    {
        for (int i = 0; i < partInfo.Length; i++)
        {
            int index = partInfo[i].IndexOf('：');
            string currentName=partInfo[i].Substring(0, index);
            if (info==currentName)
            {
                TipsUpdate.Instance.UpdateTipsText(partInfo[i]);
            }
        }
    }
}
