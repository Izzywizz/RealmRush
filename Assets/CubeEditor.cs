﻿using UnityEngine;


[ExecuteInEditMode]
[SelectionBase]
public class CubeEditor : MonoBehaviour
{

    [SerializeField]
    [Range(1.0f, 20.0f)]
    private float _gridSize = 10.0f;

    [SerializeField]
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
    /// Then it Sets the Label text on the Top Quad and dividing by the grid size to get 0,1 etc
    /// </summary>
    private void SnapToGrid(float gridSize)
    {
        Vector3 snapPos;
        snapPos.x = Mathf.RoundToInt(transform.position.x / gridSize) * gridSize;
        snapPos.z = Mathf.RoundToInt(transform.position.z / gridSize) * gridSize;

        transform.position = new Vector3(snapPos.x, 0f, snapPos.z);

        if (_textMesh != null)
        {
            string labelText = string.Format("{0},{1}", snapPos.x / gridSize, snapPos.z / gridSize);
            _textMesh.text = labelText;

            gameObject.name = string.Format("Cube {0}", labelText);
        }
    }
}
