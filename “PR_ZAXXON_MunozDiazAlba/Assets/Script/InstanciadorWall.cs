using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorWall : MonoBehaviour
{
    [SerializeField] GameObject ladrillin;
    [SerializeField] Transform initPos;

    float separacion;
    // Start is called before the first frame update
    void Start()
    {
        separacion = 0.5f;

        Vector3 newPos = initPos.position;
        Vector3 despl = new Vector3(separacion ,0f , 0f);

      
        for(int n = 0; n < 10; n++)
        {
            Instantiate(ladrillin,newPos, Quaternion.identity);
            newPos = newPos + despl;
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
