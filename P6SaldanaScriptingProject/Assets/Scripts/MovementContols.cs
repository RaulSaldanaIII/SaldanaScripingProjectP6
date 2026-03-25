using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementContols : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    // Start is called before the first frame update
    void Update()
    {
        Movement();
    }

    // Update is called once per frame
    void Movement()
    {
        float fowardMovement = Input.GetAxis("Verticle") * speed * Time.deltaTime;
        float turnMovemnt = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * fowardMovement);
        transform.Rotate(Vector3.up * turnMovemnt);
    }
}
