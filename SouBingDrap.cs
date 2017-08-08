using UnityEngine;
using System.Collections;
/// <summary>
/// 手柄控制主轴
/// </summary>
public class SouBingDrap : MonoBehaviour {
    public Transform zhuzhou;
    private bool isTurn=false;
    public Animator shoubingAnim;
    //void OnMouseEnter()
    //{
    //    Camera.main.GetComponent<CamRot>().enabled = false;
    //}

    void OnMouseUp()
    {
        Camera.main.GetComponent<CamRot>().enabled = true;
    }

    void OnMouseDrag()
    {
        Camera.main.GetComponent<CamRot>().enabled = false;
        float axisY = Input.GetAxis("Mouse Y");
        Debug.Log(axisY);
        if (axisY>0)
        {
            isTurn = true;
            shoubingAnim.SetTrigger("Up");
        }
        else if (axisY < 0)
        {
            isTurn = false;
            shoubingAnim.SetTrigger("Down");
        }
    }
    void Update()
    {
        if (isTurn)
        {
            zhuzhou.Rotate(new Vector3(5, 0, 0));
        }
    }
    
}
