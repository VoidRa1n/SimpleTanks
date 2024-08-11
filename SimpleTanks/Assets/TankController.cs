using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    public float speed = 0.5f;
    private Vector3 moveVector;
    public int rotation;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.z = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);
        //if (Input.GetKeyDown(KeyCode.W)){
        //    transform.Rotate(0, 90, 0);
       // }
    }
}
