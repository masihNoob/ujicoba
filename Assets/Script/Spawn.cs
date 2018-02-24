using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject ballprefab;            // Apple Object in Scene (Sprite)
    //public GameObject badApple;         // Bad Apple Object in Scene (Sprite)

    public float spawnTime = 1f;            // How long between each spawn.

    private float timer = 0; //counting timer, reset after calling SpawnRandom() function
    private int randomNumber;           //variable for storage of an random Number

    void Update()
    {

        timer += Time.deltaTime;   // Timer Counter
        if (timer > spawnTime)
        {
            SpawnRandom();          //Calling method SpawnRandom()
            timer = 0;              //Reseting timer to 0
        }

    }

    public void SpawnRandom()
    {
		Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(600, Screen.height), Camera.main.farClipPlane / 2));
        //Creating random Vector3 position
        //ballclone = Instantiate(ballprefab, transform.position, Quaternion.identity) as GameObject;
        Instantiate(ballprefab, screenPosition, Quaternion.identity);
        
    }
}