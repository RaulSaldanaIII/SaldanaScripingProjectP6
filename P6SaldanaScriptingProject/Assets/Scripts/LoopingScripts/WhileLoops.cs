using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    public int cupInTheSink = 4;
    // Start is called before the first frame update
    void Start()
    {
        while(cupInTheSink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupInTheSink--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
