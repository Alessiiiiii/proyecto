using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 newPosition;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Star Game");
        transform.position = newPosition;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Game runnig");
        if (Input.GetKey(KeyCode.P))
        {
            Debug.Log("Key P preseed");
            transform.position = newPosition;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0f, speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0f, 0f);
        }
    }

}
