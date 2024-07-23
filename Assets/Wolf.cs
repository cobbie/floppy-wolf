using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf : MonoBehaviour
{
    public float speed = 2.5f; // Speed of the movement
    public float flapStrength;
    public LogicManager logic;
    public Rigidbody2D myRigidBody;
    public bool alive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && alive) {
            myRigidBody.velocity = Vector2.up * flapStrength;
        }
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        alive = false;
    }
}
