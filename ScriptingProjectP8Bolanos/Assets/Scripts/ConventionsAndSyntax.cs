using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //i want to get the X location of a game object and shyow it on the console
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        // i want to know when a game objects y position is lower than 5\
        if(transform.position.y <= 5f)
        {
            Debug.Log("Im about to hit the ground!!");
        }
    }
}
