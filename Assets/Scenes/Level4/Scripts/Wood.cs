using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : InteractThings
{
    public override void Interact()
    {
        Level4Manager levelManager = (Level4Manager) GameManager.Instance.CurrentLevelManager;
        levelManager.CurrentInteractItem = null;
        levelManager.WoodNumber++;
        Debug.Log(levelManager.WoodNumber);
        Destroy(transform.parent.gameObject);
    }
}