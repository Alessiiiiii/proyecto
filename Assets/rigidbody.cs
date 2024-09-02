using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rigidbody : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public Vector2 inputVector;
    public Vector3 velocity;
    public Rigidbody Rigidbody;
    public float velocityMagnitude;
    public bool CanJump;
    
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        CanJump = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");

        Rigidbody.AddForce(inputVector.x*speed,0f,inputVector.y*speed,ForceMode.Impulse);
       
        velocity=Rigidbody.velocity;
        velocityMagnitude=velocity.magnitude;
        
        if (Input.GetKeyDown(KeyCode.Space)&& CanJump)
                
        {

            Rigidbody.AddForce(0f, jumpForce, 0f, ForceMode.Impulse);
            CanJump = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Choque cotra : " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("piso"))
        {
            CanJump = true;
        }

        if (collision.gameObject.CompareTag("KillZone"))
        {
            Debug.Log("Kill Mee");
            SceneManager.LoadScene(0);
        }
        if (collision.gameObject.CompareTag("Goal"){
            SceneManager.L
        }
    }
}
