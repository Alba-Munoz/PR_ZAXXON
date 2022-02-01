using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instancia_2 : MonoBehaviour
{
    InitGameScript initGameScript;

    [SerializeField] GameObject maggellan_ex;

    [SerializeField] Transform initPos;

    int level;
    float intervalo;

    [SerializeField] float distanciaEntreObstaculos;

    [SerializeField] float distPrimerObstaculo;

    [SerializeField] float distPrimerObst;

    float speed;
    // Start is called before the first frame update
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

            Vector3 initColPos = new Vector3(Random.Range(-10f, 10f), Random.Range(1.6f, 7f), n);
            Instantiate(maggellan_ex, initColPos, Quaternion.identity);

        }


    }

    IEnumerator CrearObstaculos()
    {
        while (true)
        {


            Vector3 instPos = new Vector3(Random.Range(-10f, 10f), Random.Range(1.6f, 7f),initPos.position.z) ;

            intervalo = distanciaEntreObstaculos / initGameScript.spaceshipSpeed;


            Instantiate(maggellan_ex, instPos, Quaternion.identity);
            yield return new WaitForSeconds(intervalo);



        }

    }
}