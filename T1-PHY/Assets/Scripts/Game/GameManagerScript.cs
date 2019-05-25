using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManagerScript : MonoBehaviour
{
    // Cubes number
    public int CubeInt;
    // Text Display var
    public Text CubeText;

    // Orange Cubes Number
    public int OrangeCubeInt;
    // Orange Cubes Text
    public Text OrangeCubeText;

    // Red Cubes Number
    public int RedCubeInt;
    // Red Cubes Text
    public Text RedCubeText;

    // Respawn Text
    public GameObject RespawnText;

    // Update is called once per frame
    void Update()
    {
        // set the cubes number 
        CubeInt = GameObject.FindGameObjectsWithTag("Cube").Length;
        // sets the UI text to the cubes number
        CubeText.text = "Normal Cubes : " + CubeInt.ToString();

        // sets the orange cubes number
        OrangeCubeInt = GameObject.FindGameObjectsWithTag("OrangeCube").Length;
        OrangeCubeText.text = "Orange Cubes : " + OrangeCubeInt.ToString();

        // sets the red cubes number
        RedCubeInt = GameObject.FindGameObjectsWithTag("RedCube").Length;
        RedCubeText.text = "Red Cubes : " + RedCubeInt.ToString();
        }

    
}
