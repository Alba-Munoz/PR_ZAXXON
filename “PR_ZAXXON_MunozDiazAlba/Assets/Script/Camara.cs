using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    [SerializeField] Transform playerPosition;
    //Variables necesarias para la opción de suavizado
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

    

        transform.position = new Vector3(playerPosition.position.x, playerPosition.position.y + 1.5f, playerPosition.position.z - 10);
      
        

        transform.LookAt(playerPosition);
    }
}
