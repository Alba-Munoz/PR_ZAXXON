using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instancia2 : MonoBehaviour
{
    [SerializeField] GameObject obstaculo_2;

    [SerializeField] Transform initPos;

    int level;
    float intervalo;

    [SerializeField] float distanciaEntreObstaculos;

    [SerializeField] float distPrimerObstaculo;

    [SerializeField] float distPrimerObst = 50f;

    float speed;
    // Start is called before the first frame update
    void Start()
    {
        distanciaEntreObstaculos = 25f;

        distPrimerObstaculo = 45f;

        float numParedInicial = (transform.position.z - distPrimerObstaculo) / distanciaEntreObstaculos;


        intervalo = 1f;

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

            Vector3 initColPos = new Vector3(Random.Range(-10f, 10f), 1.8f, n);
            Instantiate(obstaculo_2, initColPos, Quaternion.identity);

        }
    }


    IEnumerator CrearObstaculos()
    {
        while (true)
        {


            Vector3 instPos = new Vector3(Random.Range(-10f, 10f), 1.8f, initPos.position.z);

            Instantiate(obstaculo_2, instPos, Quaternion.identity);
            yield return new WaitForSeconds(intervalo);



        }



    }
}
