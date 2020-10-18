using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    private Vector2Int gridPos;

    private const int _gridSize = 10;
    public int GridSize { get { return _gridSize; } }


    /// <summary>
    /// Calcualtes grid position based on static int 10 grid size
    /// </summary>
    /// <returns></returns>
    public Vector2 GetGridPos()
    {
        return new Vector2Int(
        Mathf.RoundToInt(transform.position.x / _gridSize) * _gridSize,
        Mathf.RoundToInt(transform.position.z / _gridSize) * _gridSize
        );
    }

}
