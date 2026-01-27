using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateAndRotate : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnspeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

       if(Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up, -turnspeed * Time.deltaTime);

        if(Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, turnspeed * Time.deltaTime);
    }
}
