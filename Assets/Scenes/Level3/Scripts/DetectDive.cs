using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectDive : MonoBehaviour
{
    private float DivingTimer = 0f;
    private bool IsDiving = false;

    [SerializeField] private Transform LightTransform;
    [SerializeField] private float MaxDivingTime = 3f;

    private void Update()
    {
        if (IsDiving)
        {
            DivingTimer -= Time.deltaTime;
            // TODO: update UI.
            if (DivingTimer <= 0)
                Destroy(gameObject);
        }
        else if (DivingTimer < MaxDivingTime)
        {
            DivingTimer += Time.deltaTime;
            // TODO: update UI.
            if (DivingTimer > MaxDivingTime)
                DivingTimer = MaxDivingTime;
        }

        Vector3 myPosition = transform.position;
        myPosition.y = 0.05f;
        Ray ray = new Ray(myPosition, -(LightTransform.rotation * Vector3.forward).normalized);
        //Debug.DrawRay(myPosition, -(LightTransform.rotation * Vector3.forward).normalized * 100f, Color.red);
        if (!Physics.Raycast(ray, out var hit, float.PositiveInfinity))
        {
            if(!IsDiving)
                Destroy(gameObject);
        }
    }

    public void Dive()
    {
        IsDiving = true;
    }

    public void SetIdle()
    {
        IsDiving = false;
    }
}