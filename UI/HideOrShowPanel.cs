using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;

public class HideOrShowPanel : MonoBehaviour
{
    [SerializeField]
    Button hideBtn;
    [SerializeField]
    Button showBtn;
    [SerializeField]
    RectTransform panel;
    public Vector2 initposition;
    public Vector2 targetpostion;
    
    // Use this for initialization
    void Start()
    {
        initposition = panel.localPosition;
        hideBtn.onClick.AddListener(delegate
        {
            panel.DOLocalMove(targetpostion, 0.5f, false);
        });
        showBtn.onClick.AddListener(delegate
        {
            panel.DOLocalMove(initposition, 0.5f, false);
        });
    }
}
