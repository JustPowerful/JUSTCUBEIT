using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WhenClickRemove : MonoBehaviour
{

    public AudioSource Boom;

    // Gameobject variable
    public GameObject Cube;

    private void Start()
    {

        // sets the boooom sound
        Boom = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        // Destroys the game object 
        
        Cube = this.gameObject;
        //play the audio
        Boom.Play();     
        // Destroys after the audio plays
        Destroy(this.gameObject, 0.17f);
    }
}
