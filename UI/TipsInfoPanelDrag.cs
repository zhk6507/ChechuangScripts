using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TipsInfoPanelDrag : MonoBehaviour, IDragHandler, IPointerDownHandler,IBeginDragHandler,IEndDragHandler
{
    public RectTransform canvas;
    public Vector2 offSet;
    public GameObject tipsView;

    //public bool Timers = false;
    //private float m_timer = 0f;

    void Update()
    {
        //if (Timers)//打开计时器
        //{
        //    m_timer += Time.deltaTime;
        //    if (m_timer>2f)
        //    {
        //        LoadingScripts();
        //        Timers = false;
        //    }
        //}
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 mouseDown = eventData.position;
        Vector2 mouseUGUIPos = new Vector2();
        bool isRect = RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, mouseDown, eventData.enterEventCamera, out mouseUGUIPos);
        if (isRect)
        {
            tipsView.GetComponent<RectTransform>().anchoredPosition = offSet + mouseUGUIPos;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Vector2 mouseDown = eventData.position;
        Vector2 mouseUGUIPos = new Vector2();
        bool isRect = RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, mouseDown, eventData.enterEventCamera, out mouseUGUIPos);
        if (isRect)
        {
            offSet = tipsView.GetComponent<RectTransform>().anchoredPosition - mouseUGUIPos;
        }
    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        Camera.main.GetComponent<CamRot>().enabled = false;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Camera.main.GetComponent<CamRot>().enabled = true;        
    }
}
