using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikes : MonoBehaviour
{
    //SceneLoader sceneLoader;
    [SerializeField] SceneLoader sceneLoader;
    private void Start()
    {
        //sceneLoader = FindObjectOfType<SceneLoader>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        Destroy(collision.gameObject);
        sceneLoader.LoadNextScene();

    }
}
