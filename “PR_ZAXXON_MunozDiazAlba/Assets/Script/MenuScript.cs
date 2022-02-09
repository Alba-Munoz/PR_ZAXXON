using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScript : MonoBehaviour
{
    [SerializeField] AudioSource boton;

    [SerializeField] AudioClip clipBtn;

    int escenaAcargar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CargarEscena(int escena)
    {
        
        boton.PlayOneShot(clipBtn);
        //Cargo la escena, pero al cabo de un tiempo, lo que dura el sonido del botón
        Invoke("CargarEscenaAhoraSi", clipBtn.length);
        escenaAcargar = escena;
    }

    void CargarEscenaAhoraSi()
    {
        SceneManager.LoadScene(escenaAcargar);
    }

}
