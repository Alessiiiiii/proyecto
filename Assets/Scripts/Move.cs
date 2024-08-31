using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 newPosition;
    public float speed;
    public Vector2 inputVector;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Star Game");
        transform.position = newPosition;
    }

    // Update is called once per frame
    void Update()
    {
        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");

        transform.Translate(inputVector.x*speed,0f, inputVector.y*speed);

       
    }

}
