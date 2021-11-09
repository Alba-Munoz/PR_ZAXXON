using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo_2 : MonoBehaviour
{
    [SerializeField] GameObject initObject;
    InitGameScript initGameScript;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        initObject = GameObject.Find("Initgame");

        initGameScript = initObject.GetComponent<InitGameScript>();

        speed = initGameScript.spaceshipSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        speed = initGameScript.spaceshipSpeed;
        //print("Mi velocidad es: " + initGameScript.spaceshipSpeed);
        transform.Translate(Vector3.back * Time.deltaTime * speed);

        float posZ = transform.position.z;

        if (posZ < -16)
        {
            Destroy(gameObject);
        }
    }
}
