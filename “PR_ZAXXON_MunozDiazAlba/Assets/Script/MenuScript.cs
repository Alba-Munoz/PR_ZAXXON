using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScript : MonoBehaviour
{
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
        SceneManager.LoadScene(escena);
    }

    public void GoHihgScores(int escena)
    {
        SceneManager.LoadScene(escena);
    }

    public void GoConfiguracion(int escena)
    {
        SceneManager.LoadScene(escena);
    }
}
