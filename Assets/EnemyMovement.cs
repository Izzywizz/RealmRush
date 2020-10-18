using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private List<WayPoint> _paths = new List<WayPoint>();

    private Coroutine _pathCoroutine = null;

    /// Start is called before the first frame update
    private void Start()
    {
        if (_pathCoroutine == null)
        {
            _pathCoroutine = StartCoroutine(FollowPath());
        }
    }


    /// <summary>
    /// 
    /// </summary>
    private IEnumerator FollowPath()
    {
        Debug.Log("Starting patrol...");

        for (int i = 0; i < _paths.Count; i++)
        {
            WayPoint waypoint = _paths[i];

            Debug.Log("Visiting: " + waypoint.name);

            transform.position = waypoint.transform.position;
            yield return new WaitForSeconds(1.0f);
        }

        Debug.Log("Ending patrol");
        _pathCoroutine = null;
    }
}
