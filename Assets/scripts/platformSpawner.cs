using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;
    //public GameObject spikeplatformPrefab;
    //public GameObject[] movingPlatforms;

    //public GameObject breakablePlatform;

    public float platform_Spawn_Time = 2f;
    private float current_Platform_Spawn_Timer;
    private int platform_Spawn_Count;
    public float min_x = -2f, max_x = 2f;
    //public float FireRate = 2.0f;
    //public float nextFire = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(platformSpawn());
        current_Platform_Spawn_Timer = platform_Spawn_Time;
    }

    // Update is called once per frame
    void Update()
    {
        //SpawnPlatform();
        Invoke("platformSpawn",1f);
        //InvokeRepeating("plt", 1f, 1f);
    }
    /*void plt()
    {
        Vector2 temp = transform.position;
        temp.x = Random.Range(min_x, max_x);
        temp.y = -5;
        Instantiate(platformPrefab, temp, Quaternion.identity);
        //CancelInvoke();
    }*/
    void platformSpawn()
    {
        current_Platform_Spawn_Timer += Time.deltaTime;
        if (current_Platform_Spawn_Timer >= platform_Spawn_Time)
        {
            Vector2 temp = transform.position;
            temp.x = Random.Range(min_x, max_x);
            temp.y = -5;
            Instantiate(platformPrefab, temp, Quaternion.identity);
            
            current_Platform_Spawn_Timer = 0f;
        }
    }
   /* void SpawnPlatform()
    {
        current_Platform_Spawn_Timer += Time.deltaTime;
        if (current_Platform_Spawn_Timer >= platform_Spawn_Time)
        {
            platform_Spawn_Count++;
            Vector3 temp = transform.position;
            temp.x = Random.Range(min_x, max_x);

            GameObject newPlatform = null;

            if (platform_Spawn_Count < 2)
            {
                newPlatform = Instantiate(platformPrefab, temp, Quaternion.identity);
            }
            else if (platform_Spawn_Count == 2)
            {
                if (Random.Range(0, 2) > 0)
                {
                    newPlatform = Instantiate(platformPrefab, temp, Quaternion.identity);
                }
                else
                {
                    newPlatform = Instantiate(movingPlatforms[Random.Range(0, movingPlatforms.Length)], temp, Quaternion.identity);
                }
            }
            else if (platform_Spawn_Count == 3)
            {
                if (Random.Range(0, 2) > 0)
                {
                    newPlatform = Instantiate(platformPrefab, temp, Quaternion.identity);
                }
                else
                {
                    newPlatform = Instantiate(spikeplatformPrefab, temp, Quaternion.identity);
                }
            }
            else if (platform_Spawn_Count == 4)
            {
                if (Random.Range(0, 2) > 0)
                {
                    newPlatform = Instantiate(platformPrefab, temp, Quaternion.identity);
                }
                else
                {
                    newPlatform = Instantiate(breakablePlatform, temp, Quaternion.identity);
                }
                platform_Spawn_Count = 0;
            }
            newPlatform.transform.parent = transform;
            current_Platform_Spawn_Timer = 0f;
        }
    
    }*/
}
