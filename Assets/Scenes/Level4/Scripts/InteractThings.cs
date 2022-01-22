using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractThings : MonoBehaviour
{
    protected void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerController>()==null)
            return;

        Level4Manager levelManager = (Level4Manager) GameManager.Instance.CurrentLevelManager;
        levelManager.CurrentInteractItem = this;
    }

    protected void OnTriggerExit(Collider other)
    {
        if(other.GetComponent<PlayerController>()==null)
            return;

        Level4Manager levelManager = (Level4Manager) GameManager.Instance.CurrentLevelManager;
        if (levelManager.CurrentInteractItem == this)
            levelManager.CurrentInteractItem = null;
    }

    public abstract void Interact();
}
