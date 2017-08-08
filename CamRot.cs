using UnityEngine;
using System.Collections;

public class CamRot : MonoBehaviour {
    public Transform mode;
   // public GameObject camer;
    private float speed =5f;
    public bool Ins = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (Camera.main.fieldOfView <= 59.5)
            {
                Camera.main.fieldOfView += 2;

            }
            if (Camera.main.fieldOfView <= 20)
            {
                Camera.main.fieldOfView += 0.5f;

            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {

            if (Camera.main.fieldOfView > 30)
            {
                Camera.main.fieldOfView -= 2;

            }
            if (Camera.main.fieldOfView >= 30)
            {
                Camera.main.fieldOfView -= 0.5f;

            }
        }
        if (Ins)
        {
            mode.RotateAround(mode.transform.position, Vector3.up, speed * -Input.GetAxis("Mouse X"));
            mode.RotateAround(mode.transform.position, Vector3.right, speed * -Input.GetAxis("Mouse Y"));
        }
        if (Input.GetMouseButton(0))
        {
            Ins = true;
        }
        else
        {
            Ins = false;
        }

    }
}
