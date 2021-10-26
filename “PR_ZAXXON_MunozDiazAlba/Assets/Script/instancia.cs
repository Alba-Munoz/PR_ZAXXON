using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instancia : MonoBehaviour
{


    // Start is called before the first frame update
    [SerializeField] GameObject obstaculo;
    [SerializeField] GameObject obstaculo_2;
    [SerializeField] Transform initPosOb1;
    [SerializeField] Transform initPosOb2;

    int level;
    float intervalo;

    [SerializeField] float distanciaEntreObstaculos;

    [SerializeField] float distPrimerObstaculo;

    [SerializeField] float distPrimerObst = 50f;

    float speed;

    void Start()
    {
        

        distanciaEntreObstaculos = 25f;

        distPrimerObstaculo = 45f;

        float numColumnasIniciales = (transform.position.z - distPrimerObstaculo) / distanciaEntreObstaculos;


        intervalo = 1f;

        CrearColumnasIniciales();

        StartCoroutine("CrearObstaculos");
        StartCoroutine("CerarObstaculos2");

    }
   
    // Update is called once per frame
    void Update()
    {
        
    }

    void CrearColumnasIniciales()
    {
        float numColumnasIniciales = (transform.position.z - distPrimerObst) / distanciaEntreObstaculos;

        numColumnasIniciales = Mathf.Round(numColumnasIniciales);

        for (float n = distPrimerObst; n < transform.position.z; n += distanciaEntreObstaculos)
        {
           
            Vector3 initColPos = new Vector3(Random.Range(-10f, 10f), 6.55f, n);
            Instantiate(obstaculo , initColPos, Quaternion.identity);

        }
    }


    IEnumerator CrearObstaculos()
    {
        while (true)
        {
          

            Vector3 instPos = new Vector3(Random.Range(-10f, 10f), 6.55f, initPosOb1.position.z);
          
            Instantiate(obstaculo, instPos, Quaternion.identity);
            yield return new WaitForSeconds(intervalo);



        }

      

    }
    IEnumerator CrearObstaculos2()
    {
        while (true)
        {

            Vector3 instPos = new Vector3(Random.Range(-10f, 10f), 6.55f, initPosOb2.position.z);

            Instantiate(obstaculo_2, instPos, Quaternion.identity);
            yield return new WaitForSeconds(intervalo);
        }
    }
}




