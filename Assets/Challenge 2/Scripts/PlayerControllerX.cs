using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float spawnDogTimer = 0.7f;
    private float lastSpawnTime = 0f;

    // Update is called once per frame

    void Update()
    {
        //check if the time the game started - the last time the dog was spawned is greater than or equal to the spawnDogTimer
        if (Input.GetKeyDown(KeyCode.Space) && Time.time - lastSpawnTime >= spawnDogTimer)
        {
            
            SpawnDog();
            //for debugging
            Debug.Log("space button pressed");
            //set lastSpawnTime to Time.time 
            lastSpawnTime = Time.time;
       } 
    }
    void SpawnDog()
    {
 // On spacebar press, send dog
        
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        
    }

}
