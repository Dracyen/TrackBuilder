using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [Header("References:")]
    [SerializeField]
    Transform trackCenter;
    [SerializeField]
    Transform raycastPlane;
    [SerializeField]
    LineRenderer lineX;
    [SerializeField]
    LineRenderer lineZ;
    [SerializeField]
    LineRenderer border;

    [Space, Header("Values:")]
    [SerializeField]
    Vector2Int slotCount;
    [SerializeField]
    Vector2 gridLength;

    NodeInfo[,] grid;
    public NodeInfo[,] Grid { get; private set; }

    private float nodeSpacingX { get { return gridLength.x / (slotCount.x - 1); } }
    private float nodeSpacingZ { get { return gridLength.y / (slotCount.y - 1); } }

    public NodeInfo GetNode(int index1, int index2)
    {
        return grid[index1, index2];
    }

    private void SetupGrid()
    {
        grid = new NodeInfo[slotCount.x, slotCount.y];

        //SETUP GRID VISUALS
        lineX.positionCount = slotCount.x * 2 - 2;
        lineZ.positionCount = slotCount.y * 2 - 2;
        border.positionCount = 4;

        //SETUP HORIZONTAL LINES
        Vector3 targetPosition = new Vector3(0, lineX.transform.position.y, 0);
        bool smallStep = false;

        for (int i = 0; i < lineX.positionCount; i++)
        {
            if(smallStep)
            {
                targetPosition.x = targetPosition.x + nodeSpacingX;
            }
            else
            {
                if(targetPosition.z > 0)
                    targetPosition.z = 0;
                else
                    targetPosition.z = gridLength.y;
            }

            lineX.SetPosition(i, targetPosition);
            smallStep = !smallStep;
        }

        //SETUP VERTICAL LINES
        targetPosition = new Vector3(0, lineZ.transform.position.y, 0);
        smallStep = false;

        for (int i = 0; i < lineZ.positionCount; i++)
        {
            if (smallStep)
            {
                targetPosition.z = targetPosition.z + nodeSpacingZ;
            }
            else
            {
                if (targetPosition.x > 0)
                    targetPosition.x = 0;
                else
                    targetPosition.x = gridLength.x;
            }

            lineZ.SetPosition(i, targetPosition);
            smallStep = !smallStep;
        }

        //SETUP BORDER
        border.SetPosition(0, new Vector3(0, border.transform.position.y, 0));
        border.SetPosition(1, new Vector3(gridLength.x, border.transform.position.y, 0));
        border.SetPosition(2, new Vector3(gridLength.x, border.transform.position.y, gridLength.y));
        border.SetPosition(3, new Vector3(0, border.transform.position.y, gridLength.y));

        //RECENTER GRID
        targetPosition = new Vector3(gridLength.x / 2, 0, gridLength.y / 2);

        trackCenter.position = targetPosition;
        raycastPlane.position = targetPosition;

        raycastPlane.localScale = new Vector3((gridLength.x + (gridLength.x / slotCount.x * 2)) / 10, 1, (gridLength.y + (gridLength.y / slotCount.y * 2)) / 10);
    }

    public void Initialize()
    {
        SetupGrid();
    }

    public Vector3 GetClosestSlot(Vector3 originalPos)
    {
        Vector3 closestSlot = Vector3.zero;

        closestSlot.x = Mathf.RoundToInt(originalPos.x / nodeSpacingX) * nodeSpacingX;
        closestSlot.y = raycastPlane.position.y;
        closestSlot.z = Mathf.RoundToInt(originalPos.z / nodeSpacingZ) * nodeSpacingZ;

        return closestSlot;
    }
}
