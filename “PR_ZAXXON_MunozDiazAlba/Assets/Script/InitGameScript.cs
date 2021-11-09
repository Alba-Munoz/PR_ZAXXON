using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InitGameScript : MonoBehaviour
{

    public float spaceshipSpeed;

    // nivel
    public int levelGame;

 


    //Puntuación
    static float score;

    //Velocidad máxima
    [SerializeField] float maxSpeed;

    //¿Estoy vivo?
    bool alive;

    //UI
 


    [SerializeField] float vidas;

    // Start is called before the first frame update
    void Start()
    {
        spaceshipSpeed = 30f;
        levelGame = 0;
        //Obtengo la escena en la que estoy y si es la de juego pongo el score a 0
        int y = SceneManager.GetActiveScene().buildIndex;
        if (y == 1)
        {
            score = 0;
        }

        maxSpeed = 100f;

     

        alive = true;

        float tiempoPasado = Time.time;

   
    }

    // Update is called once per frame
    void Update()
    {

        if (spaceshipSpeed < maxSpeed && alive == true)
        {
            spaceshipSpeed += 0.001f;
        }

        float tiempo = Time.time;
        //print(Mathf.Round(tiempo));

        score = Mathf.Round(tiempo) * spaceshipSpeed;
       
        if (score > 500 && score < 1000)
        {
            levelGame = 1;
        }
        else if (score > 1000)
        {
            levelGame = 2;
        }

        UpdateUI();
        
    }

    void UpdateUI()
    {
        float tiempo = Time.time;
        //print(Mathf.Round(tiempo));
        if (spaceshipSpeed != 0)
        {
            score = Mathf.Round(tiempo) * spaceshipSpeed;
        }

    
        if (score > 500 && score < 1000)
        {
            levelGame = 1;
        }
        else if (score > 1000)
        {
            levelGame = 2;
        }

     
    }

    //Morir
    public void Morir()
    {
        //print("La yukición fué realizada");
        alive = false;
        spaceshipSpeed = 0f;
        instancia instanciadorObst = GameObject.Find("Instanciador").GetComponent<instancia>();
        

        GameObject.Find("Nave").SetActive(false);

        SceneManager.LoadScene(0);

    }

    public void Chocar(GameObject other)
    {
        print("Me he chocado con :" + other.tag);
        vidas -= 10;
        if (vidas <= 0)
        {
            alive = false;
            Morir();
        }
        else
        {
            Destroy(other);
        }
    }

    public void Invec()
    {

        Invoke("PararInvenc", 2f);
    }

    void PararInvenc()
    {

    }

}
