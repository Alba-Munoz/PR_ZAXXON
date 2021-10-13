using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instancia : MonoBehaviour
{


    // Start is called before the first frame update
    [SerializeField] GameObject obstaculo;
   
    [SerializeField] Transform initPos;

    float intervalo;

    float speed;
 
    [SerializeField] float distanciaEntreObstaculos;

    [SerializeField] float distPrimerObstaculo;

    void Start()
    {
        
        distanciaEntreObstaculos = 25f;

        distPrimerObstaculo = 45f;

        float numColumnasIniciales = (transform.position.z - distPrimerObstaculo) / distanciaEntreObstaculos;


        intervalo = 1f;
        StartCoroutine("CrearObstaculos");

    }
   
    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CrearObstaculos()
    {
        while (true)
        {
           
            Vector3 instPos = new Vector3(Random.Range(-10f, 10f), 0f, initPos.position.z);
          
            Instantiate(obstaculo, instPos, Quaternion.identity);
            yield return new WaitForSeconds(intervalo);

        }
    }

}




