using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBehavior : MonoBehaviour
{
    public  int coinCount = 0;
    // track if coin touched by player then coin count increases and is destroyed
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            coinCount++;
            Debug.Log("The coin count is " + coinCount + ".");
            Destroy(this.transform.gameObject);
            Debug.Log("Coin collected!");
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
