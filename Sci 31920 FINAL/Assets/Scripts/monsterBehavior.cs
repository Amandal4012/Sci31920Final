using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterBehavior : MonoBehaviour
{
    // tracks if player touches mob, it is destroyed
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.transform.gameObject);
            Debug.Log("Mob defeated!");
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
