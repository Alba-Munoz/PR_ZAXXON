using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instancia : MonoBehaviour
{
    InitGameScript initGameScript; 

    [SerializeField] GameObject obstaculo;

    [SerializeField] Transform initPos;

    int level;
    float intervalo;

    [SerializeField] float distanciaEntreObstaculos;

    [SerializeField] float distPrimerObstaculo;

    [SerializeField] float distPrimerObst;

    float speed;


    void Start()
    {
        initGameScript = GameObject.Find("Initgame").GetComponent<InitGameScript>();
        distanciaEntreObstaculos = 25f;

        distPrimerObstaculo = 45f;

        float numParedInicial = (transform.position.z - distPrimerObstaculo) / distanciaEntreObstaculos;


       
        CrearParedInicial();

        StartCoroutine("CrearObstaculos");

    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
    
    void CrearParedInicial()
    {
        float numParedInicial = (transform.position.z - distPrimerObst) / distanciaEntreObstaculos;

        numParedInicial = Mathf.Round(numParedInicial);

        for (float n = distPrimerObst; n < transform.position.z; n += distanciaEntreObstaculos)
        {

            Vector3 initColPos = new Vector3(Random.Range(-10f, 10f), 1f, n);
            Instantiate(obstaculo, initColPos, Quaternion.identity);

        }


    }

    IEnumerator CrearObstaculos()
    {
        while (true)
        {


            Vector3 instPos = new Vector3(Random.Range(-10f, 10f), 1.8f, initPos.position.z);

            intervalo = distanciaEntreObstaculos / initGameScript.spaceshipSpeed;

            Instantiate(obstaculo, instPos, Quaternion.identity);
            //print(intervalo);
            yield return new WaitForSeconds(intervalo);



        }

    }

}




