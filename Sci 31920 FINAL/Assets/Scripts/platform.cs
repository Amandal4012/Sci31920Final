using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    public List<Transform> waypoints;
    public float moveSpeed;
    public int target;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // the data of where and how fast the platform will move for how long
    transform.position = Vector3.MoveTowards(transform.position, waypoints[target].position, moveSpeed * Time.deltaTime);    
    }

    private void FixedUpdate()
    {

        // have the platform go back and forth between waypoints
        
        if (transform.position == waypoints[target].position)
        {
            if (target == waypoints.Count-1)
            {
                target = 0;
            }
            else
            {
                target += 1;
            }
            return;
        }
        
    }
}
