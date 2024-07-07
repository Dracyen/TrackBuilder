using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RaycastManager : MonoBehaviour
{
    [SerializeField]
    LayerMask layerMask;
    [SerializeField]
    Camera currentCamera;

    Ray ray;
    RaycastHit hit;

    private void Awake()
    {
        if (currentCamera == null)
            currentCamera = Camera.main;
    }

    void Update()
    {
        DrawRaycast();
    }

    private void DrawRaycast()
    {
        ray = currentCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(ray.origin, ray.direction * 1000, Color.yellow);
            Debug.Log("Did Hit");
        }
        else
        {
            Debug.DrawRay(ray.origin, ray.direction * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(hit.point, 0.5f);
    }

    public Vector3 GetRaycastHitPosition()
    {
        return hit.point;
    }
}
