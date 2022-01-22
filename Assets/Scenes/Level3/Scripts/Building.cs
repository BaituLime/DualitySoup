using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Building : MonoBehaviour
{
    [SerializeField]
    private float scaleSpeed;

    private float scaleFactor;
    private bool IsScaling;

    void Start()
    {
        IsScaling = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsScaling)
        {
            return;
        }
        IsScaling = true;
        scaleFactor = Random.Range(0.5f, 3.0f);
        transform.DOScaleY(scaleFactor, 3).OnComplete(()=> {
            IsScaling = false;
        });

    }
}
