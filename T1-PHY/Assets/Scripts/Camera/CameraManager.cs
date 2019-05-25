using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    [HideInInspector] // hides the public var
    [Header("Cubes")]
    public int NCubes;

    
    [Header("Scripts")]
    // public int TotalCubes = OCubes + NCubes;
    public CameraShake camshake;

    // Camera variables
    [Header("Cameras")]
    public Camera Cam;


    // Update is called once per frame
    void Update()
    {
        // Sets the variables
        NCubes = GameObject.FindGameObjectsWithTag("Cube").Length;

        // if the Normal Cubes end , the camera shakes
        if (NCubes == 0)
        {
            camshake.enabled = true;

        } else {
            camshake.enabled = false;
        }

    }
}
