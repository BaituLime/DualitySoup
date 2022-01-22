using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

// Player`s main character controller.
public class PlayerController : MonoBehaviour
{
    // Only one player.
    public static PlayerController Instance { get; private set; } = null;

    private Rigidbody MyRigidbody = null;

    public String LevelNumber = "Unknown";
    public float MovingSpeed = 5f;
    public float JumpStrength = 10f;

    private void Awake()
    {
        // Only one player.
        if (Instance != null)
            Destroy(gameObject);
        else
            Instance = this;
    }

    private void Start()
    {
        // Register Level Manager.
        GameManager.Instance.RegisterLevelManager(this, LevelNumber);
        // Get Components.
        MyRigidbody = GetComponent<Rigidbody>();
    }

    private void OnDestroy()
    {
        Instance = null;
    }

    public void Move(int direction)
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

    public void SetIdle()
    {
        // TODO.
    }

    public void Jump()
    {
        if (MyRigidbody.velocity.y < -10)
            return;
        MyRigidbody.AddForce(Vector3.up * JumpStrength);
    }
}