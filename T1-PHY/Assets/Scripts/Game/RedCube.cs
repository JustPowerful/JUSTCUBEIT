using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCube : MonoBehaviour
{
    // Red Cube Gameobject
    public GameObject RCube;

    // Normal Cubes Gameobject array
    public GameObject[] NCube;

    // Sound source
    public AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        // Red Cubes
        RCube = this.gameObject;

        // Normal Cubes
        NCube = GameObject.FindGameObjectsWithTag("Cube");

        // Gets the sound source
        sound = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.tag == "Base")
        {
            // Plays the devil sound
            sound.Play();

            // Destroys itself
            Destroy(RCube, 0.17f);

            // Destroys all the Normal cubes in the scene
            for (var i = 0; i < NCube.Length; i++)
            {
                Destroy(NCube[i]);
            }

        }
    }
}
