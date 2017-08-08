using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Boom : MonoBehaviour
{
    /// <summary>
    /// 模型爆炸视图和装配视图
    /// </summary>
    public GameObject model;
    public List<Transform> modelpartss;
    public List<Transform> childmodelparts = new List<Transform>();//需要横向爆炸的子物体
    public List<float> distances = new List<float>();//与爆炸点距离
    private List<Vector3> original = new List<Vector3>();//原始位置
    private List<Vector3> targets = new List<Vector3>();//目标位置
    public float boomSpeed = 3;//爆炸速度
    //爆炸开关
    public Toggle boomSwitch;
    private bool isBoom = false;
    //装配开关
    public Toggle zhuangpeiSwitch;
    private bool isZhuangPei = false;
    // Use this for initialization
    void Start()
    {
        //modelparts = model.GetComponentsInChildren<Transform>();
        //List<Transform> temp = new List<Transform>(modelparts);
        //List<Transform> deleted= temp.FindAll(delegate(Transform t)
        //{
        //    return temp.Contains(t.parent);
        //});
        //foreach (Transform item in deleted)
        //{
        //    temp.Remove(item);
        //}
        //modelpartss = temp;

        for (int i = 0; i < model.transform.childCount; i++)
			{
                modelpartss.Add(model.transform.GetChild(i));
			    
			}
        foreach (Transform item in modelpartss)
        {
            Debug.Log(item.gameObject.name);
        }
        //纵向爆炸
        for (int i = 0; i < modelpartss.Count; i++)
        {
            original.Add(modelpartss[i].localPosition);
            distances.Add(model.transform.localPosition.x - modelpartss[i].localPosition.x);
            targets.Add(new Vector3((model.transform.localPosition.x - modelpartss[i].localPosition.x) * -4, modelpartss[i].transform.localPosition.y, modelpartss[i].transform.localPosition.z));
        }
        //横向爆炸
        //for (int i = 0; i < childmodelparts.Count; i++)
        //{
        //    modelpartss.Add(childmodelparts[i]);
        //    original.Add(childmodelparts[i].localPosition);
        //    distances.Add(model.transform.localPosition.y - modelpartss[i].localPosition.y);
        //    targets.Add(new Vector3(childmodelparts[i].parent.localPosition.x, (modelpartss[i].parent.localPosition.y - modelpartss[i].localPosition.y) * -2, childmodelparts[i].parent.localPosition.z));
        //}

        boomSwitch.onValueChanged.AddListener(delegate(bool isOn)
        {
            isBoom = isOn;
        });
        zhuangpeiSwitch.onValueChanged.AddListener(delegate(bool isOn)
        {
            isZhuangPei = isOn;
        });

    }

    // Update is called once per frame
    void Update()
    {
        if (isBoom)
        {
            float step = boomSpeed * Time.deltaTime;
            for (int i = 0; i < modelpartss.Count; i++)
            {
                modelpartss[i].localPosition = Vector3.MoveTowards(modelpartss[i].localPosition, targets[i], step);
            }

        }
        if (isZhuangPei)
        {
            float step = boomSpeed * Time.deltaTime;
            for (int i = 0; i < modelpartss.Count; i++)
            {
                modelpartss[i].localPosition = Vector3.MoveTowards(modelpartss[i].localPosition, original[i], step);
            }
        }

    }
    //IEnumerator ModelBoom()
    //{
    //    float step = boomSpeed * Time.deltaTime;
    //    for (int i = 0; i < modelparts.Length; i++)
    //    {
    //        modelparts[i].position=Vector3.MoveTowards(modelparts[i].position, targets[i], step);

    //    }
    //    yield return null;
    //}
}
