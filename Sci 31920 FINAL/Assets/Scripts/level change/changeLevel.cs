using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
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

        /*
        SceneManager.LoadScene("World 1-3");

        SceneManager.LoadScene("World 1-4");

        SceneManager.LoadScene("World 2-1");

        SceneManager.LoadScene("World 2-2");

        SceneManager.LoadScene("World 2-3");

        SceneManager.LoadScene("World 2-4");
        */
    }
        
    
}
