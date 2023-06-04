using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float moveSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            Vector2 tempPos = transform.position;
            tempPos.x = tempPos.x -
                moveSpeed + Time.deltaTime;
            transform.position = tempPos;
        }
        else if(Input.GetKey(KeyCode.D))
        {
            Vector2 tempPos = transform.position;
            tempPos.x = tempPos.x + moveSpeed + Time.deltaTime;
            transform.position = tempPos;
        }

    }
}
