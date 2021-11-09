using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{

    [SerializeField] float desplSpeed;
    [SerializeField] GameObject Nave;

    float limiteR = 10;
    float limiteL =-10;
    float limiteU = 14;
    float limiteD = 1;

    bool inLimitH = true;
    bool inLimitV = true;
    InitGameScript initGameScript;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0f, 2.3f, 0f);
        //Le asigno un valor a la velocidad de desplazamiento
        desplSpeed = 30f;

        initGameScript = GameObject.Find("Initgame").GetComponent<InitGameScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //print(Input.GetAxis("Horizontal"));
        //print(Input.GetAxis("Vertical"));

        float desplH = Input.GetAxis("Horizontal");
        float desplV = Input.GetAxis("Vertical");

        float posX = transform.position.x;
        float posY = transform.position.y;

       
        //Horizontal//

        if (inLimitH)
        {
            transform.Translate(Vector3.right * Time.deltaTime * desplH * desplSpeed, Space.World);
        }


        if (inLimitV)
        {
            transform.Translate(Vector3.up * Time.deltaTime * desplV * desplSpeed, Space.World);
        }

        if ((posX > limiteR && desplH > 0 ) || ( posX < limiteL && desplH < 0))
        {
           
            inLimitH = false;
        }
        else
        {
            
            inLimitH = true;
        }


        //Vertical//

        if ((posY > limiteU && desplV > 0) || (posY < limiteD && desplV < 0))
        {
            inLimitV = false;
        }

        else
        {
            inLimitV = true;
        }

    }


    

        private void OnTriggerEnter(Collider other)
        {
            //print("Ostia");
            if (other.gameObject.layer == 0)
            {

                initGameScript.SendMessage("Morir");
                Nave.SetActive(false);
                //Destroy(gameObject);

            }
        }
    


}
