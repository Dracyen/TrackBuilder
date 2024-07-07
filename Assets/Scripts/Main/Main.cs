using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField]
    GridManager gridManager;
    [SerializeField]
    RaycastManager raycastManager;
    [SerializeField]
    CameraManager cameraManager;
    [SerializeField]
    InputManager inputManager;
    [SerializeField]
    Transform indicator;

    List<NodeInfo> nodes;
    Node selectedNode;


    // Start is called before the first frame update
    void Start()
    {
        gridManager.Initialize();
        inputManager.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        indicator.position = gridManager.GetClosestSlot(raycastManager.GetRaycastHitPosition());
    }
}
