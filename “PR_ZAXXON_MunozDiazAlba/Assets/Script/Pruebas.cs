using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pruebas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float desplX = Input.GetAxis("Horizontal");
        print(desplX);

        if(Input.GetButtonDown("Fire1"))
         {
            print("disparando");
        }
    }
}
