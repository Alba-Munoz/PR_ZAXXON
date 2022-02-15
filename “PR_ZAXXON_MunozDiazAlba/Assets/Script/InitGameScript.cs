using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InitGameScript : MonoBehaviour
{
    [SerializeField] GameObject Ship;
    public float spaceshipSpeed;

    // nivel
    public int levelGame;
    [SerializeField] Text nivel;

    [SerializeField] Text distText;

    static float dist;

    //Puntuación
    static float score;

    //Velocidad máxima
    [SerializeField] float maxSpeed;

    //¿Estoy vivo?
    bool alive;

    //UI
    float tiempoActual;


    [SerializeField] float vidas;

    [SerializeField] GameObject explos;
    [SerializeField] Transform ShipP;
        

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

        distText.text =  0f + "m";
     

        alive = true;

        tiempoActual = Time.time;

        
   
    }

    // Update is called once per frame
    void Update()
    {

        if (spaceshipSpeed < maxSpeed && alive == true)
        {
            spaceshipSpeed += 0.001f;
        }

        
        //print(Mathf.Round(tiempo));

     
     

        UpdateUI();
        
    }

    void UpdateUI()
    {
        float tiempo = Time.time - tiempoActual
            ;
        //print(Mathf.Round(tiempo));
        /*if (dist != 0)
        {
            score = Mathf.Round(tiempo) + dist;
        }*/

        if (dist == 0)
        {
            levelGame = 0;
        }
        else
        {
            score = Mathf.Round(tiempo) + dist;
        }

        if (score > 500 && score < 1000)
        {
            levelGame = 1;
        }

        else if (score > 1000 && score < 1500)
        {
            levelGame = 2;
        } 
        else if (score > 1500 && score < 2000)
        {
            levelGame = 3;
        }
        else if (score > 2000 && score < 2500)
        {
            levelGame = 4;
        }
        else if (score > 2500 && score < 3000)
        {
            levelGame = 5;
        }

        dist = Mathf.Round(tiempo) * spaceshipSpeed;

        distText.text = Mathf.Round(dist) + "m";

        nivel.text = "Level =" + levelGame;
      
    }

    //Morir
    public void Morir()
    {
        //print("La yukición fué realizada");
        alive = false;
        spaceshipSpeed = 0f;

        
       

        Vector3 explosPos = new Vector3(ShipP.position.x, ShipP.position.y, ShipP.position.z);
        Instantiate(explos, explosPos, Quaternion.identity);


        Invoke("GameOver", 1f);


       

    }

    void GameOver()
    {
        instancia instanciadorObst = GameObject.Find("Instanciador").GetComponent<instancia>();

        Ship.SetActive(false);

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
