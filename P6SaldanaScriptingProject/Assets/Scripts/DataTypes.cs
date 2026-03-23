using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DataTypes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       //Value type variable
        Vector3 pos = transform.position;
        pos = new Vector3(0, 2, 0);

        //Refrence type variable
        Transform tran = transform;
        transform.position = new Vector3(0, 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
