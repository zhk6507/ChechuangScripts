using UnityEngine;
using System.Collections;
/// <summary>
/// 拖拽手轮
/// </summary>
public class DragTest : MonoBehaviour
{
    public Transform followThis;
    public float limitmax;
    public float limitmin;
    public float velocity_R=10f;
    public float velocity_M=0f;
    
    void OnMouseUp()
    {
        Camera.main.GetComponent<CamRot>().enabled = true;
    }
    
    void OnMouseDrag()
    {
        Camera.main.GetComponent<CamRot>().enabled = false;
        
        if (followThis.position.x >= limitmin && followThis.position.x <= limitmax)
        {
            float speedx = Input.GetAxis("Mouse X");
            Vector3 rotspeed = new Vector3(0, -velocity_R * speedx, 0);
            Vector3 moveSpeed = new Vector3(-velocity_M * speedx, 0, 0);
            transform.Rotate(rotspeed, Space.Self);
            followThis.Translate(moveSpeed, Space.Self);
        }
        else if (followThis.position.x < limitmin)
        {
            followThis.position = new Vector3(limitmin, followThis.position.y, followThis.position.z);
        }
        else if (followThis.position.x > limitmax)
        {
            followThis.position = new Vector3(limitmax, followThis.position.y, followThis.position.z);
        }
    }
}
