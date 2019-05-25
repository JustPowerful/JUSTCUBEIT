using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeCube : MonoBehaviour
{
    public GameObject OrangeCb;
    public AudioSource Boom;

    // Start is called before the first frame update
    void Start()
    {
        // sets the gameobject
        OrangeCb = this.gameObject;

        // sets the audio source to booom sound 
        Boom = GetComponent<AudioSource>();
        
    }

    private void OnCollisionEnter(Collision coll)
    {
        // Destroys the Orange Cube if it collides with the Base
        if (coll.collider.tag == "Base")
        {
            // Plays the audio after waiting for the object to destroy
            Boom.Play();
            Destroy(OrangeCb, 0.17f);
        }
    }
}
