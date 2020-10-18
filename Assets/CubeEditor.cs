using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
[SelectionBase]
public class CubeEditor : MonoBehaviour
{

    [SerializeField]
    [Range(1.0f, 20.0f)]
    private float _gridSize = 10.0f;

    private TextMesh _textMesh = null;

    /// <summary>
    /// 
    /// </summary>
    private void Update()
    {
        SnapToGrid(_gridSize);
    }


    /// <summary>
    /// Snaps GameObjects to a gridsize, for example a 10 gridsize;  You move 6 units in x, divided this by 10
    /// which is 0.6, rounded to the nearest int is 1 then multiply by 10 giving you 10 and setting its position.
    /// Then it Sets Label text on Top Quad by finding the first TextMesh it finds on the GameObject and dividing by the grid size to get 0,1 etc
    /// </summary>
    private void SnapToGrid(float gridSize)
    {
        Vector3 snapPos;
        snapPos.x = Mathf.RoundToInt(transform.position.x / gridSize) * gridSize;
        snapPos.z = Mathf.RoundToInt(transform.position.z / gridSize) * gridSize;

        transform.position = new Vector3(snapPos.x, 0f, snapPos.z);

        // TODO Use alt method to find this TextMesh reference in child (if it breaks).
        _textMesh = GetComponentInChildren<TextMesh>();
        _textMesh.text = string.Format("{0},{1}", snapPos.x / gridSize, snapPos.z/ gridSize);
    }
}
