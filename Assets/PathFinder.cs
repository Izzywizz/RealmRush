using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinder : MonoBehaviour
{

    private Dictionary<Vector2Int, WayPoint> _grid = new Dictionary<Vector2Int, WayPoint>();


    /// <summary>
    /// 
    /// </summary>
    private void Start()
    {
        LoadBlocks();
    }


    /// <summary>
    /// 
    /// </summary>
    private void LoadBlocks()
    {
        WayPoint[] waypoints = FindObjectsOfType<WayPoint>();

        for (int i = 0; i < waypoints.Length; i++)
        {
            WayPoint waypoint = waypoints[i];
            Vector2Int waypointGridPos = waypoint.GetGridPos();

            bool isOverlappingBlock = _grid.ContainsKey(waypointGridPos);
            if (isOverlappingBlock)
            {
                Debug.LogWarning("Skipping Overlaping block: " + waypoint);
            }
            else
            {
                _grid.Add(waypointGridPos, waypoint);
            }
        }

        Debug.Log(string.Format("Loaded {0} blocks", _grid.Count));
    }
}
