using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeLevel : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //load next world
    void OnTriggerEnter(Collider myCollision)
    {

        SceneManager.LoadScene("World 1-2");

    }
        
    
}
