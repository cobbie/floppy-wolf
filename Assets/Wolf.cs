using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf : MonoBehaviour
{
    public float speed = 2.5f; // Speed of the movement
    public float flapStrength;
    public Rigidbody2D myRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true) {
            myRigidBody.velocity = Vector2.up * flapStrength;
        }
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
