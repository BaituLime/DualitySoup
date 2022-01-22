using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class PlayerUniversalController : PlayerController
{
    [SerializeField] private float RotatingSpeed = 10f;
    protected override void Start()
    {
        // Register Level Manager.
        GameManager.Instance.RegisterLevelManager(this, LevelNumber);
        // Get Components.
        MyRigidbody = GetComponent<Rigidbody>();
    }

    public override void Move(int direction)
    {
        if (MyRigidbody == null)
            return;

        var theTransform = transform;
        if (direction == 0)
            MyRigidbody.MovePosition(theTransform.position + theTransform.forward * MovingSpeed * Time.deltaTime);
        else if (direction == 1)
            MyRigidbody.MovePosition(theTransform.position - theTransform.forward * MovingSpeed * Time.deltaTime);
        else if (direction == 2)
            MyRigidbody.MovePosition(theTransform.position - theTransform.right * MovingSpeed * Time.deltaTime);
        else if (direction == 3)
            MyRigidbody.MovePosition(theTransform.position + theTransform.right * MovingSpeed * Time.deltaTime);
    }

    public void Turn(float direction)
    {
        if (MyRigidbody == null)
            return;
        //
        // Vector3 aim = Vector3.right*direction * RotatingSpeed * Time.deltaTime;
        // Debug.Log(aim);
        // MyRigidbody.DORotate(aim, 2 * Time.deltaTime);
        transform.Rotate(Vector3.up,direction * RotatingSpeed * Time.deltaTime,Space.Self);
    }
}