using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodStack : InteractThings
{
    public override void Interact()
    {
        Level4Manager levelManager = (Level4Manager) GameManager.Instance.CurrentLevelManager;
        if (levelManager.WoodNumber >= 3)
            levelManager.GotoNext();
    }
}