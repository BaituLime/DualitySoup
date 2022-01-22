using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Writed by Geo.
public class CameraFollower : MonoBehaviour
{
    [SerializeField]
    private Transform foucusObj;
    [SerializeField]
    private Vector3 rotateBias;
    [SerializeField]
    private float YOffset;
    [SerializeField]
    private float followDistance;

    // Start is called before the first frame update
    void Start()
    {
        if(foucusObj == null)
        {
            Debug.Log("未设置相机跟随物体！");
        }
    }

    // Update is called once per frame
    void Update()
    {
        AdjustPosition();
        LookAtObj();
        AdjustRotation();
    }

    private void AdjustPosition()
    {
        //背对方向距离
        transform.position = foucusObj.position -foucusObj.forward* followDistance;
        //Z向偏差
        transform.position += new Vector3 (0,YOffset, 0);
    }
    private void AdjustRotation()
    {
        transform.Rotate(rotateBias, Space.Self);
    }

    private void LookAtObj()
    {
        transform.forward = foucusObj.position - transform.position;
    }

}