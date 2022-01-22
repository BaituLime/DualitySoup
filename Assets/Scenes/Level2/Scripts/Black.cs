using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Black : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        PlayerController mainCharacter = collision.transform.GetComponent<PlayerController>();
        if (mainCharacter == null)
            return;

        Level2Manager levelManager = (Level2Manager)GameManager.Instance.CurrentLevelManager;
        if(levelManager.LastTouched is "Black")
            Destroy(collision.gameObject);
        levelManager.LastTouched = "Black";
    }
}
