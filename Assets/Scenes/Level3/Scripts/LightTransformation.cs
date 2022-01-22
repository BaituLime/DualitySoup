using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LightTransformation : MonoBehaviour
{

    [SerializeField]
    private float angularSpeed = 20;
    [SerializeField]
    private float rotateDuration = 2;
    [SerializeField]
    private float stopDuration = 2;


    private float actionTime;
    private bool IsRotating;

    void Start()
    {
        IsRotating = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (actionTime > 0)
        {
            actionTime -= Time.deltaTime;
            if (IsRotating)
            {
                transform.Rotate(angularSpeed * Time.deltaTime * new Vector3(0, 1, 0), Space.World);
            }
        }
        else
        {
            if (IsRotating)
            {
                actionTime = stopDuration;
            }
            else
            {
                actionTime = rotateDuration;
            }
            IsRotating = !IsRotating;
        }



    }
}
