using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class EditorSnap : MonoBehaviour
{

    [SerializeField]
    [Range(1.0f, 20.0f)]
    private float _gridSize = 10.0f;


    /// <summary>
    /// 
    /// </summary>
    private void Update()
    {
        SnapToGrid(_gridSize);
    }


    /// <summary>
    /// Snaps GameObjects to a gridsize, for example a 10 gridsize;  You move 6 units in x, divided this by 10
    /// which is 0.6, rounded to the nearest int is 1 then multiply by 10 giving you 10.
    /// </summary>
    private void SnapToGrid(float gridSize)
    {
        Vector3 snapPos;
        snapPos.x = Mathf.RoundToInt(transform.position.x / gridSize) * gridSize;
        snapPos.z = Mathf.RoundToInt(transform.position.z / gridSize) * gridSize;

        transform.position = new Vector3(snapPos.x, 0f, snapPos.z);
    }
}
