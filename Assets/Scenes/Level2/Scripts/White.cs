using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class White : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        PlayerController mainCharacter = collision.transform.GetComponent<PlayerController>();
        if (mainCharacter == null)
            return;

        Level2Manager levelManager = (Level2Manager)GameManager.Instance.CurrentLevelManager;
        if(levelManager.LastTouched is "White")
            Destroy(collision.gameObject);
        levelManager.LastTouched = "White";
    }
}
