using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{

    // Cubes number
    public int OrangeCubeInt;
    public int RedCubeInt;

    // Random percentage number
    public int randomint;


    [Header("Don't touch this")]
    // Spawner
    public GameObject Spawner;

    [Header("Prefab Settings")]
    // Prefabs 
    public GameObject NCube;
    public GameObject RCube;
    public GameObject OCube;

    // Random prefabs
    List<GameObject> PrefabList = new List<GameObject>();



    // Start is called before the first frame update
    void Start()
    {
        // later
    }

    // Update is called once per frame
    void Update()
    {
        // random int
        randomint = Random.Range(0, 2);


        // Orange Cubes number 
        OrangeCubeInt = GameObject.FindGameObjectsWithTag("OrangeCube").Length;
        RedCubeInt = GameObject.FindGameObjectsWithTag("RedCube").Length;

        if (OrangeCubeInt == 0)
        {
            // gets the Spawner Gameobject
            Spawner = this.gameObject;
            // Gets the postion

            PrefabList.Add(NCube);
            PrefabList.Add(OCube);

            // spawns the Ocube and the white cube
            int PrefabNum = Random.Range(0, 2);
            Instantiate(PrefabList[PrefabNum], new Vector3(Spawner.transform.position.x, Spawner.transform.position.y, Spawner.transform.position.z), Quaternion.identity);
            
            if(Random.value > 0.6)
            {
                Instantiate(PrefabList[PrefabNum], new Vector3(Spawner.transform.position.x, Spawner.transform.position.y + 1, Spawner.transform.position.z), Quaternion.identity);
            }
            
            if(Random.value > 0.5)
            {
                Instantiate(PrefabList[PrefabNum], new Vector3(Spawner.transform.position.x, Spawner.transform.position.y + 2, Spawner.transform.position.z), Quaternion.identity);
            }
            
            if(Random.value > 0.3)
            {
                Instantiate(PrefabList[PrefabNum], new Vector3(Spawner.transform.position.x, Spawner.transform.position.y + 3, Spawner.transform.position.z), Quaternion.identity);
            }
            
            if (Random.value > 0.9)
            {
                Instantiate(RCube, new Vector3(Spawner.transform.position.x, Spawner.transform.position.y + 4, Spawner.transform.position.z), Quaternion.identity);
            }

        }
    }
}
