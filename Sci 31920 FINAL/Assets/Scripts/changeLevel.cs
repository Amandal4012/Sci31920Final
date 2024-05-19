using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeLevel : MonoBehaviour
{
   // int changelevel = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider myCollision)
    {
        Debug.Log("It collides!");

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
