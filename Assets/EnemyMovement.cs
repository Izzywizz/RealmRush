using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private List<WayPoints> _paths = new List<WayPoints>();


    /// Start is called before the first frame update
    private void Start()
    {
        PrintAllWaypoints();
    }


    /// <summary>
    /// 
    /// </summary>
    private void PrintAllWaypoints()
    {
        for (int i = 0; i < _paths.Count; i++)
        {
            Debug.Log(_paths[i].name);
        }
    }
}
