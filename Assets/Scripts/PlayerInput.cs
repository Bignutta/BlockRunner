using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;

    Rigidbody rigidBody;
    float forwardSpeed = 0.1f;

    bool addForce;
    

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * speed;
    }
    void FixedUpdate()
    {
        rigidBody.AddForce(Vector3.forward * forwardSpeed);
        transform.Translate(forwardSpeed, 0, 0);
    }
}
