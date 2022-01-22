using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempButton : MonoBehaviour
{
    public void WDNMD()
    {
        Level4Manager level4Manager = (Level4Manager)GameManager.Instance.CurrentLevelManager;
        level4Manager.GenerateWoodStack();
    }
}
