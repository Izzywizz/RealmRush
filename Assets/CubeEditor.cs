using UnityEngine;


[ExecuteInEditMode]
[SelectionBase]
[RequireComponent(typeof(WayPoint))]
public class CubeEditor : MonoBehaviour
{

    private WayPoint _waypoint;

    private void Awake()
    {
        _waypoint = GetComponent<WayPoint>();
    }


    /// <summary>
    /// 
    /// 
    /// </summary>
    private void Update()
    {
        SnapToGrid();
        UpdateLabel();
    }


    /// <summary>
    /// Snaps GameObjects to a gridsize, for example a 10 gridsize;  You move 6 units in x, divided this by 10
    /// which is 0.6, rounded to the nearest int is 1 then multiply by 10, giving you 10 and setting its position 10 in the desired x/ z.
    /// Then it Sets the Label text on the Top Quad and dividing by the grid size to get 0,1 etc
    /// </summary>
    private void SnapToGrid()
    {
        transform.position = new Vector3(
            _waypoint.GetGridPos().x, // x
            0f, 
            _waypoint.GetGridPos().y  // z
            );
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="gridSize"></param>
    private void UpdateLabel()
    {
        int gridSize = _waypoint.GridSize;
        TextMesh textMesh = GetComponentInChildren<TextMesh>();

        if (textMesh != null && _waypoint != null)
        {
            string labelText = string.Format("{0},{1}", 
                _waypoint.GetGridPos().x / gridSize, 
                _waypoint.GetGridPos().y / gridSize);

            textMesh.text = labelText;

            gameObject.name = string.Format("Cube {0}", labelText);
        }
    }
}
