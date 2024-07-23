using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 8;
    public float deleteIfXCoordinate = -30;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deleteIfXCoordinate){
            Debug.Log("Deleted Pipe");
            Destroy(gameObject);
        }
    }
}
