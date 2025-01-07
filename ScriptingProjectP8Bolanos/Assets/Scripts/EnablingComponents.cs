using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablingComponents : MonoBehaviour
{
    private Light myLightt;


    // Start is called before the first frame update
    void Start()
    {
        myLightt = GetComponent<Light>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            {
                myLightt.enabled = !myLightt.enabled;
            }
        }
    }
}
