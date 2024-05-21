using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    
    public Vector3 CamOffset = new Vector3(0f, 1.2f, -2.6f);
    private Transform _target;
  //  public bool alive;
    // Start is called before the first frame update
    void Start()
    {
        
        _target = GameObject.Find("Player").transform;
       // bool alive = GetComponent<bool>();
        
        //alive = FindObjectOfType<PlayerBehavior>();
       // Debug.Log(alive.aliveStatus);
       //Debug.Log(alive.ToString());
    }

   
    void LateUpdate()
    {

       // if (aliveStatus)
       // {
            this.transform.position = _target.TransformPoint(CamOffset);
            this.transform.LookAt(_target);
        //}
    }
    // Update is called once per frame
    void Update()
    {

    }
}
