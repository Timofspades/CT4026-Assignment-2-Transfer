using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartSenceScript : MonoBehaviour
{
    //if the box collider colids with anything
    private void OnCollisionEnter(Collision col)
    {
        //if the collider colids with object with the Player tag
        if (col.gameObject.tag == "Player")
        {
            //this reloads current scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    //per frame
    void Update()
    {
        

    }
}
